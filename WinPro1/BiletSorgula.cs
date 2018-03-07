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

namespace WinPro1
{
	public partial class BiletSorgula : Form
	{
		public BiletSorgula()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var isNumeric = Int32.TryParse(textBox1.Text, out var n);
			
			label3.Text = "Yolcu Adı : ";
			label4.Text = "Çıkış : ";
			label5.Text = "Varış : ";
			label6.Text = "Gidiş Tarihi : ";
			label7.Text = "Saati : ";
			label8.Text = "Ücreti : ";
			label9.Text = "Yetişkin Sayısı : ";
			label10.Text = "Çocuk Sayısı : ";
			label11.Text = "İşlem Yapan ID : ";
			label12.Text = "Bilet Numarası : ";
			label13.Text = "Dönüş Tarihi : ";
			label14.Text = "Saati : ";

			SqlConnection Conn = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm1 = new SqlCommand("SELECT * FROM Biletler WHERE BiletNumarasi = '"+textBox1.Text+"' AND Musteri_Adı = '"+textBox2.Text+"'", Conn);
			Conn.Open();
			SqlDataReader DR1 = Comm1.ExecuteReader();

			if(isNumeric)
			{
				if (DR1.Read())
				{
					panel1.Visible = true;
					if (DR1.GetString(7) != "Tek Yön")
					{
						label13.Text += DR1.GetString(4);
						label14.Text += DR1.GetString(13);
					}
					else
					{
						label13.Text += "-";
						label14.Text += "-";
					}

					label3.Text += DR1.GetString(9);
					label4.Text += DR1.GetString(1);
					label5.Text += DR1.GetString(2);
					label6.Text += DR1.GetString(3);
					label7.Text += DR1.GetString(12);
					label8.Text += DR1.GetInt32(11).ToString();
					label9.Text += DR1.GetInt32(5).ToString();
					label10.Text += DR1.GetInt32(6).ToString();
					label11.Text += DR1.GetString(8);
					label12.Text += DR1.GetInt32(0).ToString();
				}
				else
				{
					panel1.Visible = false;
					MessageBox.Show("BU BİLET NUMARASINA VE BU İSME SAHİP BİR BİLET BULUNMAMAKTADIR!", "BİLET BULUNAMADI", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}
			else
			{
				MessageBox.Show("LÜTFEN BİLET NUMARASINI SAYISAL BİR DEĞER GİRİNİZ!", "BİLET NUMARASI YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

			Conn.Close();
		}


		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Environment.Exit(1);	
		}

		private void BiletSorgula_Load(object sender, EventArgs e)
		{
			if (this.MdiParent == null)
				pictureBox2.Visible = true;
			else
				pictureBox2.Visible = false;
		}
	}
}
