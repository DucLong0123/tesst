
namespace KetNoiADO.NET
{
    partial class frm_Main
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
            this.VD_4 = new System.Windows.Forms.Button();
            this.VD_3 = new System.Windows.Forms.Button();
            this.VD_2 = new System.Windows.Forms.Button();
            this.VD_1 = new System.Windows.Forms.Button();
            this.panel_ChucNang = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VD_4);
            this.groupBox1.Controls.Add(this.VD_3);
            this.groupBox1.Controls.Add(this.VD_2);
            this.groupBox1.Controls.Add(this.VD_1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(948, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ví dụ";
            // 
            // VD_4
            // 
            this.VD_4.Location = new System.Drawing.Point(649, 47);
            this.VD_4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VD_4.Name = "VD_4";
            this.VD_4.Size = new System.Drawing.Size(195, 35);
            this.VD_4.TabIndex = 3;
            this.VD_4.Text = "4. Thêm sửa xóa Hàng - LinQ to SQL\r\n";
            this.VD_4.UseVisualStyleBackColor = true;
            this.VD_4.Click += new System.EventHandler(this.VD_4_Click);
            // 
            // VD_3
            // 
            this.VD_3.Location = new System.Drawing.Point(406, 47);
            this.VD_3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VD_3.Name = "VD_3";
            this.VD_3.Size = new System.Drawing.Size(195, 35);
            this.VD_3.TabIndex = 2;
            this.VD_3.Text = "3. Thêm sửa xóa Hàng - ADO.NET";
            this.VD_3.UseVisualStyleBackColor = true;
            this.VD_3.Click += new System.EventHandler(this.VD_3_Click);
            // 
            // VD_2
            // 
            this.VD_2.Location = new System.Drawing.Point(172, 47);
            this.VD_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VD_2.Name = "VD_2";
            this.VD_2.Size = new System.Drawing.Size(205, 35);
            this.VD_2.TabIndex = 1;
            this.VD_2.Text = "2. Cập nhật dữ liệu";
            this.VD_2.UseVisualStyleBackColor = true;
            this.VD_2.Click += new System.EventHandler(this.VD_2_Click);
            // 
            // VD_1
            // 
            this.VD_1.Location = new System.Drawing.Point(8, 47);
            this.VD_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VD_1.Name = "VD_1";
            this.VD_1.Size = new System.Drawing.Size(156, 35);
            this.VD_1.TabIndex = 0;
            this.VD_1.Text = "1. MH Ngắt KN";
            this.VD_1.UseVisualStyleBackColor = true;
            this.VD_1.Click += new System.EventHandler(this.VD_1_Click);
            // 
            // panel_ChucNang
            // 
            this.panel_ChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChucNang.Location = new System.Drawing.Point(0, 103);
            this.panel_ChucNang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_ChucNang.Name = "panel_ChucNang";
            this.panel_ChucNang.Size = new System.Drawing.Size(948, 471);
            this.panel_ChucNang.TabIndex = 1;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 574);
            this.Controls.Add(this.panel_ChucNang);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Main";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_ChucNang;
        private System.Windows.Forms.Button VD_1;
        private System.Windows.Forms.Button VD_2;
        private System.Windows.Forms.Button VD_3;
        private System.Windows.Forms.Button VD_4;
    }
}