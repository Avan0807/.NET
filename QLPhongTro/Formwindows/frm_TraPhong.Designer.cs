namespace QLPhongTro
{
    partial class TraPhong
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
            lvPhong = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox1 = new GroupBox();
            lvKhach = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            groupBox3 = new GroupBox();
            txtCMND = new TextBox();
            cbGioiTinh = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            txtTienDatCoc = new TextBox();
            txtQueQuan = new TextBox();
            txtHo = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox5 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTienCoc = new TextBox();
            txtMaPhong = new TextBox();
            dtpNgayThue = new DateTimePicker();
            dtpNgayTra = new DateTimePicker();
            label11 = new Label();
            btnXacNhan = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SkyBlue;
            groupBox2.Controls.Add(lvPhong);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.ForeColor = Color.ForestGreen;
            groupBox2.Location = new Point(20, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(425, 246);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng";
            // 
            // lvPhong
            // 
            lvPhong.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader1, columnHeader2 });
            lvPhong.GridLines = true;
            lvPhong.Location = new Point(14, 43);
            lvPhong.Name = "lvPhong";
            lvPhong.Size = new Size(390, 192);
            lvPhong.TabIndex = 68;
            lvPhong.UseCompatibleStateImageBehavior = false;
            lvPhong.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mã phòng";
            columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Phòng";
            columnHeader4.Width = 95;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã Loại Phòng";
            columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tiền";
            columnHeader2.Width = 106;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SkyBlue;
            groupBox1.Controls.Add(lvKhach);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.ForeColor = Color.ForestGreen;
            groupBox1.Location = new Point(22, 338);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 203);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khách";
            // 
            // lvKhach
            // 
            lvKhach.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lvKhach.GridLines = true;
            lvKhach.Location = new Point(11, 26);
            lvKhach.Name = "lvKhach";
            lvKhach.Size = new Size(400, 160);
            lvKhach.TabIndex = 68;
            lvKhach.UseCompatibleStateImageBehavior = false;
            lvKhach.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mã khách";
            columnHeader5.Width = 126;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Họ và tên";
            columnHeader6.Width = 189;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Quê Quán";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Dãy";
            columnHeader8.Width = 106;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.SkyBlue;
            groupBox3.Controls.Add(txtCMND);
            groupBox3.Controls.Add(cbGioiTinh);
            groupBox3.Controls.Add(dtpNgaySinh);
            groupBox3.Controls.Add(txtTienDatCoc);
            groupBox3.Controls.Add(txtQueQuan);
            groupBox3.Controls.Add(txtHo);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox3.ForeColor = Color.ForestGreen;
            groupBox3.Location = new Point(478, 79);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(542, 254);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách";
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Tahoma", 9.75F);
            txtCMND.Location = new Point(122, 124);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(253, 23);
            txtCMND.TabIndex = 9;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.ForeColor = Color.Black;
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.ItemHeight = 20;
            cbGioiTinh.Location = new Point(120, 98);
            cbGioiTinh.Margin = new Padding(2);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(127, 28);
            cbGioiTinh.TabIndex = 79;
            cbGioiTinh.TabStop = false;
            cbGioiTinh.Visible = false;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Tahoma", 9.75F);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(122, 71);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(127, 23);
            dtpNgaySinh.TabIndex = 13;
            // 
            // txtTienDatCoc
            // 
            txtTienDatCoc.Font = new Font("Tahoma", 9.75F);
            txtTienDatCoc.Location = new Point(122, 217);
            txtTienDatCoc.Name = "txtTienDatCoc";
            txtTienDatCoc.Size = new Size(253, 23);
            txtTienDatCoc.TabIndex = 12;
            // 
            // txtQueQuan
            // 
            txtQueQuan.Font = new Font("Tahoma", 9.75F);
            txtQueQuan.Location = new Point(122, 155);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(253, 23);
            txtQueQuan.TabIndex = 10;
            // 
            // txtHo
            // 
            txtHo.Font = new Font("Tahoma", 9.75F);
            txtHo.Location = new Point(122, 42);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(149, 23);
            txtHo.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(15, 217);
            label10.Name = "label10";
            label10.Size = new Size(90, 16);
            label10.TabIndex = 6;
            label10.Text = "Tiền đặt cọc:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(17, 129);
            label8.Name = "label8";
            label8.Size = new Size(48, 16);
            label8.TabIndex = 4;
            label8.Text = "CMND:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 158);
            label7.Name = "label7";
            label7.Size = new Size(73, 16);
            label7.TabIndex = 3;
            label7.Text = "Quê quán:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(16, 100);
            label6.Name = "label6";
            label6.Size = new Size(63, 16);
            label6.TabIndex = 2;
            label6.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(15, 71);
            label5.Name = "label5";
            label5.Size = new Size(74, 16);
            label5.TabIndex = 1;
            label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 47);
            label4.Name = "label4";
            label4.Size = new Size(75, 16);
            label4.TabIndex = 0;
            label4.Text = "Họ và tên:";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.SkyBlue;
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(txtTienCoc);
            groupBox5.Controls.Add(txtMaPhong);
            groupBox5.Controls.Add(dtpNgayThue);
            groupBox5.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox5.ForeColor = Color.ForestGreen;
            groupBox5.Location = new Point(478, 350);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(542, 121);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ngày thuê";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(10, 89);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 82;
            label3.Text = "Tiền đặt cọc:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(10, 55);
            label2.Name = "label2";
            label2.Size = new Size(82, 16);
            label2.TabIndex = 81;
            label2.Text = "Ngày thuê: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 29);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 80;
            label1.Text = "Phòng:";
            // 
            // txtTienCoc
            // 
            txtTienCoc.Font = new Font("Tahoma", 9.75F);
            txtTienCoc.Location = new Point(118, 86);
            txtTienCoc.Name = "txtTienCoc";
            txtTienCoc.Size = new Size(154, 23);
            txtTienCoc.TabIndex = 16;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Font = new Font("Tahoma", 9.75F);
            txtMaPhong.Location = new Point(117, 25);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(154, 23);
            txtMaPhong.TabIndex = 15;
            // 
            // dtpNgayThue
            // 
            dtpNgayThue.Font = new Font("Tahoma", 9.75F);
            dtpNgayThue.Format = DateTimePickerFormat.Short;
            dtpNgayThue.Location = new Point(118, 55);
            dtpNgayThue.Name = "dtpNgayThue";
            dtpNgayThue.Size = new Size(154, 23);
            dtpNgayThue.TabIndex = 14;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.Font = new Font("Tahoma", 9.75F);
            dtpNgayTra.Format = DateTimePickerFormat.Short;
            dtpNgayTra.Location = new Point(638, 502);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(108, 23);
            dtpNgayTra.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(517, 506);
            label11.Name = "label11";
            label11.Size = new Size(116, 16);
            label11.TabIndex = 83;
            label11.Text = "Ngày trả phòng :";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.PaleVioletRed;
            btnXacNhan.Font = new Font("Microsoft Sans Serif", 12F);
            btnXacNhan.Location = new Point(838, 502);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(104, 54);
            btnXacNhan.TabIndex = 84;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // TraPhong
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1050, 557);
            Controls.Add(btnXacNhan);
            Controls.Add(label11);
            Controls.Add(dtpNgayTra);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Microsoft Sans Serif", 8.25F);
<<<<<<< HEAD
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "TraPhong";
            Text = "frm_TraPhong";
=======
            FormBorderStyle = FormBorderStyle.None;
            Name = "TraPhong";
            Text = "for_TraPhong";
>>>>>>> origin/master
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ListView lvPhong;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox1;
        private ListView lvKhach;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private GroupBox groupBox3;
        private TextBox txtCMND;
        private ComboBox cbGioiTinh;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtTienDatCoc;
        private TextBox txtQueQuan;
        private TextBox txtHo;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTienCoc;
        private TextBox txtMaPhong;
        private DateTimePicker dtpNgayThue;
        private DateTimePicker dtpNgayTra;
        private Label label11;
        private Button btnXacNhan;
    }
}