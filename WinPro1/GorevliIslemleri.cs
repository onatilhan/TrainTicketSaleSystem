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
	public partial class GorevliIslemleri : Form
	{
		public GorevliIslemleri()
		{
			InitializeComponent();			
		}

		private void GorevliIslemleri_Load(object sender, EventArgs e)
		{
			label1.Text += GirişEkranı.kullanıcıAdı;
			label2.Text += DateTime.Today.Date.ToShortDateString();
		}

		private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			//Environment.Exit(0);
			GirişEkranı geriDon = new GirişEkranı();
			geriDon.Show();
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
				yavru.MdiParent = this;
				yavru.Show();
			}
		}

		private void yeniBiletToolStripMenuItem_Click(object sender, EventArgs e)
		{
			childform(new BiletSayfası());
		}

		private void biletSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			childform(new BiletSorgula());
		}

		private void biletİptaliToolStripMenuItem_Click(object sender, EventArgs e)
		{
			childform(new Biletİptali());
		}

		private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			childform(new SifreGüncelleme());
		}
	}
}
