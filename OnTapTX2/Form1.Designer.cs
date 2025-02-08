namespace OnTapTX2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTinh = new System.Windows.Forms.TextBox();
            this.tbHuyen = new System.Windows.Forms.TextBox();
            this.tbXa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTuoi = new System.Windows.Forms.TextBox();
            this.tbLuong = new System.Windows.Forms.TextBox();
            this.tbDienThoai = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getNhanVienChoosen);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ CÔNG TY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Điện thoại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTinh);
            this.groupBox1.Controls.Add(this.tbHuyen);
            this.groupBox1.Controls.Add(this.tbXa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(401, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Địa chỉ";
            // 
            // tbTinh
            // 
            this.tbTinh.Location = new System.Drawing.Point(72, 103);
            this.tbTinh.Name = "tbTinh";
            this.tbTinh.Size = new System.Drawing.Size(120, 20);
            this.tbTinh.TabIndex = 4;
            // 
            // tbHuyen
            // 
            this.tbHuyen.Location = new System.Drawing.Point(72, 66);
            this.tbHuyen.Name = "tbHuyen";
            this.tbHuyen.Size = new System.Drawing.Size(120, 20);
            this.tbHuyen.TabIndex = 4;
            // 
            // tbXa
            // 
            this.tbXa.Location = new System.Drawing.Point(72, 22);
            this.tbXa.Name = "tbXa";
            this.tbXa.Size = new System.Drawing.Size(120, 20);
            this.tbXa.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tỉnh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Huyện";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(257, 85);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(138, 20);
            this.tbTen.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên";
            // 
            // tbTuoi
            // 
            this.tbTuoi.Location = new System.Drawing.Point(257, 125);
            this.tbTuoi.Name = "tbTuoi";
            this.tbTuoi.Size = new System.Drawing.Size(138, 20);
            this.tbTuoi.TabIndex = 4;
            // 
            // tbLuong
            // 
            this.tbLuong.Location = new System.Drawing.Point(257, 168);
            this.tbLuong.Name = "tbLuong";
            this.tbLuong.Size = new System.Drawing.Size(138, 20);
            this.tbLuong.TabIndex = 4;
            // 
            // tbDienThoai
            // 
            this.tbDienThoai.Location = new System.Drawing.Point(275, 213);
            this.tbDienThoai.Name = "tbDienThoai";
            this.tbDienThoai.Size = new System.Drawing.Size(120, 20);
            this.tbDienThoai.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(605, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(717, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "LoadFile";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã Nhân viên";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(89, 103);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(94, 20);
            this.tbMaNV.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDienThoai);
            this.Controls.Add(this.tbLuong);
            this.Controls.Add(this.tbTuoi);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTinh;
        private System.Windows.Forms.TextBox tbHuyen;
        private System.Windows.Forms.TextBox tbXa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTuoi;
        private System.Windows.Forms.TextBox tbLuong;
        private System.Windows.Forms.TextBox tbDienThoai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMaNV;
    }
}

