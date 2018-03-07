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
	public partial class GenelBilgi : Form
	{
		List<string> görevliler = new List<string>();
		public int genelToplam = 0;

		public GenelBilgi()
		{
			InitializeComponent();
		}

		public void GenelBilgi_Load(object sender, EventArgs e)
		{
			SqlConnection Conn = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm1 = new SqlCommand("SELECT UserId  FROM GiseGorevlileri", Conn);
			Conn.Open();
			SqlDataReader DR1 = Comm1.ExecuteReader();
			while (DR1.Read())
				görevliler.Add(DR1.GetString(0));

			int[] sattıklarıBilet = new int[görevliler.Count];
			int[] sattıklarıBiletTutarları = new int[görevliler.Count];
			

			SqlConnection Conn2 = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm2 = new SqlCommand("SELECT İslemYapanId, Bilet_Sayısı,Tutar  FROM Biletler", Conn2);
			Conn2.Open();
			SqlDataReader DR2 = Comm2.ExecuteReader();

			while (DR2.Read())
			{
				sattıklarıBilet[görevliler.IndexOf(DR2.GetString(0))]+=DR2.GetInt32(1);
				sattıklarıBiletTutarları[görevliler.IndexOf(DR2.GetString(0))] += DR2.GetInt32(2);
			}

			for (int i=0;i<görevliler.Count;i++)
			{
				ListViewItem yeniSatır = new ListViewItem(görevliler[i]);
				yeniSatır.SubItems.Add(sattıklarıBilet[i].ToString());
				yeniSatır.SubItems.Add(sattıklarıBiletTutarları[i].ToString());
				listView1.Items.Add(yeniSatır);
				genelToplam += sattıklarıBiletTutarları[i];
			}

			textBox1.Text = genelToplam.ToString();

			List<string> kalkış = new List<string>();
			List<string> varış = new List<string>();

			SqlConnection Conn3 = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm3 = new SqlCommand("SELECT DISTINCT Nerden, Nereye  FROM Seferler GROUP BY Nerden, Nereye", Conn3);
			Conn3.Open();
			SqlDataReader DR3 = Comm3.ExecuteReader();

			while (DR3.Read())
			{
				kalkış.Add(DR3.GetString(0));
				varış.Add(DR3.GetString(1));
			}

			SqlConnection Conn4 = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm4 = new SqlCommand("SELECT DISTINCT KalkisNoktasi, VarisNoktasi, SUM(Bilet_Sayısı), SUM(Tutar) FROM Biletler GROUP BY KalkisNoktasi, VarisNoktasi", Conn4);
			Conn4.Open();
			SqlDataReader DR4 = Comm4.ExecuteReader();

			while(DR4.Read())
			{
				for(int i=0;i<kalkış.Count;i++)
				{
					if (kalkış[i] == DR4.GetString(0) && varış[i] == DR4.GetString(1))
					{
						ListViewItem yeniSatır = new ListViewItem(kalkış[i]);
						yeniSatır.SubItems.Add(varış[i]);
						yeniSatır.SubItems.Add(DR4.GetInt32(2).ToString());
						yeniSatır.SubItems.Add(DR4.GetInt32(3).ToString());
						listView2.Items.Add(yeniSatır);
						kalkış.RemoveAt(i);
						varış.RemoveAt(i);
					}
				}
			}

			for(int i=0;i<varış.Count;i++)
			{
				ListViewItem yeniSatır = new ListViewItem(kalkış[i]);
				yeniSatır.SubItems.Add(varış[i]);
				yeniSatır.SubItems.Add("-");
				yeniSatır.SubItems.Add("-");
				listView2.Items.Add(yeniSatır);
			}

		}
	}
}
