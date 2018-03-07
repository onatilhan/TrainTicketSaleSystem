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
	public partial class Biletİptali : Form
	{
		public Biletİptali()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var isNumeric = Int32.TryParse(textBox1.Text, out var n);
			if(isNumeric)
			{
				int biletNum = Convert.ToInt32(textBox1.Text);
				using (var db = new TrenBiletiSatisSistemiEntities6())
				{
					var ticketToRemove = db.Biletler.SingleOrDefault(x => x.BiletNumarasi == biletNum);
					if (ticketToRemove != null)
					{
						db.Biletler.Remove(ticketToRemove);
						db.SaveChanges();
						MessageBox.Show(ticketToRemove.BiletNumarasi+" NUMARALI, "+ticketToRemove.Musteri_Adı+" ADINA KESİLMİŞ BİLET İPTAL EDİLMİŞTİR!", "BİLET İPTAL EDİLDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
					else
					{
						MessageBox.Show("BU BİLET NUMARASINA SAHİP BİR BİLET BULUNMAMAKTADIR!", "BİLET NUMARASI HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
						textBox1.Text = "";
					}

				}
			}
			else
			{
				MessageBox.Show("LÜTFEN BİLET NUMARASINI SAYISAL BİR DEĞER GİRİNİZ!", "BİLET NUMARASI HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBox1.Text = "";
			}
			
		}
	}
}
