namespace QLSV
{
    partial class frmThemSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbLopHoc = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtTen = new TextBox();
            chkGioiTinh = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            dtNgaySinh = new DateTimePicker();
            btnAdd = new Button();
            btnExit = new Button();
            txtMSSV = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtMSSV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F);
            label1.Location = new Point(39, 48);
            label1.Name = "label1";
            label1.Size = new Size(96, 59);
            label1.TabIndex = 0;
            label1.Text = "Lớp";
            // 
            // cbLopHoc
            // 
            cbLopHoc.Font = new Font("Segoe UI", 16.125F);
            cbLopHoc.FormattingEnabled = true;
            cbLopHoc.Location = new Point(217, 32);
            cbLopHoc.Name = "cbLopHoc";
            cbLopHoc.Size = new Size(429, 67);
            cbLopHoc.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F);
            label2.Location = new Point(700, 40);
            label2.Name = "label2";
            label2.Size = new Size(137, 59);
            label2.TabIndex = 2;
            label2.Text = "MSSV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.125F);
            label3.Location = new Point(42, 141);
            label3.Name = "label3";
            label3.Size = new Size(90, 59);
            label3.TabIndex = 4;
            label3.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 16.125F);
            txtTen.Location = new Point(219, 137);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(427, 65);
            txtTen.TabIndex = 5;
            // 
            // chkGioiTinh
            // 
            chkGioiTinh.AutoSize = true;
            chkGioiTinh.Font = new Font("Segoe UI", 16.125F);
            chkGioiTinh.Location = new Point(883, 160);
            chkGioiTinh.Name = "chkGioiTinh";
            chkGioiTinh.Size = new Size(28, 27);
            chkGioiTinh.TabIndex = 6;
            chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.125F);
            label4.Location = new Point(700, 143);
            label4.Name = "label4";
            label4.Size = new Size(77, 59);
            label4.TabIndex = 7;
            label4.Text = "GT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.125F);
            label5.Location = new Point(50, 234);
            label5.Name = "label5";
            label5.Size = new Size(218, 59);
            label5.TabIndex = 8;
            label5.Text = "Ngày Sinh";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Font = new Font("Segoe UI", 16.125F);
            dtNgaySinh.Location = new Point(282, 228);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(701, 65);
            dtNgaySinh.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 16.125F);
            btnAdd.Location = new Point(282, 350);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(284, 90);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 16.125F);
            btnExit.Location = new Point(653, 350);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(284, 90);
            btnExit.TabIndex = 11;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtMSSV
            // 
            txtMSSV.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMSSV.Location = new Point(883, 38);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(240, 65);
            txtMSSV.TabIndex = 12;
            // 
            // frmThemSV
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 486);
            Controls.Add(txtMSSV);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(dtNgaySinh);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(chkGioiTinh);
            Controls.Add(txtTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbLopHoc);
            Controls.Add(label1);
            Name = "frmThemSV";
            Text = "QLSV-Thêm sinh viên";
            Load += frmThemSV_Load;
            ((System.ComponentModel.ISupportInitialize)txtMSSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbLopHoc;
        private Label label2;
        private Label label3;
        private TextBox txtTen;
        private CheckBox chkGioiTinh;
        private Label label4;
        private Label label5;
        private DateTimePicker dtNgaySinh;
        private Button btnAdd;
        private Button btnExit;
        private NumericUpDown txtMSSV;
    }
}