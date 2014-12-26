using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager
{
    public partial class FM : Form
    {
        public FM()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();
            t.SetToolTip(button_home, Class_constants.button_home);
            t.SetToolTip(button_back, Class_constants.button_back);
            t.SetToolTip(button_forward, Class_constants.button_forward);
            t.SetToolTip(button_properties, Class_constants.button_properties);
            t.SetToolTip(button_copy, Class_constants.button_copy);
            t.SetToolTip(button_cut, Class_constants.button_cut);
            t.SetToolTip(button_paste,Class_constants.button_paste);
            t.SetToolTip(button_delete, Class_constants.button_delete);

            toolStripComboBox_Options_View.Text = Class_constants.listView_View_details;

            listView_Show_ALL();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public static ImageList imageList1;
        ListViewItem item;
        private All_Type ALLTYPE = new All_Type();
        List<string> check = new List<string>();
         
        public void listView_Show_ALL()
        {
                imageList1 = new ImageList();
                listView_FM.SmallImageList = imageList1;
                listView_FM.SmallImageList.ImageSize = new Size(40, 40);

                ALLTYPE = new All_Type();
                ALLTYPE = Func.Get_File_Directory_Disk();
                show();
        }
        public void show()
        {
            listView_FM.BeginUpdate();
            listView_FM.Items.Clear();
            foreach (Disks_ ds in ALLTYPE.list_disks)
            {
                item = new ListViewItem(ds.name, 1);
                imageList1.Images.Add("disk", Image.FromFile("disk.png"));
                item.ImageKey = "disk";
                listView_FM.Items.Add(ds.name).ImageKey = "disk";
            }
            foreach (Directory_ dir in ALLTYPE.list_dir)
            {
                item = new ListViewItem(dir.name, 1);
                ListViewItem.ListViewSubItem data = new ListViewItem.ListViewSubItem();
                data.Text = dir.data;
                item.SubItems.Add(data);
                imageList1.Images.Add("directory", Image.FromFile("Folder.ico"));
                item.ImageKey = "directory";
                listView_FM.Items.Add(item).ImageKey = "directory";
            }
            foreach (Files_ fs in ALLTYPE.list_files)
            {
                item = new ListViewItem(fs.name, 1);
                ListViewItem.ListViewSubItem data = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem size = new ListViewItem.ListViewSubItem();
                data.Text = fs.data; size.Text = fs.size.ToString();
                item.SubItems.Add(data);
                item.SubItems.Add(size);
                if (!imageList1.Images.ContainsKey(fs.Extension))
                {
                    imageList1.Images.Add(fs.Extension, fs.icon);
                }
                item.ImageKey = fs.Extension;
                listView_FM.Items.Add(item).ImageKey = fs.Extension;
            }
            listView_FM.EndUpdate();
        }
        private void listView_FM_ItemActivate(object sender, EventArgs e)
        {
            button_back.Enabled = true; button_home.Enabled = true;//включаем кнопку 

            if (listView_FM.SelectedItems.Count == 0) return;
            item = listView_FM.SelectedItems[0];

            Func.Item__Activate(item.Text);
            listView_Show_ALL();
        }

        private void toolStripComboBox_Options_View_TextChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox_Options_View.Text)
            {
                case Class_constants.listView_View_details: { listView_FM.View = View.Details; break; }
                case Class_constants.listView_View_list: { listView_FM.View = View.List; break; }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            button_forward.Enabled = true;
            Func.button_back();
            if (Func.PathToFile == "") { button_back.Enabled = false; button_home.Enabled = false; }
            listView_Show_ALL();
        }
        private void button_forward_Click(object sender, EventArgs e)
        {
            button_back.Enabled = true; button_home.Enabled = true;
            Func.button_forward();
            if (Func.forward.Count == 0) button_forward.Enabled = false;//гасим кнопку если лист пуст
            listView_Show_ALL();
        }
        private void button_home_Click(object sender, EventArgs e)
        {
            Func.button_home();
            button_forward.Enabled = true;
            button_back.Enabled = false;
            button_home.Enabled = false;
            listView_Show_ALL();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            button_copy.Enabled = true;
            button_cut.Enabled = true;
            button_paste.Enabled = false;
            check.Clear();
            foreach (ListViewItem Item in listView_FM.Items)
            {
                if (Item != null)
                {
                    if (Item.Checked == true) check.Add(Item.Text);
                }
            }
            if(check.Count!=0)Func.delete(check);
            listView_Show_ALL();     
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            button_cut.Enabled = false;
            button_copy.Enabled = false;
            Func.CopyORcut = Class_constants.button_copy;
            check.Clear();
            foreach (ListViewItem Item in listView_FM.Items)
            {
                if (Item.Checked == true) { check.Add(Item.Text); button_paste.Enabled = true; }
            }
            Func.PathToFile_copy = Func.PathToFile;
            Func.COPYorCUT = check;

        }
        private void button_paste_Click(object sender, EventArgs e)
        {
            button_cut.Enabled = true;
            button_copy.Enabled = true;
            switch (Func.CopyORcut)
            {
                case Class_constants.button_copy: { Func.PASTE_copy(); break; }
                case Class_constants.button_cut: { Func.PASTE_cut(); break; }            
            }
            button_paste.Enabled = false;
            listView_Show_ALL();
        }
        private void button_cut_Click(object sender, EventArgs e)
        {
            button_cut.Enabled = false;
            button_copy.Enabled = false;
            Func.CopyORcut = Class_constants.button_cut;
            check.Clear();
            foreach (ListViewItem Item in listView_FM.Items)
            {
                if (Item.Checked == true) { check.Add(Item.Text); button_paste.Enabled = true; }
            }
            Func.PathToFile_copy = Func.PathToFile;
            Func.COPYorCUT = check;
        }

        private void button_properties_Click(object sender, EventArgs e)
        {           
            foreach (ListViewItem a in listView_FM.Items)
            {
                if (a.Checked) 
                { 
                    Options form = new Options();
                    if (System.IO.Directory.Exists(Func.PathToFile + "\\" + listView_FM.Items[a.Index].Text)) { form.create(ALLTYPE.list_dir[a.Index - ALLTYPE.list_disks.Count]); }
                    else
                    {
                        if (System.IO.File.Exists(Func.PathToFile + "\\" + listView_FM.Items[a.Index].Text)) { form.create(ALLTYPE.list_files[a.Index - ALLTYPE.list_disks.Count - ALLTYPE.list_dir.Count]); }
                        else form.create(ALLTYPE.list_disks[a.Index]);
                    }
                    form.Show();
                }
            }            
        }

        private void скрытыеЭлементыToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Func.hidden = скрытыеЭлементыToolStripMenuItem.Checked;
            listView_Show_ALL();
        }

        private void флажкиЭлементовToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            listView_FM.CheckBoxes = флажкиЭлементовToolStripMenuItem.Checked;
        }


        private void listView_FM_SelectedIndexChanged(object sender, EventArgs e)//ставим check у выделенных элементов
        {
            foreach (ListViewItem a in listView_FM.Items)
            {
                a.Checked = a.Selected;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//обработка нажатия клавиш
        {
            switch (e.KeyCode)
            {
                case Keys.Delete: { button_delete.PerformClick(); break; }
                case Keys.C: { if (e.Control) { button_copy.PerformClick(); } break; }
                case Keys.V: { if (e.Control) { button_paste.PerformClick(); } break; }
                case Keys.X: { if (e.Control) { button_cut.PerformClick(); } break; }
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            listView_Show_ALL();
        }

        public static int sortby = -1;
        public static string Up_Down="up";
        private void listView_FM_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (sortby == e.Column) 
            {
                if (Up_Down == "up") Up_Down = "down";
                else Up_Down = "up";
            }
            else Up_Down = "up";
            sortby = e.Column;
            if(e.Column!=2)ALLTYPE.list_dir.Sort();
            ALLTYPE.list_files.Sort();
            show();
        }
    }
}
