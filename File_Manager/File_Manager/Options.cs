using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Manager
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        TextBox textBox_Name;
        TextBox label_fullname;
        string fullname;
        string NameOFFileorDir="";

        public void create(Files_ file)
        {
            fullname = file.fullname;
            textBox_Name = new TextBox();
            NameOFFileorDir = file.name;
            textBox_Name.Text = file.name;
            textBox_Name.Location = new Point(100, 90);
            textBox_Name.Size = new Size(300, 15);
            Controls.Add(textBox_Name);
            //
            Label label_TypeFile = new Label();
            label_TypeFile.Text = "Тип файла";
            label_TypeFile.Location = new Point(33, 132);
            label_TypeFile.Size = new Size(65, 15);
            Controls.Add(label_TypeFile);

            TextBox textBox_TypeFile = new TextBox();
            textBox_TypeFile.Text = file.type;
            textBox_TypeFile.ReadOnly = true;
            textBox_TypeFile.Location = new Point(100, 130);
            textBox_TypeFile.Size = new Size(300, 15);
            Controls.Add(textBox_TypeFile);
            //
            Label label_DataFile = new Label();
            label_DataFile.Text = "Изменен";
            label_DataFile.Location = new Point(42, 162);
            label_DataFile.Size = new Size(57, 15);
            Controls.Add(label_DataFile);

            TextBox textBox_DataFile = new TextBox();
            textBox_DataFile.Text = file.data;
            textBox_DataFile.ReadOnly = true;
            textBox_DataFile.Location = new Point(100, 160);
            textBox_DataFile.Size = new Size(300, 15);
            Controls.Add(textBox_DataFile);
            //
            Label label_fullnameFile = new Label();
            label_fullnameFile.Text = "Расположение";
            label_fullnameFile.Location = new Point(13, 192);
            label_fullnameFile.Size = new Size(85, 15);
            Controls.Add(label_fullnameFile);

            label_fullname = new TextBox();
            label_fullname.Text = file.fullname;
            label_fullname.ReadOnly = true;
            label_fullname.Location = new Point(100, 190);
            label_fullname.Size = new Size(300, 15);
            Controls.Add(label_fullname);
            //
            Label label_SizeFile = new Label();
            label_SizeFile.Text = "Размер";
            label_SizeFile.Location = new Point(42, 222);
            label_SizeFile.Size = new Size(57, 15);
            Controls.Add(label_SizeFile);

            TextBox textBox_SizeFile = new TextBox();
            textBox_SizeFile.Text = file.size.ToString()+" байт";
            textBox_SizeFile.ReadOnly = true;
            textBox_SizeFile.Location = new Point(100, 220);
            textBox_SizeFile.Size = new Size(300, 15);
            Controls.Add(textBox_SizeFile);
            //
            Label label_AtrFile = new Label();
            label_AtrFile.Text = "Атрибуты";
            label_AtrFile.Location = new Point(42, 252);
            label_AtrFile.Size = new Size(57, 15);
            Controls.Add(label_AtrFile);

            TextBox textBox_AtrFile = new TextBox();
            textBox_AtrFile.Text = file.Attributes;
            textBox_AtrFile.ReadOnly = true;
            textBox_AtrFile.Location = new Point(100, 250);
            textBox_AtrFile.Size = new Size(300, 15);
            Controls.Add(textBox_AtrFile);
            //
            PictureBox pictureBox_File = new PictureBox();
            pictureBox_File.Location = new Point(42, 82);
            pictureBox_File.Size = new Size(100, 100);
            pictureBox_File.Image = file.icon.ToBitmap();
            Controls.Add(pictureBox_File);

        }
        public void create(Directory_ dir)
        {
            fullname = dir.fullname;
            PictureBox pictureBox_Dir = new PictureBox();
            pictureBox_Dir.Location = new Point(13, 30);
            pictureBox_Dir.Size = new Size(150, 150);
            pictureBox_Dir.Image = Image.FromFile("Folder.ico");
            Controls.Add(pictureBox_Dir);
            //
            textBox_Name = new TextBox();
            NameOFFileorDir = dir.name;
            textBox_Name.Text = dir.name;
            textBox_Name.Location = new Point(200, 95);
            textBox_Name.Size = new Size(250, 15);
            Controls.Add(textBox_Name);
            //
            Label label_TypeDir = new Label();
            label_TypeDir.Text = "Тип папки";
            label_TypeDir.Location = new Point(33, 192);
            label_TypeDir.Size = new Size(65, 15);
            Controls.Add(label_TypeDir);

            TextBox textBox_TypeDir = new TextBox();
            textBox_TypeDir.Text = dir.type;
            textBox_TypeDir.ReadOnly = true;
            textBox_TypeDir.Location = new Point(100, 190);
            textBox_TypeDir.Size = new Size(300, 15);
            Controls.Add(textBox_TypeDir);
            //
            Label label_DataDir = new Label();
            label_DataDir.Text = "Изменен";
            label_DataDir.Location = new Point(42, 222);
            label_DataDir.Size = new Size(57, 15);
            Controls.Add(label_DataDir);

            TextBox textBox_DataDir = new TextBox();
            textBox_DataDir.Text = dir.data;
            textBox_DataDir.ReadOnly = true;
            textBox_DataDir.Location = new Point(100, 220);
            textBox_DataDir.Size = new Size(300, 15);
            Controls.Add(textBox_DataDir);
            //
            Label label_fullnameDir = new Label();
            label_fullnameDir.Text = "Расположение";
            label_fullnameDir.Location = new Point(13, 252);
            label_fullnameDir.Size = new Size(85, 15);
            Controls.Add(label_fullnameDir);

            label_fullname = new TextBox();
            label_fullname.Text = dir.fullname;
            label_fullname.ReadOnly = true;
            label_fullname.Location = new Point(100, 250);
            label_fullname.Size = new Size(300, 15);
            Controls.Add(label_fullname);         
            //
            Label label_DirFile = new Label();
            label_DirFile.Text = "Атрибуты";
            label_DirFile.Location = new Point(42, 282);
            label_DirFile.Size = new Size(57, 15);
            Controls.Add(label_DirFile);

            TextBox textBox_DirFile = new TextBox();
            textBox_DirFile.Text = dir.Attributes;
            textBox_DirFile.ReadOnly = true;
            textBox_DirFile.Location = new Point(100, 280);
            textBox_DirFile.Size = new Size(300, 15);
            Controls.Add(textBox_DirFile); 
        }
        public void create(Disks_ disk)
        {
            PictureBox pictureBox_File = new PictureBox();
            pictureBox_File.Location = new Point(13, 30);
            pictureBox_File.Size = new Size(150, 150);
            pictureBox_File.Image = Image.FromFile("disk.png");
            Controls.Add(pictureBox_File);
            //
            textBox_Name = new TextBox();
            textBox_Name.Text = disk.name;
            textBox_Name.ReadOnly = true;
            textBox_Name.Location = new Point(200, 95);
            textBox_Name.Size = new Size(250, 15);
            Controls.Add(textBox_Name);
            //
            Label label_driveFormat = new Label();
            label_driveFormat.Text = "Имя файловой системы";
            label_driveFormat.Location = new Point(1, 192);
            label_driveFormat.Size = new Size(150, 15);
            Controls.Add(label_driveFormat);

            TextBox textBox_driveFormat = new TextBox();
            textBox_driveFormat.Text = disk.driveFormat;
            textBox_driveFormat.ReadOnly = true;
            textBox_driveFormat.Location = new Point(151, 190);
            textBox_driveFormat.Size = new Size(249, 15);
            Controls.Add(textBox_driveFormat);
            //
            Label label_totalSize = new Label();
            label_totalSize.Text = "Емкость";
            label_totalSize.Location = new Point(42, 222);
            label_totalSize.Size = new Size(57, 15);
            Controls.Add(label_totalSize);

            TextBox textBox_DataFile = new TextBox();
            textBox_DataFile.Text = disk.totalSize.ToString();
            textBox_DataFile.ReadOnly = true;
            textBox_DataFile.Location = new Point(100, 220);
            textBox_DataFile.Size = new Size(300, 15);
            Controls.Add(textBox_DataFile);
            //
            Label label_freeSpace = new Label();
            label_freeSpace.Text = "Свободно";
            label_freeSpace.Location = new Point(40, 252);
            label_freeSpace.Size = new Size(59, 15);
            Controls.Add(label_freeSpace);

            TextBox textBox_freeSpace = new TextBox();
            textBox_freeSpace.Text = disk.freeSpace.ToString();
            textBox_freeSpace.ReadOnly = true;
            textBox_freeSpace.Location = new Point(100, 250);
            textBox_freeSpace.Size = new Size(300, 15);
            Controls.Add(textBox_freeSpace);
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (NameOFFileorDir != textBox_Name.Text)
            {
                try
                {
                    if (File.Exists(label_fullname.Text)) File.Move(fullname, Func.PathToFile + "\\" + textBox_Name.Text);
                    if (Directory.Exists(label_fullname.Text)) Directory.Move(fullname, Func.PathToFile + "\\" + textBox_Name.Text);
                }
                catch { MessageBox.Show("Отказано в доступе"); }
            }            
            this.Close();
        }

    }
}
