namespace QLPhongTro
{
    partial class SuDungDichVu
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
            lvSuDungDV = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox4 = new GroupBox();
            btnTim = new Button();
            label2 = new Label();
            txtMaDV = new TextBox();
            txtPhong = new TextBox();
            label11 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.SkyBlue;
            groupBox3.Controls.Add(lvSuDungDV);
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox3.ForeColor = Color.ForestGreen;
            groupBox3.Location = new Point(21, 35);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(449, 252);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dịch vụ đang sử dụng";
            // 
            // lvSuDungDV
            // 
            lvSuDungDV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvSuDungDV.FullRowSelect = true;
            lvSuDungDV.GridLines = true;
            lvSuDungDV.Location = new Point(14, 43);
            lvSuDungDV.Name = "lvSuDungDV";
            lvSuDungDV.Size = new Size(424, 192);
            lvSuDungDV.TabIndex = 0;
            lvSuDungDV.UseCompatibleStateImageBehavior = false;
            lvSuDungDV.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn Giá";
            columnHeader3.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Phòng";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dịch Vụ";
            columnHeader2.Width = 151;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.SkyBlue;
            groupBox4.Controls.Add(btnTim);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(txtMaDV);
            groupBox4.Controls.Add(txtPhong);
            groupBox4.Controls.Add(label11);
            groupBox4.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox4.ForeColor = Color.ForestGreen;
            groupBox4.Location = new Point(495, 35);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(391, 144);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Đăng kí dịch vụ";
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.PaleVioletRed;
            btnTim.Font = new Font("Microsoft Sans Serif", 12F);
            btnTim.ForeColor = Color.Black;
            btnTim.Location = new Point(302, 96);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 28);
            btnTim.TabIndex = 71;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 75);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 11;
            label2.Text = "Mã dịch vụ";
            // 
            // txtMaDV
            // 
            txtMaDV.Font = new Font("Tahoma", 9.75F);
            txtMaDV.Location = new Point(122, 69);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(149, 23);
            txtMaDV.TabIndex = 9;
            // 
            // txtPhong
            // 
            txtPhong.Font = new Font("Tahoma", 9.75F);
            txtPhong.Location = new Point(122, 42);
            txtPhong.Name = "txtPhong";
            txtPhong.Size = new Size(149, 23);
            txtPhong.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(15, 47);
            label11.Name = "label11";
            label11.Size = new Size(55, 19);
            label11.TabIndex = 1;
            label11.Text = "Phòng:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.PaleVioletRed;
            btnThem.Font = new Font("Microsoft Sans Serif", 12F);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(493, 199);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 55);
            btnThem.TabIndex = 72;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.PaleVioletRed;
            btnSua.Font = new Font("Microsoft Sans Serif", 12F);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(617, 199);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 55);
            btnSua.TabIndex = 73;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.PaleVioletRed;
            btnXoa.Font = new Font("Microsoft Sans Serif", 12F);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(737, 199);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 55);
            btnXoa.TabIndex = 74;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1050, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(8, 8);
            dataGridView1.TabIndex = 75;
            // 
            // SuDungDichVu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1062, 589);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuDungDichVu";
            Text = "frm_SuDungDichVu";
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private ListView lvSuDungDV;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox4;
        private Label label2;
        private TextBox txtSoLuong;
        private TextBox txtMaDV;
        private TextBox txtPhong;
        private Label label1;
        private Label label11;
        private Button btnTim;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dataGridView1;
    }
}