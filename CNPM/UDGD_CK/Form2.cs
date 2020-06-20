using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UDGD_CK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conect = new SqlConnection(@"Data Source=.;Initial Catalog=QLNhanSu;Integrated Security=True");

        private void ketnoi()
        {

            string sql = "select * from ThanNhan";
            SqlCommand com = new SqlCommand(sql, conect);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgv_tn.DataSource = dt;



        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void hienthi()
        {
            txt_matn.DataBindings.Clear();
            txt_matn.DataBindings.Add("Text", dgv_tn.DataSource, "maTN");
            txt_tentn.DataBindings.Clear();
            txt_tentn.DataBindings.Add("Text", dgv_tn.DataSource, "ten_TN");
            txt_dctn.DataBindings.Clear();
            txt_dctn.DataBindings.Add("Text", dgv_tn.DataSource, "diaChi_TN");

            txt_qhtn.DataBindings.Clear();
            txt_qhtn.DataBindings.Add("Text", dgv_tn.DataSource, "quanHe");
            txt_gttn.DataBindings.Clear();
            txt_gttn.DataBindings.Add("Text", dgv_tn.DataSource, "gioiTinh_TN");
            txt_sdttn.DataBindings.Clear();
            txt_sdttn.DataBindings.Add("Text", dgv_tn.DataSource, "sdt_TN");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conect.Open();
            ketnoi();
            hienthi();
        }

        private void dgv_tn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            conect.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlthem = "insert into ThanNhan (maTN,ten_TN,diaChi_TN,sdt_TN,quanHe,gioiTinh_TN) values (@maTN,@ten_TN,@diaChi_TN,@sdt_TN,@quanHe,@gioiTinh_TN)";
                SqlCommand cmd = new SqlCommand(sqlthem, conect);

                cmd.Parameters.AddWithValue("maTN", txt_matn.Text);
                cmd.Parameters.AddWithValue("ten_TN", txt_tentn.Text);
                cmd.Parameters.AddWithValue("diaChi_TN", txt_dctn.Text);
                cmd.Parameters.AddWithValue("gioiTinh_TN", txt_gttn.Text);
                cmd.Parameters.AddWithValue("sdt_TN", txt_sdttn.Text);
                cmd.Parameters.AddWithValue("quanHe", txt_qhtn.Text);
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                MessageBox.Show("Ma than nhan da ton tai or nhap sai!");
            }
            ketnoi();
            hienthi();
        }

        private void btn_xoatn_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_suatn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlsua = "UPDATE ThanNhan SET maTN=@maTn,ten_TN= @ten_TN, diaChi_TN=@diaChi_TN, gioiTinh_TN=@gioiTinh_TN, sdt_TN=@sdt_TN,quanHe=@quanHe where maTn=@maTN ";
                SqlCommand cmd = new SqlCommand(sqlsua, conect);
                cmd.Parameters.AddWithValue("maTN", txt_matn.Text);
                cmd.Parameters.AddWithValue("ten_TN", txt_tentn.Text);
                cmd.Parameters.AddWithValue("diaChi_TN", txt_dctn.Text);
                cmd.Parameters.AddWithValue("gioiTinh_TN", txt_gttn.Text);
                cmd.Parameters.AddWithValue("sdt_TN", txt_sdttn.Text);
                cmd.Parameters.AddWithValue("quanHe", txt_qhtn.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui long kiem tra lai thong tin nhap vao!");
            }

            ketnoi();
            hienthi();
        }
    }
}
