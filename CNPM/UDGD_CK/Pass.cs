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
    public partial class Pass : Form
    {
        public Pass()
        {
            InitializeComponent();
        }
        public string xacthuc;
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=QLNhanSu;Integrated Security=True");
        void mail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("leewanghy2604@gmail.com");
                mail.To.Add(txt_email.Text);
                mail.Subject = "Ma xac thuc";
                string Numrd_str;
                Random rd = new Random();
                Numrd_str = rd.Next(1000, 9999).ToString();
                mail.Body = Numrd_str;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("leewanghy2604@gmail.com", "Tonybuoisang@2604");
                SmtpServer.EnableSsl = true;
                xacthuc = Numrd_str;
                SmtpServer.Send(mail);

                MessageBox.Show("Kiem tra mail cua ban de nhap ma xac thuc");
                txt_mxt.Enabled = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Mat khau hoac ten dang nhap khong dung.");
            }
        }
        private void Pass_Load(object sender, EventArgs e)
        {

        }

       

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (txt_mxt.Enabled == true)
            {
                if (Int32.Parse(xacthuc) == Int32.Parse(txt_mxt.Text))
                {
                    MessageBox.Show("Xac thuc thanh cong");
                    txt_pass.Enabled = true;
                    txt_passag.Enabled = true;
                    txt_mxt.Enabled = false;
                    txt_email.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ma xac thuc khong dung");
                }
            }
            else if (txt_pass.Enabled ==true)
            {
                
                if (txt_pass.Text != txt_passag.Text)
                {
                    MessageBox.Show("Mat khau nhap lai khong khop!!!");
                    txt_pass.Text = "";
                    txt_passag.Text = "";
                }
                else
                {
                    connect.Open();
                    try
                    {
                        string sqlsua = "UPDATE DangNhap SET pass=@pass  where email='" + txt_email.Text + "'";
                        SqlCommand cmd = new SqlCommand(sqlsua, connect);
                        cmd.Parameters.AddWithValue("pass", txt_pass.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doi password thanh cong!!!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Password chua cac ki tu khong phu hop");
                    }
                    connect.Close();
                }
            }
            else
            {
                mail();
            }
        }

        private void btn_mk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
