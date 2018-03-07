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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			/*using (var db = new TrenBiletiSatisSistemiEntities())
			{
				if (!db.Yoneticiler.Any(yonetici => yonetici.ManagerId == "onatilhan"))
				{
					var manager = new Yoneticiler()
					{
						 ManagerId= "onatilhan",
						 Password= "123456"
					};
					db.Yoneticiler.Add(manager);
					db.SaveChanges();
				}

			}*/
		}

		void childform(Form yavru)
		{
			bool durum = false;
			foreach (Form eleman in this.MdiChildren)
			{
				if (eleman.Text == yavru.Text)
				{
					durum = true;
					eleman.Activate();

				}
				else
				{
					eleman.Close();
				}
			}
			if (durum == false)
			{
				yavru.MdiParent=this;
				yavru.Show();
			}
		}

		private void görevliEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 gorevliEkle = new Form2();
			childform(gorevliEkle);
			
		}

		private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			//Environment.Exit(0);
			GirişEkranı geriDon = new GirişEkranı();
			geriDon.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Text += GirişEkranı.kullanıcıAdı;
			tarihLbl.Text += DateTime.Today.Date.ToShortDateString();
		}

		private void şifreGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			childform(new SifreGüncelleme());
		}

		private void görevliSilToolStripMenuItem_Click(object sender, EventArgs e)
		{
			childform(new SilinecekGorevli());
		}

		private void satılanBiletlerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			childform(new TümBiletler());

		}

		private void toplamCiroToolStripMenuItem_Click(object sender, EventArgs e)
		{
			childform(new GenelBilgi());

		}

		private void seferleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			childform(new SeferGörüntüle());
		}

		private void seferEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
		{
			childform(new SeferEkleSil());
		}

		private void yöneticiEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			childform(new YöneticiEkle());

		}
	}
}
