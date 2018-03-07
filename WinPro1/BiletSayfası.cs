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
	public partial class BiletSayfası : Form
	{
		int tamTutar = 0, cocukTutar = 0;
		public BiletSayfası()
		{
			InitializeComponent();
		}

		private void BiletSayfası_Load(object sender, EventArgs e)
		{
			radioButton1.Checked = true;
			SqlConnection Conn = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm1 = new SqlCommand("SELECT DISTINCT Nerden FROM Seferler", Conn);
			Conn.Open();
			SqlDataReader DR1 = Comm1.ExecuteReader();
			while (DR1.Read())
			{
				comboBox1.Items.Add(DR1.GetString(0));
			}
			Conn.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String direction = null, dönüşTarihi=null, dönSaati=null;
			int totalAmount = 0, biletSayısı = 0, ticketNum = 0; ;

			if (radioButton1.Checked == true)
			{
				dönüşTarihi = "-";
				dönSaati = "-";
				direction = "Tek Yön";
				biletSayısı = (int)numericUpDown1.Value + (int)numericUpDown2.Value;
				totalAmount = tamTutar * (int)numericUpDown1.Value + cocukTutar * (int)numericUpDown2.Value;
			}
			else
			{
				dönüşTarihi = dateTimePicker2.Text;
				dönSaati = comboBox4.Text;
				direction = "Gidiş - Dönüş";
				biletSayısı = 2*((int)numericUpDown1.Value + (int)numericUpDown2.Value);
				totalAmount = 2*(tamTutar * (int)numericUpDown1.Value + cocukTutar * (int)numericUpDown2.Value);
			}

			using (var db = new TrenBiletiSatisSistemiEntities6())
			{
				ticketNum = db.Biletler.Count(c => c.BiletNumarasi != 0) + 1;

				if (dateTimePicker1.Text.CompareTo(dateTimePicker2.Text) != 1 || radioButton1.Checked==true)
				{
					if(db.Biletler.Any(bilet => bilet.BiletNumarasi == ticketNum))
					{
						while (db.Biletler.Any(bilet => bilet.BiletNumarasi == ticketNum))
							ticketNum++;
					}
					var yeniBilet = new Biletler()
					{
						Musteri_Adı = textBox1.Text,
						BiletNumarasi = ticketNum,
						GidisTarihi = dateTimePicker1.Text,
						KalkisNoktasi = comboBox1.SelectedItem.ToString(),
						VarisNoktasi = comboBox2.SelectedItem.ToString(),
						DonusTarihi = dönüşTarihi,
						YonBilgisi = direction,
						İslemYapanId = GirişEkranı.kullanıcıAdı,
						KisiSayisi = (int)numericUpDown1.Value,
						CocukSayisi = (int)numericUpDown2.Value,
						Bilet_Sayısı = biletSayısı,
						Tutar = totalAmount,
						Saati = comboBox3.SelectedItem.ToString(),
						DönüşSaati=dönSaati
					};

					db.Biletler.Add(yeniBilet);
					db.SaveChanges();
					MessageBox.Show(ticketNum + " NUMARALI BİLET BAŞARIYLA OLUŞTURULDU!", "BİLET HAZIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
					textBox1.Text = "";
					dateTimePicker1.Text = "";
					dateTimePicker2.Text = "";
					comboBox1.Text = "";
					comboBox2.Text = "";
					comboBox3.Text = "";
					comboBox4.Text = "";
					numericUpDown1.Value = 0;
					numericUpDown2.Value = 0;
				}
				else
				{
					MessageBox.Show("LÜTFEN DÖNÜŞ TARİHİNİZİ GİDİŞ TARİHİNDEN SONRAKİ BİR GÜN SEÇİNİZ!", "DÖNÜŞ TARİHİ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			label5.Enabled = true;
			dateTimePicker2.Enabled = true;
			label10.Enabled = true;
			comboBox4.Enabled = true;
			dateTimePicker2.Text = "";
			comboBox4.Text = "";
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			label5.Enabled = false;
			dateTimePicker2.Enabled = false;
			label10.Enabled = false;
			comboBox4.Enabled = false;
			dateTimePicker2.Text = "";
			comboBox4.Text = "";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox2.Items.Clear();
			comboBox3.Items.Clear();
			comboBox4.Items.Clear();

			SqlConnection Conn = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm1 = new SqlCommand("SELECT DISTINCT Nereye,Saati,Yetişkin_Fiyatı,Cocuk_Fiyatı FROM Seferler WHERE Nerden='"+comboBox1.Text+"'", Conn);
			Conn.Open();
			SqlDataReader DR1 = Comm1.ExecuteReader();

			while (DR1.Read())
			{
				if (!comboBox2.Items.Contains(DR1.GetString(0)))
				comboBox2.Items.Add(DR1.GetString(0));		
			}
			Conn.Close();
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox3.Items.Clear();
			comboBox4.Items.Clear();

			SqlConnection Conn = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm1 = new SqlCommand("SELECT DISTINCT Saati,Yetişkin_Fiyatı,Cocuk_Fiyatı FROM Seferler WHERE Nerden='" + comboBox1.Text + "' AND Nereye='"+ comboBox2.Text+"'", Conn);
			Conn.Open();
			SqlDataReader DR1 = Comm1.ExecuteReader();
			while (DR1.Read())
			{
				tamTutar =Int32.Parse(DR1.GetString(1));
				cocukTutar = Int32.Parse(DR1.GetString(2));
				comboBox3.Items.Add(DR1.GetString(0));
				//comboBox4.Items.Add(DR1.GetString(0));
			}
			Conn.Close();


			SqlConnection Conn2 = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm2 = new SqlCommand("SELECT DISTINCT Saati,Yetişkin_Fiyatı,Cocuk_Fiyatı FROM Seferler WHERE Nerden='" + comboBox2.Text + "' AND Nereye='" + comboBox1.Text + "'", Conn2);
			Conn2.Open();
			SqlDataReader DR2 = Comm2.ExecuteReader();
			while (DR2.Read())
			{
				//comboBox3.Items.Add(DR1.GetString(0));
				comboBox4.Items.Add(DR2.GetString(0));
			}
			Conn.Close();
		}
	}
}
