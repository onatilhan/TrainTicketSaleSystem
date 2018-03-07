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
	public partial class YöneticiEkle : Form
	{
		public YöneticiEkle()
		{
			InitializeComponent();
			Yoneticiİşlemleri.YoneticiBul();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!Yoneticiİşlemleri.managerNames.Contains(textBox1.Text))
			{
				if(textBox2.Text==textBox3.Text)
				{
					Yoneticiİşlemleri.yoneticiEkle(textBox1.Text, textBox2.Text);
				}
				else
				{
					MessageBox.Show("GİRİLEN ŞİFRELER AYNI OLMALIDIR!", "ŞİFRE HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
					textBox2.Text = "";
					textBox3.Text = "";
				}
			}
			else
			{
				MessageBox.Show("BU ID'YE SAHİP BİR YÖNETİCİ BULUNMAKTADIR!", "YÖNETİCİ ID HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
