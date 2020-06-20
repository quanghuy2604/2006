namespace UDGD_CK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_matn = new System.Windows.Forms.TextBox();
            this.txt_tentn = new System.Windows.Forms.TextBox();
            this.txt_sdttn = new System.Windows.Forms.TextBox();
            this.txt_qhtn = new System.Windows.Forms.TextBox();
            this.txt_dctn = new System.Windows.Forms.TextBox();
            this.txt_gttn = new System.Windows.Forms.TextBox();
            this.dgv_tn = new System.Windows.Forms.DataGridView();
            this.maTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_TN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt_TN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi_TN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh_TN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_suatn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma than nhan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quan he";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dia chi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gioi tinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ten than nhan";
            // 
            // txt_matn
            // 
            this.txt_matn.Location = new System.Drawing.Point(124, 17);
            this.txt_matn.Name = "txt_matn";
            this.txt_matn.Size = new System.Drawing.Size(247, 20);
            this.txt_matn.TabIndex = 7;
            // 
            // txt_tentn
            // 
            this.txt_tentn.Location = new System.Drawing.Point(124, 51);
            this.txt_tentn.Name = "txt_tentn";
            this.txt_tentn.Size = new System.Drawing.Size(247, 20);
            this.txt_tentn.TabIndex = 8;
            // 
            // txt_sdttn
            // 
            this.txt_sdttn.Location = new System.Drawing.Point(124, 85);
            this.txt_sdttn.Name = "txt_sdttn";
            this.txt_sdttn.Size = new System.Drawing.Size(247, 20);
            this.txt_sdttn.TabIndex = 9;
            // 
            // txt_qhtn
            // 
            this.txt_qhtn.Location = new System.Drawing.Point(124, 127);
            this.txt_qhtn.Name = "txt_qhtn";
            this.txt_qhtn.Size = new System.Drawing.Size(247, 20);
            this.txt_qhtn.TabIndex = 10;
            // 
            // txt_dctn
            // 
            this.txt_dctn.Location = new System.Drawing.Point(124, 162);
            this.txt_dctn.Name = "txt_dctn";
            this.txt_dctn.Size = new System.Drawing.Size(247, 20);
            this.txt_dctn.TabIndex = 11;
            // 
            // txt_gttn
            // 
            this.txt_gttn.Location = new System.Drawing.Point(124, 192);
            this.txt_gttn.Name = "txt_gttn";
            this.txt_gttn.Size = new System.Drawing.Size(247, 20);
            this.txt_gttn.TabIndex = 12;
            // 
            // dgv_tn
            // 
            this.dgv_tn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTN,
            this.ten_TN,
            this.sdt_TN,
            this.diaChi_TN,
            this.gioiTinh_TN,
            this.quanHe});
            this.dgv_tn.Location = new System.Drawing.Point(9, 230);
            this.dgv_tn.Name = "dgv_tn";
            this.dgv_tn.Size = new System.Drawing.Size(453, 172);
            this.dgv_tn.TabIndex = 13;
            this.dgv_tn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tn_CellContentClick);
            // 
            // maTN
            // 
            this.maTN.DataPropertyName = "maTN";
            this.maTN.HeaderText = "Ma than nhan";
            this.maTN.Name = "maTN";
            // 
            // ten_TN
            // 
            this.ten_TN.DataPropertyName = "ten_TN";
            this.ten_TN.HeaderText = "Ten than nhan";
            this.ten_TN.Name = "ten_TN";
            // 
            // sdt_TN
            // 
            this.sdt_TN.DataPropertyName = "sdt_TN";
            this.sdt_TN.HeaderText = "SDT";
            this.sdt_TN.Name = "sdt_TN";
            // 
            // diaChi_TN
            // 
            this.diaChi_TN.DataPropertyName = "diaChi_TN";
            this.diaChi_TN.HeaderText = "Dia Chi";
            this.diaChi_TN.Name = "diaChi_TN";
            // 
            // gioiTinh_TN
            // 
            this.gioiTinh_TN.DataPropertyName = "gioiTInh_TN";
            this.gioiTinh_TN.HeaderText = "Gioi Tinh";
            this.gioiTinh_TN.Name = "gioiTinh_TN";
            this.gioiTinh_TN.Visible = false;
            // 
            // quanHe
            // 
            this.quanHe.DataPropertyName = "quanHe";
            this.quanHe.HeaderText = "Quan he";
            this.quanHe.Name = "quanHe";
            this.quanHe.Visible = false;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(391, 17);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(71, 79);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = "Them";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_suatn
            // 
            this.btn_suatn.Location = new System.Drawing.Point(391, 127);
            this.btn_suatn.Name = "btn_suatn";
            this.btn_suatn.Size = new System.Drawing.Size(71, 85);
            this.btn_suatn.TabIndex = 16;
            this.btn_suatn.Text = "Sua";
            this.btn_suatn.UseVisualStyleBackColor = true;
            this.btn_suatn.Click += new System.EventHandler(this.btn_suatn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 409);
            this.Controls.Add(this.btn_suatn);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_tn);
            this.Controls.Add(this.txt_gttn);
            this.Controls.Add(this.txt_dctn);
            this.Controls.Add(this.txt_qhtn);
            this.Controls.Add(this.txt_sdttn);
            this.Controls.Add(this.txt_tentn);
            this.Controls.Add(this.txt_matn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Than Nhan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_matn;
        private System.Windows.Forms.TextBox txt_tentn;
        private System.Windows.Forms.TextBox txt_sdttn;
        private System.Windows.Forms.TextBox txt_qhtn;
        private System.Windows.Forms.TextBox txt_dctn;
        private System.Windows.Forms.TextBox txt_gttn;
        private System.Windows.Forms.DataGridView dgv_tn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_TN;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt_TN;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi_TN;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh_TN;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanHe;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_suatn;
    }
}