namespace QuanLySieuThi_Entity.GUI
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTinhTrang = new System.Windows.Forms.GroupBox();
            this.rbConHang = new System.Windows.Forms.RadioButton();
            this.rbHetHang = new System.Windows.Forms.RadioButton();
            this.cbbNhaSX = new System.Windows.Forms.ComboBox();
            this.cbbMatHang = new System.Windows.Forms.ComboBox();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.tbMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxTinhTrang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxTinhTrang);
            this.groupBox1.Controls.Add(this.cbbNhaSX);
            this.groupBox1.Controls.Add(this.cbbMatHang);
            this.groupBox1.Controls.Add(this.tbTenSP);
            this.groupBox1.Controls.Add(this.tbMaSP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // groupBoxTinhTrang
            // 
            this.groupBoxTinhTrang.Controls.Add(this.rbConHang);
            this.groupBoxTinhTrang.Controls.Add(this.rbHetHang);
            this.groupBoxTinhTrang.Location = new System.Drawing.Point(377, 99);
            this.groupBoxTinhTrang.Name = "groupBoxTinhTrang";
            this.groupBoxTinhTrang.Size = new System.Drawing.Size(312, 65);
            this.groupBoxTinhTrang.TabIndex = 13;
            this.groupBoxTinhTrang.TabStop = false;
            this.groupBoxTinhTrang.Text = "Tình trạng";
            // 
            // rbConHang
            // 
            this.rbConHang.AutoSize = true;
            this.rbConHang.Location = new System.Drawing.Point(37, 30);
            this.rbConHang.Name = "rbConHang";
            this.rbConHang.Size = new System.Drawing.Size(85, 20);
            this.rbConHang.TabIndex = 11;
            this.rbConHang.TabStop = true;
            this.rbConHang.Text = "Còn hàng";
            this.rbConHang.UseVisualStyleBackColor = true;
            // 
            // rbHetHang
            // 
            this.rbHetHang.AutoSize = true;
            this.rbHetHang.Location = new System.Drawing.Point(192, 30);
            this.rbHetHang.Name = "rbHetHang";
            this.rbHetHang.Size = new System.Drawing.Size(82, 20);
            this.rbHetHang.TabIndex = 12;
            this.rbHetHang.TabStop = true;
            this.rbHetHang.Text = "Hết hàng";
            this.rbHetHang.UseVisualStyleBackColor = true;
            // 
            // cbbNhaSX
            // 
            this.cbbNhaSX.FormattingEnabled = true;
            this.cbbNhaSX.Location = new System.Drawing.Point(472, 62);
            this.cbbNhaSX.Name = "cbbNhaSX";
            this.cbbNhaSX.Size = new System.Drawing.Size(197, 24);
            this.cbbNhaSX.TabIndex = 10;
            // 
            // cbbMatHang
            // 
            this.cbbMatHang.FormattingEnabled = true;
            this.cbbMatHang.Location = new System.Drawing.Point(472, 32);
            this.cbbMatHang.Name = "cbbMatHang";
            this.cbbMatHang.Size = new System.Drawing.Size(197, 24);
            this.cbbMatHang.TabIndex = 9;
            this.cbbMatHang.SelectedIndexChanged += new System.EventHandler(this.cbbMatHang_SelectedIndexChanged);
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(136, 60);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(200, 22);
            this.tbTenSP.TabIndex = 8;
            // 
            // tbMaSP
            // 
            this.tbMaSP.Location = new System.Drawing.Point(136, 32);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.Size = new System.Drawing.Size(200, 22);
            this.tbMaSP.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhà sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mặt hàng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(254, 244);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 28);
            this.butOK.TabIndex = 1;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(456, 244);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 28);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "AddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTinhTrang.ResumeLayout(false);
            this.groupBoxTinhTrang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbConHang;
        private System.Windows.Forms.ComboBox cbbNhaSX;
        private System.Windows.Forms.ComboBox cbbMatHang;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.TextBox tbMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbHetHang;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.GroupBox groupBoxTinhTrang;
    }
}