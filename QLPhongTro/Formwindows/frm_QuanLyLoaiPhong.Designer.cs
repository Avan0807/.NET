namespace QLPhongTro
{
    partial class QuanLyLoaiPhong
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
            dgvQLLP = new DataGridView();
            panel1 = new Panel();
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            txtGhiChu = new TextBox();
            txtGia = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtDT = new TextBox();
            txtTLP = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnSua = new Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLLP).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightBlue;
            groupBox3.Controls.Add(dgvQLLP);
            groupBox3.Font = new Font("Tahoma", 12F);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(14, 16);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(663, 636);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách Loai Phong";
            // 
            // dgvQLLP
            // 
            dgvQLLP.BackgroundColor = SystemColors.ButtonFace;
            dgvQLLP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLLP.Dock = DockStyle.Fill;
            dgvQLLP.GridColor = SystemColors.ControlDark;
            dgvQLLP.Location = new Point(3, 29);
            dgvQLLP.Margin = new Padding(3, 4, 3, 4);
            dgvQLLP.Name = "dgvQLLP";
            dgvQLLP.RowHeadersWidth = 51;
            dgvQLLP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLLP.Size = new Size(657, 603);
            dgvQLLP.TabIndex = 0;
            dgvQLLP.CellClick += dgvQLLP_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 636);
            panel1.TabIndex = 8;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Tahoma", 12F);
            btnHuy.Location = new Point(895, 512);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(144, 81);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Tahoma", 12F);
            btnLuu.Location = new Point(669, 512);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(144, 81);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Font = new Font("Tahoma", 12F);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(669, 370);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(437, 115);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng:";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(310, 35);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 47);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(21, 35);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 47);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDT);
            groupBox1.Controls.Add(txtTLP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Tahoma", 12F);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(669, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(438, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại phòng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(378, 40);
            label7.Name = "label7";
            label7.Size = new Size(44, 24);
            label7.TabIndex = 13;
            label7.Text = "Sửa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 12;
            label1.Text = "Thêm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 313);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 32);
            textBox1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(21, 316);
            label6.Name = "label6";
            label6.Size = new Size(89, 24);
            label6.TabIndex = 10;
            label6.Text = "Dien tich";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(173, 269);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(287, 32);
            txtGhiChu.TabIndex = 9;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(173, 220);
            txtGia.Margin = new Padding(3, 4, 3, 4);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(287, 32);
            txtGia.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 273);
            label5.Name = "label5";
            label5.Size = new Size(139, 24);
            label5.TabIndex = 7;
            label5.Text = "Co So vat chat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(21, 224);
            label4.Name = "label4";
            label4.Size = new Size(46, 24);
            label4.TabIndex = 6;
            label4.Text = "Giá:";
            // 
            // txtDT
            // 
            txtDT.Location = new Point(173, 159);
            txtDT.Margin = new Padding(3, 4, 3, 4);
            txtDT.Name = "txtDT";
            txtDT.Size = new Size(62, 32);
            txtDT.TabIndex = 5;
            // 
            // txtTLP
            // 
            txtTLP.Location = new Point(173, 97);
            txtTLP.Margin = new Padding(3, 4, 3, 4);
            txtTLP.Name = "txtTLP";
            txtTLP.Size = new Size(287, 32);
            txtTLP.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(21, 163);
            label3.Name = "label3";
            label3.Size = new Size(87, 24);
            label3.TabIndex = 2;
            label3.Text = "So luong";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(21, 101);
            label2.Name = "label2";
            label2.Size = new Size(150, 24);
            label2.TabIndex = 1;
            label2.Text = "Tên loại phòng:";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(21, 129);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(10, 10);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // QuanLyLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 743);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuanLyLoaiPhong";
            Text = "frm_QuanLyLoaiPhong";
            Load += QuanLyLoaiPhong_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLLP).EndInit();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dgvQLLP;
        private Panel panel1;
        private Button btnHuy;
        private Button btnLuu;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox1;
        private TextBox txtDT;
        private TextBox txtTLP;
        private Label label3;
        private Label label2;
        private TextBox txtGhiChu;
        private TextBox txtGia;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private Label label1;
        private Button btnSua;
    }
}