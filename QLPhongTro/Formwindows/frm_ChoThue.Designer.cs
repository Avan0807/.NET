namespace QLPhongTro
{
    partial class ChoThue
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
            groupBox2 = new GroupBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            cbChonPhong = new ComboBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            cbGioiTinh = new ComboBox();
            txtCMND = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            txtQueQuan = new TextBox();
            txtHo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label9 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox5 = new GroupBox();
            dtpNgayThue = new DateTimePicker();
            btnLuu = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SkyBlue;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(cbChonPhong);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.ForeColor = Color.ForestGreen;
            groupBox2.Location = new Point(12, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(474, 382);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng";
            // 
            // button1
            // 
            button1.Location = new Point(328, 69);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Lọc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 104);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(462, 261);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cbChonPhong
            // 
            cbChonPhong.DropDownWidth = 122;
            cbChonPhong.FormattingEnabled = true;
            cbChonPhong.Items.AddRange(new object[] { "fe" });
            cbChonPhong.Location = new Point(188, 67);
            cbChonPhong.Name = "cbChonPhong";
            cbChonPhong.Size = new Size(121, 33);
            cbChonPhong.TabIndex = 3;
            cbChonPhong.SelectedIndexChanged += cbChonPhong_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 72);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 2;
            label3.Text = "Chọn loại phòng ";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.SkyBlue;
            groupBox3.Controls.Add(cbGioiTinh);
            groupBox3.Controls.Add(txtCMND);
            groupBox3.Controls.Add(dtpNgaySinh);
            groupBox3.Controls.Add(txtQueQuan);
            groupBox3.Controls.Add(txtHo);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox3.ForeColor = Color.ForestGreen;
            groupBox3.Location = new Point(502, 44);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(458, 264);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách đăng kí ";
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nu" });
            cbGioiTinh.Location = new Point(120, 104);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(151, 33);
            cbGioiTinh.TabIndex = 14;
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Tahoma", 9.75F);
            txtCMND.Location = new Point(120, 143);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(253, 27);
            txtCMND.TabIndex = 9;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Tahoma", 9.75F);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(120, 72);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(127, 27);
            dtpNgaySinh.TabIndex = 13;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Font = new Font("Tahoma", 9.75F);
            txtQueQuan.Location = new Point(122, 179);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(253, 27);
            txtQueQuan.TabIndex = 10;
            // 
            // txtHo
            // 
            txtHo.Font = new Font("Tahoma", 9.75F);
            txtHo.Location = new Point(122, 42);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(251, 27);
            txtHo.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(15, 149);
            label8.Name = "label8";
            label8.Size = new Size(68, 21);
            label8.TabIndex = 4;
            label8.Text = "CMND:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(6, 185);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 3;
            label7.Text = "Quê quán:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(15, 110);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 2;
            label6.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(15, 76);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 1;
            label5.Text = "Ngày sinh:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 47);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 0;
            label4.Text = "Họ và tên:";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.SkyBlue;
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox4.ForeColor = Color.ForestGreen;
            groupBox4.Location = new Point(502, 314);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(463, 182);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(110, 140);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 12;
            label2.Text = "..........";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 140);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 11;
            label1.Text = "Diện tích";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label19.ForeColor = Color.IndianRed;
            label19.Location = new Point(219, 106);
            label19.Name = "label19";
            label19.Size = new Size(60, 21);
            label19.TabIndex = 10;
            label19.Text = "..........";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(15, 106);
            label18.Name = "label18";
            label18.Size = new Size(198, 21);
            label18.TabIndex = 9;
            label18.Text = "Cơ sở vật chất hiện có";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label17.ForeColor = Color.IndianRed;
            label17.Location = new Point(401, 74);
            label17.Name = "label17";
            label17.Size = new Size(45, 21);
            label17.TabIndex = 8;
            label17.Text = ".......";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(292, 74);
            label9.Name = "label9";
            label9.Size = new Size(83, 21);
            label9.TabIndex = 7;
            label9.Text = "SLNgười";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label16.ForeColor = Color.IndianRed;
            label16.Location = new Point(342, 37);
            label16.Name = "label16";
            label16.Size = new Size(45, 21);
            label16.TabIndex = 6;
            label16.Text = ".......";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label15.ForeColor = Color.IndianRed;
            label15.Location = new Point(94, 37);
            label15.Name = "label15";
            label15.Size = new Size(55, 21);
            label15.TabIndex = 5;
            label15.Text = ".........";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label14.ForeColor = Color.IndianRed;
            label14.Location = new Point(160, 74);
            label14.Name = "label14";
            label14.Size = new Size(60, 21);
            label14.TabIndex = 4;
            label14.Text = "..........";
            label14.Click += label14_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(292, 37);
            label13.Name = "label13";
            label13.Size = new Size(44, 21);
            label13.TabIndex = 3;
            label13.Text = "Giá:";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(17, 37);
            label12.Name = "label12";
            label12.Size = new Size(71, 21);
            label12.TabIndex = 2;
            label12.Text = "Phòng:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(17, 74);
            label11.Name = "label11";
            label11.Size = new Size(137, 21);
            label11.TabIndex = 1;
            label11.Text = "Tên loại phòng";
            label11.Click += label11_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.SkyBlue;
            groupBox5.Controls.Add(dtpNgayThue);
            groupBox5.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox5.ForeColor = Color.ForestGreen;
            groupBox5.Location = new Point(12, 432);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(213, 67);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ngày thuê";
            // 
            // dtpNgayThue
            // 
            dtpNgayThue.Font = new Font("Tahoma", 9.75F);
            dtpNgayThue.Format = DateTimePickerFormat.Short;
            dtpNgayThue.Location = new Point(9, 37);
            dtpNgayThue.Name = "dtpNgayThue";
            dtpNgayThue.Size = new Size(200, 27);
            dtpNgayThue.TabIndex = 14;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.PaleVioletRed;
            btnLuu.Font = new Font("Microsoft Sans Serif", 12F);
            btnLuu.Location = new Point(706, 530);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 43);
            btnLuu.TabIndex = 69;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.PaleVioletRed;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F);
            btnClear.Location = new Point(831, 530);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 43);
            btnClear.TabIndex = 70;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SkyBlue;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.ForeColor = Color.ForestGreen;
            groupBox1.Location = new Point(245, 432);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 67);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngày trả phòng";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Tahoma", 9.75F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(9, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // ChoThue
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1004, 585);
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(btnLuu);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            HelpButton = true;
            Name = "ChoThue";
            Text = "ChoThue";
            Load += ChoThue_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private ComboBox cbChonPhong;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox txtQueQuan;
        private TextBox txtCMND;
        private TextBox txtHo;
        private Label label16;
        private Label label15;
        private Label label13;
        private Label label12;
        private DateTimePicker dtpNgayThue;
        private Button btnLuu;
        private Button btnClear;
        private DateTimePicker dtpNgaySinh;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label14;
        private Label label11;
        private Label label9;
        private Label label17;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label19;
        private Label label18;
        private Button button1;
        private Label label2;
        private Label label1;
        private ComboBox cbGioiTinh;
    }
}