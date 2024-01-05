namespace QLPhongTro
{
    partial class QuanLyDichVu
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
            groupBox3 = new GroupBox();
            dgvQLDV = new DataGridView();
            panel1 = new Panel();
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            txtDG = new TextBox();
            txtTDV = new TextBox();
            txtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLDV).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightBlue;
            groupBox3.Controls.Add(dgvQLDV);
            groupBox3.Font = new Font("Tahoma", 12F);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(6, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(503, 477);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách dịch vụ";
            // 
            // dgvQLDV
            // 
            dgvQLDV.BackgroundColor = SystemColors.ButtonFace;
            dgvQLDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLDV.Dock = DockStyle.Fill;
            dgvQLDV.GridColor = SystemColors.ControlDark;
            dgvQLDV.Location = new Point(3, 23);
            dgvQLDV.Name = "dgvQLDV";
            dgvQLDV.Size = new Size(497, 451);
            dgvQLDV.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel1.Location = new Point(6, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 477);
            panel1.TabIndex = 2;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Tahoma", 12F);
            btnHuy.Location = new Point(783, 360);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(126, 61);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Tahoma", 12F);
            btnLuu.Location = new Point(565, 360);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(126, 61);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Font = new Font("Tahoma", 12F);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(509, 243);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(459, 81);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng:";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(302, 26);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 35);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(179, 26);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 35);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(56, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 35);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDG);
            groupBox1.Controls.Add(txtTDV);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 12F);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(509, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dịch vụ";
            // 
            // txtDG
            // 
            txtDG.Location = new Point(148, 135);
            txtDG.Name = "txtDG";
            txtDG.Size = new Size(252, 27);
            txtDG.TabIndex = 5;
            // 
            // txtTDV
            // 
            txtTDV.Location = new Point(148, 89);
            txtTDV.Name = "txtTDV";
            txtTDV.Size = new Size(252, 27);
            txtTDV.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(148, 43);
            txtID.Name = "txtID";
            txtID.Size = new Size(252, 27);
            txtID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(15, 138);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 92);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 1;
            label2.Text = "Tên dịch vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 46);
            label1.Name = "label1";
            label1.Size = new Size(32, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // QuanLyDichVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 672);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Name = "QuanLyDichVu";
            Text = "frm_QuanLyDichVu";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLDV).EndInit();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dgvQLDV;
        private Panel panel1;
        private Button btnHuy;
        private Button btnLuu;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox1;
        private TextBox txtDG;
        private TextBox txtTDV;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtLoaiDichVu;
    }
}