namespace QLSV
{
    partial class frmMain
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
            groupBox1 = new GroupBox();
            dgvLopHoc = new DataGridView();
            groupBox2 = new GroupBox();
            dgvDanhSach = new DataGridView();
            btnXem = new Button();
            btnThem = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvLopHoc);
            groupBox1.Font = new Font("Segoe UI", 16.125F);
            groupBox1.Location = new Point(26, 72);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(518, 416);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp học";
            // 
            // dgvLopHoc
            // 
            dgvLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLopHoc.Location = new Point(14, 46);
            dgvLopHoc.Margin = new Padding(2);
            dgvLopHoc.Name = "dgvLopHoc";
            dgvLopHoc.RowHeadersWidth = 82;
            dgvLopHoc.Size = new Size(481, 318);
            dgvLopHoc.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDanhSach);
            groupBox2.Font = new Font("Segoe UI", 16.125F);
            groupBox2.Location = new Point(548, 72);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(566, 396);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách lớp";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Location = new Point(26, 40);
            dgvDanhSach.Margin = new Padding(2);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersWidth = 82;
            dgvDanhSach.Size = new Size(520, 321);
            dgvDanhSach.TabIndex = 0;
            // 
            // btnXem
            // 
            btnXem.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXem.Location = new Point(229, 464);
            btnXem.Margin = new Padding(2);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(75, 49);
            btnXem.TabIndex = 2;
            btnXem.Text = ">>";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(349, 464);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 49);
            btnThem.TabIndex = 2;
            btnThem.Text = "+";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(471, 464);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(75, 49);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 524);
            Controls.Add(button1);
            Controls.Add(btnThem);
            Controls.Add(btnXem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmMain";
            Text = "QLSV";
            Load += frmMain_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvDanhSach;
        private Button btnXem;
        private DataGridView dgvLopHoc;
        private Button btnThem;
        private Button button1;
    }
}