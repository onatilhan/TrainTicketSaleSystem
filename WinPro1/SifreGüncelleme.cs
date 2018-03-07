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
	public partial class SifreGüncelleme : Form
	{
		public SifreGüncelleme()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			using (var db = new TrenBiletiSatisSistemiEntities6())
			{
				GiseGorevlileri guncellenecekGorevli = db.GiseGorevlileri.SingleOrDefault(gorevli => gorevli.UserId.ToString() == textBox1.Text.ToString());

				if (db.GiseGorevlileri.Any(giseci => giseci.UserId == textBox1.Text.ToString()))
				{
					if (guncellenecekGorevli != null && guncellenecekGorevli.Password == textBox2.Text)
					{
						if (textBox3.Text == textBox4.Text)
						{
							guncellenecekGorevli.Password = textBox3.Text;
							db.SaveChanges();
							label6.Visible = true;
							pictureBox1.Visible = true;
						}
						else
						{
							textBox3.Text = "";
							textBox4.Text = "";
							MessageBox.Show("Girilen şifreler aynı değil!", "ŞİFRE HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						textBox2.Text = "";
						textBox3.Text = "";
						textBox4.Text = "";
						MessageBox.Show("Şifre hatalı girildi!", "ŞİFRE HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				else
				{
					MessageBox.Show(textBox1.Text + " kullanıcı adına sahip bir gişe görevlisi bulunmamaktadır!", "GİŞE GÖREVLİSİ BULUNMUYOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
