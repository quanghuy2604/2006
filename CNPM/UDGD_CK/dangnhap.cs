using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace UDGD_CK
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
        public string nameuser;
        SqlConnection conect = new SqlConnection(@"Data Source=.;Initial Catalog=QLNhanSu;Integrated Security=True");
        void mail()
        {
           try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(txt_name.Text);
                mail.To.Add("leewanghy2604@gmail.com");
                mail.Subject = "LS Dang Nhap";
                mail.Body = "LOGIN";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(txt_name.Text, txt_pass.Text);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                nameuser = txt_name.Text;
                limit = "1";
           
                    
                

                this.Hide();

            }

            catch (Exception)
            {
                MessageBox.Show("Mat khau hoac ten dang nhap khong dung.");
            }
        }
        
        private void login()
        {
           
            try
            {
                
                string username = txt_name.Text;
                string pass = txt_pass.Text;
                string sql = "select limit from DangNhap where (username='"+username+"'or email='"+username+"') and pass='"+pass+"'";
                SqlCommand cmd = new SqlCommand(sql,conect);
                SqlDataReader dl = cmd.ExecuteReader();
                if (dl.Read())
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    nameuser = username;
                    limit = dl["limit"].ToString();
                }
                else
                {
                    MessageBox.Show("Sai mat khau hoac ten dang nhap.");
                }
                
                
                this.Hide();
            }
            catch (Exception )
            {
                MessageBox.Show("Loi dang nhap!!!");
            }

        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            conect.Open();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            
            txt_pass.PasswordChar = '*';
        }
        public string limit;
        public delegate void gdl(string data);
        public gdl data;
        public gdl limits;

        private void btn_kn_Click(object sender, EventArgs e)
        {
            login();
            
            data(nameuser);
            limits(limit);
        }

        private void chb_ht_CheckedChanged(object sender, EventArgs e)
        {
            if (!chb_ht.Checked)
            {
                txt_pass.UseSystemPasswordChar=false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_google_Click(object sender, EventArgs e)
        {
            mail();
            data(nameuser);
            limits(limit);
        }

        private void lb_mk_Click(object sender, EventArgs e)
        {
            Pass frm = new Pass();
            frm.ShowDialog();
        }

        private void lb_user_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hay thu dang nhap bang email xac thuc, neu quen het thi lien he admin de nghe chui va lay lai tai khoan!!!!");
        }

        private void dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
