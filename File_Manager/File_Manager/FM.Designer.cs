namespace File_Manager
{
    partial class FM
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM));
            this.listView_FM = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_Options_View = new System.Windows.Forms.ToolStripComboBox();
            this.скрытыеЭлементыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.флажкиЭлементовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_paste = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_cut = new System.Windows.Forms.Button();
            this.button_properties = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.button_forward = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_FM
            // 
            this.listView_FM.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView_FM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_FM.BackColor = System.Drawing.SystemColors.Window;
            this.listView_FM.CheckBoxes = true;
            this.listView_FM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_Data,
            this.columnHeader_Size});
            this.listView_FM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView_FM.Location = new System.Drawing.Point(12, 138);
            this.listView_FM.Name = "listView_FM";
            this.listView_FM.Size = new System.Drawing.Size(1308, 722);
            this.listView_FM.TabIndex = 0;
            this.listView_FM.UseCompatibleStateImageBehavior = false;
            this.listView_FM.View = System.Windows.Forms.View.Details;
            this.listView_FM.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_FM_ColumnClick);
            this.listView_FM.ItemActivate += new System.EventHandler(this.listView_FM_ItemActivate);
            this.listView_FM.SelectedIndexChanged += new System.EventHandler(this.listView_FM_SelectedIndexChanged);
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 484;
            // 
            // columnHeader_Data
            // 
            this.columnHeader_Data.Text = "Data";
            this.columnHeader_Data.Width = 299;
            // 
            // columnHeader_Size
            // 
            this.columnHeader_Size.Text = "Size(Byte)";
            this.columnHeader_Size.Width = 518;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1332, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.скрытыеЭлементыToolStripMenuItem,
            this.флажкиЭлементовToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_Options_View});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewToolStripMenuItem.Text = "Вид";
            // 
            // toolStripComboBox_Options_View
            // 
            this.toolStripComboBox_Options_View.Items.AddRange(new object[] {
            "Details",
            "List"});
            this.toolStripComboBox_Options_View.Name = "toolStripComboBox_Options_View";
            this.toolStripComboBox_Options_View.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox_Options_View.TextChanged += new System.EventHandler(this.toolStripComboBox_Options_View_TextChanged);
            // 
            // скрытыеЭлементыToolStripMenuItem
            // 
            this.скрытыеЭлементыToolStripMenuItem.CheckOnClick = true;
            this.скрытыеЭлементыToolStripMenuItem.Name = "скрытыеЭлементыToolStripMenuItem";
            this.скрытыеЭлементыToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.скрытыеЭлементыToolStripMenuItem.Text = "Скрытые элементы";
            this.скрытыеЭлементыToolStripMenuItem.CheckedChanged += new System.EventHandler(this.скрытыеЭлементыToolStripMenuItem_CheckedChanged);
            // 
            // флажкиЭлементовToolStripMenuItem
            // 
            this.флажкиЭлементовToolStripMenuItem.Checked = true;
            this.флажкиЭлементовToolStripMenuItem.CheckOnClick = true;
            this.флажкиЭлементовToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.флажкиЭлементовToolStripMenuItem.Name = "флажкиЭлементовToolStripMenuItem";
            this.флажкиЭлементовToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.флажкиЭлементовToolStripMenuItem.Text = "Флажки элементов";
            this.флажкиЭлементовToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.флажкиЭлементовToolStripMenuItem_CheckStateChanged);
            // 
            // button_delete
            // 
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Image = global::File_Manager.Properties.Resources.корзина;
            this.button_delete.Location = new System.Drawing.Point(617, 47);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 85);
            this.button_delete.TabIndex = 9;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_paste
            // 
            this.button_paste.Enabled = false;
            this.button_paste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_paste.Image = global::File_Manager.Properties.Resources.paste;
            this.button_paste.Location = new System.Drawing.Point(794, 47);
            this.button_paste.Name = "button_paste";
            this.button_paste.Size = new System.Drawing.Size(100, 85);
            this.button_paste.TabIndex = 8;
            this.button_paste.UseVisualStyleBackColor = true;
            this.button_paste.Click += new System.EventHandler(this.button_paste_Click);
            // 
            // button_copy
            // 
            this.button_copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_copy.Image = global::File_Manager.Properties.Resources.copy;
            this.button_copy.Location = new System.Drawing.Point(973, 47);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(100, 85);
            this.button_copy.TabIndex = 7;
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_cut
            // 
            this.button_cut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cut.Image = global::File_Manager.Properties.Resources.cut;
            this.button_cut.Location = new System.Drawing.Point(1079, 47);
            this.button_cut.Name = "button_cut";
            this.button_cut.Size = new System.Drawing.Size(100, 85);
            this.button_cut.TabIndex = 6;
            this.button_cut.UseVisualStyleBackColor = true;
            this.button_cut.Click += new System.EventHandler(this.button_cut_Click);
            // 
            // button_properties
            // 
            this.button_properties.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_properties.Image = global::File_Manager.Properties.Resources.options;
            this.button_properties.Location = new System.Drawing.Point(1220, 47);
            this.button_properties.Name = "button_properties";
            this.button_properties.Size = new System.Drawing.Size(100, 85);
            this.button_properties.TabIndex = 4;
            this.button_properties.UseVisualStyleBackColor = true;
            this.button_properties.Click += new System.EventHandler(this.button_properties_Click);
            // 
            // button_home
            // 
            this.button_home.Enabled = false;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_home.Image = ((System.Drawing.Image)(resources.GetObject("button_home.Image")));
            this.button_home.Location = new System.Drawing.Point(224, 47);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(100, 85);
            this.button_home.TabIndex = 3;
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_forward
            // 
            this.button_forward.Enabled = false;
            this.button_forward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_forward.Image = global::File_Manager.Properties.Resources.forward;
            this.button_forward.Location = new System.Drawing.Point(118, 47);
            this.button_forward.Name = "button_forward";
            this.button_forward.Size = new System.Drawing.Size(100, 85);
            this.button_forward.TabIndex = 2;
            this.button_forward.UseVisualStyleBackColor = true;
            this.button_forward.Click += new System.EventHandler(this.button_forward_Click);
            // 
            // button_back
            // 
            this.button_back.Enabled = false;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Image = global::File_Manager.Properties.Resources.back;
            this.button_back.Location = new System.Drawing.Point(12, 47);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 85);
            this.button_back.TabIndex = 1;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // FM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1332, 872);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_paste);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.button_cut);
            this.Controls.Add(this.button_properties);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.button_forward);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.listView_FM);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FM";
            this.Text = "FM";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_FM;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_forward;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_properties;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Options_View;
        private System.Windows.Forms.Button button_cut;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_paste;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Data;
        private System.Windows.Forms.ColumnHeader columnHeader_Size;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ToolStripMenuItem скрытыеЭлементыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem флажкиЭлементовToolStripMenuItem;
    }
}

