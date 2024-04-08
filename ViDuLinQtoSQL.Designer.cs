namespace KetNoiADO.NET
{
    partial class ViDuLinQtoSQL
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
            this.dgv_MatHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_IDXoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_DonGia_Sua = new System.Windows.Forms.TextBox();
            this.txt_SoLuong_Sua = new System.Windows.Forms.TextBox();
            this.txt_TenHang_Sua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_IDSua = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MatHang
            // 
            this.dgv_MatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MatHang.Location = new System.Drawing.Point(196, 19);
            this.dgv_MatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_MatHang.Name = "dgv_MatHang";
            this.dgv_MatHang.RowHeadersWidth = 51;
            this.dgv_MatHang.RowTemplate.Height = 24;
            this.dgv_MatHang.Size = new System.Drawing.Size(980, 234);
            this.dgv_MatHang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn giá:";
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Location = new System.Drawing.Point(171, 289);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(265, 30);
            this.txt_TenHang.TabIndex = 4;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(171, 332);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(265, 30);
            this.txt_SoLuong.TabIndex = 5;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(171, 382);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(265, 30);
            this.txt_DonGia.TabIndex = 6;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(171, 438);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 44);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_IDXoa
            // 
            this.txt_IDXoa.Location = new System.Drawing.Point(686, 289);
            this.txt_IDXoa.Name = "txt_IDXoa";
            this.txt_IDXoa.Size = new System.Drawing.Size(100, 30);
            this.txt_IDXoa.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã hàng cần xóa";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(618, 438);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(109, 44);
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(997, 436);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 44);
            this.btn_Sua.TabIndex = 17;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_DonGia_Sua
            // 
            this.txt_DonGia_Sua.Location = new System.Drawing.Point(997, 380);
            this.txt_DonGia_Sua.Name = "txt_DonGia_Sua";
            this.txt_DonGia_Sua.Size = new System.Drawing.Size(265, 30);
            this.txt_DonGia_Sua.TabIndex = 16;
            this.txt_DonGia_Sua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonGia_Sua_KeyPress);
            // 
            // txt_SoLuong_Sua
            // 
            this.txt_SoLuong_Sua.Location = new System.Drawing.Point(997, 330);
            this.txt_SoLuong_Sua.Name = "txt_SoLuong_Sua";
            this.txt_SoLuong_Sua.Size = new System.Drawing.Size(265, 30);
            this.txt_SoLuong_Sua.TabIndex = 15;
            this.txt_SoLuong_Sua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_Sua_KeyPress);
            // 
            // txt_TenHang_Sua
            // 
            this.txt_TenHang_Sua.Location = new System.Drawing.Point(997, 287);
            this.txt_TenHang_Sua.Name = "txt_TenHang_Sua";
            this.txt_TenHang_Sua.Size = new System.Drawing.Size(265, 30);
            this.txt_TenHang_Sua.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(889, 383);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(883, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(883, 287);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tên hàng";
            // 
            // txt_IDSua
            // 
            this.txt_IDSua.Location = new System.Drawing.Point(1198, 223);
            this.txt_IDSua.Name = "txt_IDSua";
            this.txt_IDSua.Size = new System.Drawing.Size(46, 30);
            this.txt_IDSua.TabIndex = 18;
            this.txt_IDSua.TextChanged += new System.EventHandler(this.txt_IDSua_TextChanged);
            // 
            // ViDuLinQtoSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 620);
            this.Controls.Add(this.txt_IDSua);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.txt_DonGia_Sua);
            this.Controls.Add(this.txt_SoLuong_Sua);
            this.Controls.Add(this.txt_TenHang_Sua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_IDXoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.txt_TenHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_MatHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViDuLinQtoSQL";
            this.Text = "ViDuLinQtoSQL";
            this.Load += new System.EventHandler(this.ViDuLinQtoSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_IDXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_DonGia_Sua;
        private System.Windows.Forms.TextBox txt_SoLuong_Sua;
        private System.Windows.Forms.TextBox txt_TenHang_Sua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_IDSua;
    }
}