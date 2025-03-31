namespace Arma3_Fov_Changer_2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            GUI_profile_label = new Label();
            GUI_btn_filechoose = new Button();
            GUI_groupbox = new GroupBox();
            GUI_label_link_1 = new LinkLabel();
            GUI_label_link = new LinkLabel();
            GUI_combo_screen = new ComboBox();
            GUI_combo_fov = new ComboBox();
            GUI_checkbox_bakup = new CheckBox();
            GUI_btn_save = new Button();
            GUI_label_1 = new Label();
            GUI_label_0 = new Label();
            openFileDialog = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            GUI_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GUI_profile_label
            // 
            GUI_profile_label.AutoSize = true;
            GUI_profile_label.Location = new Point(104, 26);
            GUI_profile_label.Name = "GUI_profile_label";
            GUI_profile_label.Size = new Size(213, 15);
            GUI_profile_label.TabIndex = 0;
            GUI_profile_label.Text = "Выберите ваш профиль .arma3profile";
            // 
            // GUI_btn_filechoose
            // 
            GUI_btn_filechoose.Location = new Point(23, 20);
            GUI_btn_filechoose.Name = "GUI_btn_filechoose";
            GUI_btn_filechoose.Size = new Size(75, 26);
            GUI_btn_filechoose.TabIndex = 1;
            GUI_btn_filechoose.Text = "Выбрать";
            GUI_btn_filechoose.UseVisualStyleBackColor = true;
            GUI_btn_filechoose.Click += GUI_btn_filechoose_Click;
            // 
            // GUI_groupbox
            // 
            GUI_groupbox.BackColor = Color.Transparent;
            GUI_groupbox.Controls.Add(GUI_label_link_1);
            GUI_groupbox.Controls.Add(GUI_label_link);
            GUI_groupbox.Controls.Add(GUI_combo_screen);
            GUI_groupbox.Controls.Add(GUI_combo_fov);
            GUI_groupbox.Controls.Add(GUI_checkbox_bakup);
            GUI_groupbox.Controls.Add(GUI_btn_save);
            GUI_groupbox.Controls.Add(GUI_label_1);
            GUI_groupbox.Controls.Add(GUI_label_0);
            GUI_groupbox.Enabled = false;
            GUI_groupbox.Location = new Point(23, 67);
            GUI_groupbox.Name = "GUI_groupbox";
            GUI_groupbox.Size = new Size(486, 152);
            GUI_groupbox.TabIndex = 2;
            GUI_groupbox.TabStop = false;
            GUI_groupbox.Text = "Параметры";
            // 
            // GUI_label_link_1
            // 
            GUI_label_link_1.AutoSize = true;
            GUI_label_link_1.Location = new Point(356, 62);
            GUI_label_link_1.Name = "GUI_label_link_1";
            GUI_label_link_1.Size = new Size(94, 15);
            GUI_label_link_1.TabIndex = 4;
            GUI_label_link_1.TabStop = true;
            GUI_label_link_1.Text = "Посетить Itch.io";
            GUI_label_link_1.LinkClicked += GUI_label_link_1_LinkClicked;
            // 
            // GUI_label_link
            // 
            GUI_label_link.AutoSize = true;
            GUI_label_link.Location = new Point(356, 40);
            GUI_label_link.Name = "GUI_label_link";
            GUI_label_link.Size = new Size(99, 15);
            GUI_label_link.TabIndex = 4;
            GUI_label_link.TabStop = true;
            GUI_label_link.Text = "Посетить GitHub";
            GUI_label_link.LinkClicked += GUI_label_link_LinkClicked;
            // 
            // GUI_combo_screen
            // 
            GUI_combo_screen.DropDownStyle = ComboBoxStyle.DropDownList;
            GUI_combo_screen.FormattingEnabled = true;
            GUI_combo_screen.Items.AddRange(new object[] { "7680×4320", "3840×2160", "3100×1440", "2560×1440", "1920×1080", "1366×768", "1280×720", "640×480" });
            GUI_combo_screen.Location = new Point(20, 56);
            GUI_combo_screen.Name = "GUI_combo_screen";
            GUI_combo_screen.Size = new Size(165, 23);
            GUI_combo_screen.TabIndex = 6;
            GUI_combo_screen.SelectionChangeCommitted += ComboboxSelectIndex;
            // 
            // GUI_combo_fov
            // 
            GUI_combo_fov.DropDownStyle = ComboBoxStyle.DropDownList;
            GUI_combo_fov.FormattingEnabled = true;
            GUI_combo_fov.Items.AddRange(new object[] { "120", "110", "100", "90", "80", "70" });
            GUI_combo_fov.Location = new Point(201, 56);
            GUI_combo_fov.Name = "GUI_combo_fov";
            GUI_combo_fov.Size = new Size(93, 23);
            GUI_combo_fov.TabIndex = 6;
            GUI_combo_fov.SelectionChangeCommitted += ComboboxSelectIndex;
            // 
            // GUI_checkbox_bakup
            // 
            GUI_checkbox_bakup.AutoSize = true;
            GUI_checkbox_bakup.Checked = true;
            GUI_checkbox_bakup.CheckState = CheckState.Checked;
            GUI_checkbox_bakup.Location = new Point(201, 111);
            GUI_checkbox_bakup.Name = "GUI_checkbox_bakup";
            GUI_checkbox_bakup.Size = new Size(254, 19);
            GUI_checkbox_bakup.TabIndex = 5;
            GUI_checkbox_bakup.Text = "Создать резерв. копию на рабочем столе";
            GUI_checkbox_bakup.UseVisualStyleBackColor = true;
            // 
            // GUI_btn_save
            // 
            GUI_btn_save.Location = new Point(20, 105);
            GUI_btn_save.Name = "GUI_btn_save";
            GUI_btn_save.Size = new Size(165, 30);
            GUI_btn_save.TabIndex = 4;
            GUI_btn_save.Text = "Сохранить";
            GUI_btn_save.UseVisualStyleBackColor = true;
            GUI_btn_save.Click += GUI_btn_save_Click;
            // 
            // GUI_label_1
            // 
            GUI_label_1.AutoSize = true;
            GUI_label_1.ForeColor = Color.Gray;
            GUI_label_1.Location = new Point(201, 33);
            GUI_label_1.Name = "GUI_label_1";
            GUI_label_1.Size = new Size(75, 15);
            GUI_label_1.TabIndex = 3;
            GUI_label_1.Text = "Угол обзора";
            // 
            // GUI_label_0
            // 
            GUI_label_0.AutoSize = true;
            GUI_label_0.ForeColor = Color.Gray;
            GUI_label_0.Location = new Point(20, 33);
            GUI_label_0.Name = "GUI_label_0";
            GUI_label_0.Size = new Size(116, 15);
            GUI_label_0.TabIndex = 3;
            GUI_label_0.Text = "Разрешение экрана";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(413, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 70);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 238);
            Controls.Add(GUI_groupbox);
            Controls.Add(GUI_btn_filechoose);
            Controls.Add(GUI_profile_label);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arma 3 Настройка fov 2025";
            Shown += Form1_Shown;
            GUI_groupbox.ResumeLayout(false);
            GUI_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GUI_profile_label;
        private Button GUI_btn_filechoose;
        private GroupBox GUI_groupbox;
        private OpenFileDialog openFileDialog;
        private Button GUI_btn_save;
        private CheckBox GUI_checkbox_bakup;
        private ComboBox GUI_combo_fov;
        private Label GUI_label_0;
        private ComboBox GUI_combo_screen;
        private Label GUI_label_1;
        private PictureBox pictureBox1;
        private LinkLabel GUI_label_link;
        private LinkLabel GUI_label_link_1;
    }
}
