namespace UDGD_CK
{
    partial class dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_kn = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.chb_ht = new System.Windows.Forms.CheckBox();
            this.btn_google = new System.Windows.Forms.Button();
            this.lb_mk = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(211, 181);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(173, 39);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(211, 233);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(173, 35);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ten dang nhap :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mat khau :";
            // 
            // btn_kn
            // 
            this.btn_kn.Location = new System.Drawing.Point(60, 336);
            this.btn_kn.Name = "btn_kn";
            this.btn_kn.Size = new System.Drawing.Size(90, 35);
            this.btn_kn.TabIndex = 5;
            this.btn_kn.Text = "Ket noi";
            this.btn_kn.UseVisualStyleBackColor = true;
            this.btn_kn.Click += new System.EventHandler(this.btn_kn_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(292, 336);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(92, 35);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // chb_ht
            // 
            this.chb_ht.AutoSize = true;
            this.chb_ht.Location = new System.Drawing.Point(211, 274);
            this.chb_ht.Name = "chb_ht";
            this.chb_ht.Size = new System.Drawing.Size(95, 17);
            this.chb_ht.TabIndex = 7;
            this.chb_ht.Text = "Hien mat khau";
            this.chb_ht.UseVisualStyleBackColor = true;
            this.chb_ht.CheckedChanged += new System.EventHandler(this.chb_ht_CheckedChanged);
            // 
            // btn_google
            // 
            this.btn_google.Location = new System.Drawing.Point(171, 336);
            this.btn_google.Name = "btn_google";
            this.btn_google.Size = new System.Drawing.Size(92, 35);
            this.btn_google.TabIndex = 8;
            this.btn_google.Text = "Ket noi Google";
            this.btn_google.UseVisualStyleBackColor = true;
            this.btn_google.Click += new System.EventHandler(this.btn_google_Click);
            // 
            // lb_mk
            // 
            this.lb_mk.AutoSize = true;
            this.lb_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_mk.Location = new System.Drawing.Point(57, 304);
            this.lb_mk.Name = "lb_mk";
            this.lb_mk.Size = new System.Drawing.Size(97, 16);
            this.lb_mk.TabIndex = 9;
            this.lb_mk.Text = "Quen mat khau";
            this.lb_mk.Click += new System.EventHandler(this.lb_mk_Click);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_user.Location = new System.Drawing.Point(256, 304);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(128, 16);
            this.lb_user.TabIndex = 10;
            this.lb_user.Text = "Quen ten dang nhap";
            this.lb_user.Click += new System.EventHandler(this.lb_user_Click);
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 383);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_mk);
            this.Controls.Add(this.btn_google);
            this.Controls.Add(this.chb_ht);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_kn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "dangnhap";
            this.Text = "Dang nhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dangnhap_FormClosing);
            this.Load += new System.EventHandler(this.dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_kn;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.CheckBox chb_ht;
        private System.Windows.Forms.Button btn_google;
        private System.Windows.Forms.Label lb_mk;
        private System.Windows.Forms.Label lb_user;
    }
}