using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPro1
{
	public partial class GirişEkranı : Form
	{
		public static String kullanıcıAdı;

		public GirişEkranı()
		{
			InitializeComponent();
			Yoneticiİşlemleri.YoneticiBul();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			/*using (var db = new TrenBiletiSatisSistemiEntities())
			{
				Yoneticiler manager = db.Yoneticiler.SingleOrDefault(yonetici => yonetici.ManagerId.ToString() == userTxtBox.Text.ToString());
				if (manager != null && manager.ManagerId == userTxtBox.Text && manager.Password == passTxtBox.Text)
				{
					this.Visible=false;
					Form1 yoneticiEkranı = new Form1();
					kullanıcıAdı = manager.ManagerId;
					yoneticiEkranı.Show();

				}
				else
				{
					yoneticiHata.Visible = true;
				}

			}*/

			if(Yoneticiİşlemleri.managerNames.Contains(userTxtBox.Text) && Yoneticiİşlemleri.managerPasswords.Contains(passTxtBox.Text))
			{
				if(Yoneticiİşlemleri.managerPasswords.ElementAt(Yoneticiİşlemleri.managerNames.IndexOf(userTxtBox.Text))==passTxtBox.Text)
				{	
					this.Visible = false;
					Form1 yoneticiEkranı = new Form1();
					kullanıcıAdı = userTxtBox.Text;
					yoneticiEkranı.Show();
				}
			}else
			{
				passTxtBox.Text = "";
				yoneticiHata.Visible = true;
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (var db = new TrenBiletiSatisSistemiEntities6())
			{
				GiseGorevlileri giseGorevlisi = db.GiseGorevlileri.SingleOrDefault(gorevli => gorevli.UserId.ToString() == textBox1.Text.ToString());
				if (giseGorevlisi != null && giseGorevlisi.UserId == textBox1.Text.ToString() && giseGorevlisi.Password == textBox2.Text)
				{
					this.Visible = false;
					GorevliIslemleri gorevliPenceresi = new GorevliIslemleri();
					kullanıcıAdı = giseGorevlisi.UserId;
					gorevliPenceresi.Show();

				}
				else
				{
					textBox2.Text = "";
					gorevliHata.Visible = true;
				}
			}
		}

		private void GirişEkranı_Load(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			BiletSorgula biletSorguPenceresi = new BiletSorgula();
			this.Hide();
			biletSorguPenceresi.Show();
		}
	}
}
