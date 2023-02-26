using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLUygulamasi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbNotKayit;Integrated Security=True");

		private void Form1_Load(object sender, EventArgs e)
		{
			this.BackColor = ColorTranslator.FromHtml("0xffa585");
			BtnCalistir.BackColor = ColorTranslator.FromHtml("0x00ff87");
			BtnSql.BackColor = ColorTranslator.FromHtml("0xffeda0");
		}

		private void BtnCalistir_Click(object sender, EventArgs e)
		{
			string sqlStatement = richTextBox1.Text;
			try
			{
				SqlDataAdapter da = new SqlDataAdapter(sqlStatement, baglanti);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridView1.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Sorgu hatası. Sorgunuzu kontrol ediniz..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}

		private void BtnSql_Click(object sender, EventArgs e)
		{
			string sqlStatement = richTextBox1.Text;
			baglanti.Open();
			SqlCommand komut = new SqlCommand(sqlStatement,baglanti);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("İşlem başarı ile gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			selectQuery();
		}

		public void selectQuery()
		{
			SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERS", baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}
	}
}
