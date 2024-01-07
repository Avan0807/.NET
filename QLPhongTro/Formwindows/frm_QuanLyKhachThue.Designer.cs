namespace QLPhongTro
{
    partial class QuanLyKhachThue
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
            panel2 = new Panel();
            dgvQLPT = new GroupBox();
            dgvQLKT = new DataGridView();
            btnHuy = new Button();
            btnLuu = new Button();
            groupBox4 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox5 = new GroupBox();
            NgaySinh = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            txtCMND = new TextBox();
            txtQQ = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            txtHT = new TextBox();
            txtMP = new TextBox();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            dgvQLPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLKT).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(dgvQLPT);
            panel2.Controls.Add(btnHuy);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox5);
            panel2.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel2.Location = new Point(14, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 877);
            panel2.TabIndex = 12;
            // 
            // dgvQLPT
            // 
            dgvQLPT.Controls.Add(dgvQLKT);
            dgvQLPT.Font = new Font("Tahoma", 12F);
            dgvQLPT.ForeColor = Color.Blue;
            dgvQLPT.Location = new Point(0, 0);
            dgvQLPT.Margin = new Padding(3, 4, 3, 4);
            dgvQLPT.Name = "dgvQLPT";
            dgvQLPT.Padding = new Padding(3, 4, 3, 4);
            dgvQLPT.Size = new Size(575, 854);
            dgvQLPT.TabIndex = 10;
            dgvQLPT.TabStop = false;
            dgvQLPT.Text = "Danh sách khách thuê";
            // 
            // dgvQLKT
            // 
            dgvQLKT.BackgroundColor = SystemColors.ButtonFace;
            dgvQLKT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLKT.Dock = DockStyle.Fill;
            dgvQLKT.GridColor = SystemColors.ControlDark;
            dgvQLKT.Location = new Point(3, 29);
            dgvQLKT.Margin = new Padding(3, 4, 3, 4);
            dgvQLKT.MultiSelect = false;
            dgvQLKT.Name = "dgvQLKT";
            dgvQLKT.RowHeadersWidth = 51;
            dgvQLKT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLKT.Size = new Size(569, 821);
            dgvQLKT.TabIndex = 0;
            dgvQLKT.CellClick += dgvQLKT_CellClick;
            dgvQLKT.CellDoubleClick += dgvQLKT_CellDoubleClick;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Tahoma", 12F);
            btnHuy.Location = new Point(811, 769);
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
            btnLuu.Location = new Point(617, 769);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(144, 81);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Font = new Font("Tahoma", 12F);
            groupBox4.ForeColor = Color.Blue;
            groupBox4.Location = new Point(585, 560);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(525, 191);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng:";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(345, 35);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 47);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(205, 35);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(89, 47);
            btnSua.TabIndex = 1;
            btnSua.Text = "Reset";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(64, 35);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 47);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(NgaySinh);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Controls.Add(txtCMND);
            groupBox5.Controls.Add(txtQQ);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(txtHT);
            groupBox5.Controls.Add(txtMP);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label9);
            groupBox5.Font = new Font("Tahoma", 12F);
            groupBox5.ForeColor = Color.Blue;
            groupBox5.Location = new Point(582, 4);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(525, 511);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin khách thuê";
            // 
            // NgaySinh
            // 
            NgaySinh.Font = new Font("Tahoma", 9.75F);
            NgaySinh.Format = DateTimePickerFormat.Short;
            NgaySinh.Location = new Point(173, 414);
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Size = new Size(200, 27);
            NgaySinh.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 417);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 16;
            label3.Text = "Ngày sinh";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nu" });
            comboBox1.Location = new Point(173, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 32);
            comboBox1.TabIndex = 15;
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(173, 348);
            txtCMND.Margin = new Padding(3, 4, 3, 4);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(287, 32);
            txtCMND.TabIndex = 14;
            // 
            // txtQQ
            // 
            txtQQ.Location = new Point(171, 281);
            txtQQ.Margin = new Padding(3, 4, 3, 4);
            txtQQ.Name = "txtQQ";
            txtQQ.Size = new Size(287, 32);
            txtQQ.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(21, 352);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 11;
            label2.Text = "CMND";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 285);
            label1.Name = "label1";
            label1.Size = new Size(103, 24);
            label1.TabIndex = 10;
            label1.Text = "Quê quán:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(21, 224);
            label7.Name = "label7";
            label7.Size = new Size(84, 24);
            label7.TabIndex = 6;
            label7.Text = "Giới tính";
            // 
            // txtHT
            // 
            txtHT.Location = new Point(173, 159);
            txtHT.Margin = new Padding(3, 4, 3, 4);
            txtHT.Name = "txtHT";
            txtHT.Size = new Size(287, 32);
            txtHT.TabIndex = 5;
            // 
            // txtMP
            // 
            txtMP.Location = new Point(173, 97);
            txtMP.Margin = new Padding(3, 4, 3, 4);
            txtMP.Name = "txtMP";
            txtMP.Size = new Size(287, 32);
            txtMP.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(21, 163);
            label8.Name = "label8";
            label8.Size = new Size(77, 24);
            label8.TabIndex = 2;
            label8.Text = "Họ tên:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(21, 101);
            label9.Name = "label9";
            label9.Size = new Size(65, 24);
            label9.TabIndex = 1;
            label9.Text = "Phòng";
            // 
            // button1
            // 
            button1.Location = new Point(345, 107);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 3;
            button1.Text = "Tìm phòng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 122);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 32);
            textBox1.TabIndex = 18;
            // 
            // QuanLyKhachThue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 964);
            Controls.Add(panel2);
            Margin = new Padding(5, 4, 5, 4);
            Name = "QuanLyKhachThue";
            Text = "frm_QuanLyKhachThue";
            Load += QuanLyKhachThue_Load;
            panel2.ResumeLayout(false);
            dgvQLPT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLKT).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnHuy;
        private Button btnLuu;
        private GroupBox groupBox4;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox5;
        private Label label7;
        private TextBox txtHT;
        private TextBox txtMP;
        private Label label8;
        private Label label9;
        private GroupBox dgvQLPT;
        private DataGridView dgvQLKT;
        private TextBox txtCMND;
        private TextBox txtQQ;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private DateTimePicker NgaySinh;
        private TextBox textBox1;
        private Button button1;
    }
}