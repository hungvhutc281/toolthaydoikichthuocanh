namespace thaydoikichthuocanh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txt_linkfolderchon = new TextBox();
            btn_xuatfolderdachay = new Button();
            txt_linkfolderxuat = new TextBox();
            btn_tienhanh = new Button();
            btn_kichthuoc1 = new Button();
            btn_kichthuoc2 = new Button();
            txt_kthuoc1 = new TextBox();
            txt_kichthuoc2 = new TextBox();
            btn_chonfolder = new Button();
            SuspendLayout();
            // 
            // txt_linkfolderchon
            // 
            txt_linkfolderchon.Location = new Point(374, 59);
            txt_linkfolderchon.Name = "txt_linkfolderchon";
            txt_linkfolderchon.Size = new Size(440, 23);
            txt_linkfolderchon.TabIndex = 1;
            txt_linkfolderchon.TextChanged += txt_linkfolderchon_TextChanged;
            // 
            // btn_xuatfolderdachay
            // 
            btn_xuatfolderdachay.Location = new Point(124, 144);
            btn_xuatfolderdachay.Name = "btn_xuatfolderdachay";
            btn_xuatfolderdachay.Size = new Size(234, 22);
            btn_xuatfolderdachay.TabIndex = 0;
            btn_xuatfolderdachay.Text = "Chọn folder lưu sau khi chuyển đổi";
            btn_xuatfolderdachay.UseVisualStyleBackColor = true;
            btn_xuatfolderdachay.Click += btn_xuatfolderdachay_Click;
            // 
            // txt_linkfolderxuat
            // 
            txt_linkfolderxuat.Location = new Point(374, 143);
            txt_linkfolderxuat.Name = "txt_linkfolderxuat";
            txt_linkfolderxuat.Size = new Size(440, 23);
            txt_linkfolderxuat.TabIndex = 1;
            txt_linkfolderxuat.TextChanged += txt_linkfolderxuat_TextChanged;
            // 
            // btn_tienhanh
            // 
            btn_tienhanh.Location = new Point(457, 369);
            btn_tienhanh.Name = "btn_tienhanh";
            btn_tienhanh.Size = new Size(75, 23);
            btn_tienhanh.TabIndex = 0;
            btn_tienhanh.Text = "Tiến hành";
            btn_tienhanh.UseVisualStyleBackColor = true;
            btn_tienhanh.Click += btn_tienhanh_Click;
            // 
            // btn_kichthuoc1
            // 
            btn_kichthuoc1.Location = new Point(196, 257);
            btn_kichthuoc1.Name = "btn_kichthuoc1";
            btn_kichthuoc1.Size = new Size(141, 23);
            btn_kichthuoc1.TabIndex = 2;
            btn_kichthuoc1.Text = "kích thước 1";
            btn_kichthuoc1.UseVisualStyleBackColor = true;
            btn_kichthuoc1.Click += btn_kichthuoc1_Click;
            // 
            // btn_kichthuoc2
            // 
            btn_kichthuoc2.Location = new Point(510, 257);
            btn_kichthuoc2.Name = "btn_kichthuoc2";
            btn_kichthuoc2.Size = new Size(105, 23);
            btn_kichthuoc2.TabIndex = 3;
            btn_kichthuoc2.Text = "kích thước 2";
            btn_kichthuoc2.UseVisualStyleBackColor = true;
            btn_kichthuoc2.Click += btn_kichthuoc2_Click;
            // 
            // txt_kthuoc1
            // 
            txt_kthuoc1.Location = new Point(357, 258);
            txt_kthuoc1.Name = "txt_kthuoc1";
            txt_kthuoc1.Size = new Size(100, 23);
            txt_kthuoc1.TabIndex = 4;
            txt_kthuoc1.TextChanged += txt_kthuoc1_TextChanged;
            // 
            // txt_kichthuoc2
            // 
            txt_kichthuoc2.Location = new Point(667, 258);
            txt_kichthuoc2.Name = "txt_kichthuoc2";
            txt_kichthuoc2.Size = new Size(100, 23);
            txt_kichthuoc2.TabIndex = 4;
            txt_kichthuoc2.TextChanged += txt_kichthuoc2_TextChanged;
            // 
            // btn_chonfolder
            // 
            btn_chonfolder.Location = new Point(187, 59);
            btn_chonfolder.Name = "btn_chonfolder";
            btn_chonfolder.Size = new Size(150, 23);
            btn_chonfolder.TabIndex = 0;
            btn_chonfolder.Text = "Chọn folder chuyển đổi";
            btn_chonfolder.UseVisualStyleBackColor = true;
            btn_chonfolder.Click += btn_chonfolder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 651);
            Controls.Add(txt_kichthuoc2);
            Controls.Add(txt_kthuoc1);
            Controls.Add(btn_kichthuoc2);
            Controls.Add(btn_kichthuoc1);
            Controls.Add(txt_linkfolderxuat);
            Controls.Add(txt_linkfolderchon);
            Controls.Add(btn_tienhanh);
            Controls.Add(btn_chonfolder);
            Controls.Add(btn_xuatfolderdachay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txt_linkfolderchon;
        private Button btn_xuatfolderdachay;
        private TextBox txt_linkfolderxuat;
        private Button btn_tienhanh;
        private Button btn_kichthuoc1;
        private Button btn_kichthuoc2;
        private TextBox txt_kthuoc1;
        private TextBox txt_kichthuoc2;
        private Button btn_chonfolder;
    }
}
