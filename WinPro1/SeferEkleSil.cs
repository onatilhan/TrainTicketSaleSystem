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
	public partial class SeferEkleSil : Form
	{
		public SeferEkleSil()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (var db = new TrenBiletiSatisSistemiEntities6())
			{
				if (!db.Seferler.Any(sefer => sefer.Nerden == textBox1.Text && sefer.Nereye==textBox2.Text && sefer.Saati==textBox3.Text))
				{
					var yeniSefer = new Seferler()
					{
						Nerden = textBox1.Text,
						Nereye = textBox2.Text,
						Saati = textBox3.Text,
						Yetişkin_Fiyatı = textBox4.Text.ToString(),
						Cocuk_Fiyatı = textBox5.Text.ToString()
					};

					db.Seferler.Add(yeniSefer);
					db.SaveChanges();
					MessageBox.Show(textBox1.Text + " - " + textBox2.Text + " SEFERİ VERİ TABANINA EKLENMİŞTİR!", "SEFER EKLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);


					if (!db.Seferler.Any(sefer => sefer.Nerden == textBox2.Text && sefer.Nereye == textBox1.Text && sefer.Saati == textBox3.Text) && radioButton2.Checked && textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
					{
						var yeni2Sefer = new Seferler()
						{
							Nerden = textBox2.Text,
							Nereye = textBox1.Text,
							Saati = textBox3.Text,
							Yetişkin_Fiyatı = textBox4.Text.ToString(),
							Cocuk_Fiyatı = textBox5.Text.ToString()
						};

						db.Seferler.Add(yeni2Sefer);
						db.SaveChanges();
					}
					else if (radioButton2.Checked==true)
					{
						MessageBox.Show(textBox2.Text + " - " + textBox1.Text + " SEFERİ ZATEN VARDIR, " + textBox1.Text + " - " + textBox2.Text + " SEFERİ EKLENMİŞTİR!",
							"SEFER BULUNDU", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}

				}
				else
				{
					MessageBox.Show("BÖYLE BİR SEFER BULUNMAKTADIR!", "SEFER BULUNDU", MessageBoxButtons.OK, MessageBoxIcon.Error);
					textBox1.Text = "";
					textBox2.Text = "";
					textBox3.Text = "";
					textBox4.Text = "";
					textBox5.Text = "";

				}

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (var db = new TrenBiletiSatisSistemiEntities6())
			{
				var itemToRemove = db.Seferler.SingleOrDefault(x => x.Nerden == textBox6.Text && x.Nereye == textBox7.Text && x.Saati == textBox8.Text);
				if (itemToRemove != null)
				{
					db.Seferler.Remove(itemToRemove);
					db.SaveChanges();
					MessageBox.Show(textBox6.Text + " - " + textBox7.Text + " SEFERİ VERİ TABANINDAN SİLİNMİŞTİR!", "SEFER SİLİNDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				else
				{
					MessageBox.Show("BÖYLE BİR SEFER BULUNMAMAKTADIR!", "SEFER BULUNAMADI", MessageBoxButtons.OK, MessageBoxIcon.Error);
					textBox6.Text = "";
					textBox7.Text = "";
					textBox8.Text = "";
				}

			}
		}
	}
}
