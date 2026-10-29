using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OyutniiBurtgel
{
    partial class Form1
    {
        private IContainer components = null;

        private Label lblTitle;
        private Label lblCode;
        private Label lblAge;
        private Label lblBirth;
        private Label lblPhone;
        private Label lblCountry;
        private Label lblMajor;
        private Label lblSubject;
        private Label lblStudy;

        private TextBox txtCode;
        private TextBox txtPhone;
        private NumericUpDown numAge;
        private DateTimePicker dtpBirth;
        private ListBox lstCountry;
        private ComboBox cmbMajor;
        private CheckedListBox clbSubject;

        private RadioButton rbTulburtei;
        private RadioButton rbUdur;
        private RadioButton rbOroi;

        private PictureBox pictureStudent;
        private DataGridView dgvStudent;
        private TreeView treeSubject;
        private RichTextBox rtbInfo;

        private Button btnRegister;
        private Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            TreeNode treeNode7 = new TreeNode("Програмчлал");
            TreeNode treeNode8 = new TreeNode("Өгөгдлийн бүтэц");
            TreeNode treeNode9 = new TreeNode("Алгоритм");
            TreeNode treeNode10 = new TreeNode("Өгөгдлийн сан");
            TreeNode treeNode11 = new TreeNode("Сүлжээ");
            TreeNode treeNode12 = new TreeNode("Хичээлүүд", new TreeNode[] { treeNode7, treeNode8, treeNode9, treeNode10, treeNode11 });
            lblTitle = new Label();
            lblCode = new Label();
            lblAge = new Label();
            lblBirth = new Label();
            lblPhone = new Label();
            lblCountry = new Label();
            lblMajor = new Label();
            lblSubject = new Label();
            lblStudy = new Label();
            txtCode = new TextBox();
            txtPhone = new TextBox();
            numAge = new NumericUpDown();
            dtpBirth = new DateTimePicker();
            lstCountry = new ListBox();
            cmbMajor = new ComboBox();
            clbSubject = new CheckedListBox();
            rbTulburtei = new RadioButton();
            rbUdur = new RadioButton();
            rbOroi = new RadioButton();
            pictureStudent = new PictureBox();
            dgvStudent = new DataGridView();
            treeSubject = new TreeView();
            rtbInfo = new RichTextBox();
            btnRegister = new Button();
            btnClear = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)numAge).BeginInit();
            ((ISupportInitialize)pictureStudent).BeginInit();
            ((ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ОЮУТНЫ БҮРТГЭЛ";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(30, 100);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(96, 20);
            lblCode.TabIndex = 1;
            lblCode.Text = "Оюутны код:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(30, 200);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(38, 20);
            lblAge.TabIndex = 5;
            lblAge.Text = "Нас:";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Location = new Point(30, 250);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(102, 20);
            lblBirth.TabIndex = 7;
            lblBirth.Text = "Төрсөн өдөр:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(30, 150);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(42, 20);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Утас:";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(30, 300);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(36, 20);
            lblCountry.TabIndex = 9;
            lblCountry.Text = "Улс:";
            // 
            // lblMajor
            // 
            lblMajor.AutoSize = true;
            lblMajor.Location = new Point(30, 388);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(82, 20);
            lblMajor.TabIndex = 11;
            lblMajor.Text = "Мэргэжил:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(30, 444);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(60, 20);
            lblSubject.TabIndex = 13;
            lblSubject.Text = "Хичээл:";
            // 
            // lblStudy
            // 
            lblStudy.AutoSize = true;
            lblStudy.Location = new Point(30, 588);
            lblStudy.Name = "lblStudy";
            lblStudy.Size = new Size(65, 20);
            lblStudy.TabIndex = 15;
            lblStudy.Text = "Сургалт:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(150, 95);
            txtCode.Margin = new Padding(3, 4, 3, 4);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(220, 27);
            txtCode.TabIndex = 2;
            txtCode.Text = "m.sw24d060";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 145);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(220, 27);
            txtPhone.TabIndex = 4;
            txtPhone.Text = "99927944";
            // 
            // numAge
            // 
            numAge.Location = new Point(150, 195);
            numAge.Margin = new Padding(3, 4, 3, 4);
            numAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(100, 27);
            numAge.TabIndex = 6;
            numAge.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(150, 245);
            dtpBirth.Margin = new Padding(3, 4, 3, 4);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(220, 27);
            dtpBirth.TabIndex = 8;
            dtpBirth.Value = new DateTime(2005, 11, 6, 0, 0, 0, 0);
            // 
            // lstCountry
            // 
            lstCountry.Items.AddRange(new object[] { "Монгол", "ОХУ", "БНХАУ", "БНСУ", "Япон" });
            lstCountry.Location = new Point(150, 295);
            lstCountry.Margin = new Padding(3, 4, 3, 4);
            lstCountry.Name = "lstCountry";
            lstCountry.Size = new Size(220, 44);
            lstCountry.TabIndex = 10;
            // 
            // cmbMajor
            // 
            cmbMajor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMajor.Items.AddRange(new object[] { "Програм хангамж", "Мэдээллийн систем", "Компьютерийн ухаан", "Сүлжээ", "Кибер аюулгүй байдал" });
            cmbMajor.Location = new Point(150, 382);
            cmbMajor.Margin = new Padding(3, 4, 3, 4);
            cmbMajor.Name = "cmbMajor";
            cmbMajor.Size = new Size(220, 28);
            cmbMajor.TabIndex = 12;
            // 
            // clbSubject
            // 
            clbSubject.Items.AddRange(new object[] { "Програмчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ" });
            clbSubject.Location = new Point(150, 438);
            clbSubject.Margin = new Padding(3, 4, 3, 4);
            clbSubject.Name = "clbSubject";
            clbSubject.Size = new Size(220, 114);
            clbSubject.TabIndex = 14;
            // 
            // rbTulburtei
            // 
            rbTulburtei.AutoSize = true;
            rbTulburtei.Location = new Point(150, 585);
            rbTulburtei.Margin = new Padding(3, 4, 3, 4);
            rbTulburtei.Name = "rbTulburtei";
            rbTulburtei.Size = new Size(104, 24);
            rbTulburtei.TabIndex = 16;
            rbTulburtei.Text = "Төлбөртэй";
            // 
            // rbUdur
            // 
            rbUdur.AutoSize = true;
            rbUdur.Checked = true;
            rbUdur.Location = new Point(250, 585);
            rbUdur.Margin = new Padding(3, 4, 3, 4);
            rbUdur.Name = "rbUdur";
            rbUdur.Size = new Size(85, 24);
            rbUdur.TabIndex = 17;
            rbUdur.TabStop = true;
            rbUdur.Text = "Өдрийн";
            // 
            // rbOroi
            // 
            rbOroi.AutoSize = true;
            rbOroi.Location = new Point(330, 585);
            rbOroi.Margin = new Padding(3, 4, 3, 4);
            rbOroi.Name = "rbOroi";
            rbOroi.Size = new Size(77, 24);
            rbOroi.TabIndex = 18;
            rbOroi.Text = "Оройн";
            // 
            // pictureStudent
            // 
            pictureStudent.BackColor = Color.White;
            pictureStudent.BorderStyle = BorderStyle.FixedSingle;
            pictureStudent.Image = (Image)resources.GetObject("pictureStudent.Image");
            pictureStudent.Location = new Point(450, 88);
            pictureStudent.Margin = new Padding(3, 4, 3, 4);
            pictureStudent.Name = "pictureStudent";
            pictureStudent.Size = new Size(220, 312);
            pictureStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureStudent.TabIndex = 19;
            pictureStudent.TabStop = false;
            pictureStudent.Click += pictureStudent_Click_1;
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.ColumnHeadersHeight = 29;
            dgvStudent.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvStudent.Location = new Point(450, 438);
            dgvStudent.Margin = new Padding(3, 4, 3, 4);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(770, 225);
            dgvStudent.TabIndex = 22;
            // 
            // treeSubject
            // 
            treeSubject.Location = new Point(700, 88);
            treeSubject.Margin = new Padding(3, 4, 3, 4);
            treeSubject.Name = "treeSubject";
            treeNode7.Name = "";
            treeNode7.Text = "Програмчлал";
            treeNode8.Name = "";
            treeNode8.Text = "Өгөгдлийн бүтэц";
            treeNode9.Name = "";
            treeNode9.Text = "Алгоритм";
            treeNode10.Name = "";
            treeNode10.Text = "Өгөгдлийн сан";
            treeNode11.Name = "";
            treeNode11.Text = "Сүлжээ";
            treeNode12.Name = "";
            treeNode12.Text = "Хичээлүүд";
            treeSubject.Nodes.AddRange(new TreeNode[] { treeNode12 });
            treeSubject.Size = new Size(220, 224);
            treeSubject.TabIndex = 20;
            // 
            // rtbInfo
            // 
            rtbInfo.Location = new Point(950, 88);
            rtbInfo.Margin = new Padding(3, 4, 3, 4);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(270, 312);
            rtbInfo.TabIndex = 21;
            rtbInfo.Text = "ОЮУТНЫ БҮРТГЭЛ\n----------------------\nКод: m.sw24d060\nУтас: 99927944\nНас: 20\nТөрсөн өдөр: 2005-11-06\nСургалт: Өдрийн\nТэнхим: Програм хангамж\nУлс: Монгол";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(150, 625);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 50);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "Бүртгүүлэх";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(270, 625);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 50);
            btnClear.TabIndex = 24;
            btnClear.Text = "Цэвэрлэх";
            btnClear.Click += btnClear_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Код";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Утас";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Нас";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Улс";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 938);
            Controls.Add(lblTitle);
            Controls.Add(lblCode);
            Controls.Add(txtCode);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblAge);
            Controls.Add(numAge);
            Controls.Add(lblBirth);
            Controls.Add(dtpBirth);
            Controls.Add(lblCountry);
            Controls.Add(lstCountry);
            Controls.Add(lblMajor);
            Controls.Add(cmbMajor);
            Controls.Add(lblSubject);
            Controls.Add(clbSubject);
            Controls.Add(lblStudy);
            Controls.Add(rbTulburtei);
            Controls.Add(rbUdur);
            Controls.Add(rbOroi);
            Controls.Add(pictureStudent);
            Controls.Add(treeSubject);
            Controls.Add(rtbInfo);
            Controls.Add(dgvStudent);
            Controls.Add(btnRegister);
            Controls.Add(btnClear);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оюутны бүртгэл";
            ((ISupportInitialize)numAge).EndInit();
            ((ISupportInitialize)pictureStudent).EndInit();
            ((ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}