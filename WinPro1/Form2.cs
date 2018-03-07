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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			using (var db = new TrenBiletiSatisSistemiEntities6())
			{
				if (!db.GiseGorevlileri.Any(gorevli => gorevli.UserId == userTxtBox.Text))
				{
					if(passTxtBox.Text==textBox2.Text)
					{
						var yeniGorevli = new GiseGorevlileri()
						{
							UserId = userTxtBox.Text,
							Password = passTxtBox.Text,
							Görevli_Ismi = textBox1.Text
						};

						db.GiseGorevlileri.Add(yeniGorevli);
						db.SaveChanges();
						label4.Visible = true;
					}else
					{
						MessageBox.Show("GİRİLEN ŞİFRELER AYNI OLMALIDIR!", "ŞİFRE HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						passTxtBox.Text = "";
						textBox2.Text = "";
					}
					
				}
				else
				{
					label3.Visible = true;
					userTxtBox.Text="";
					passTxtBox.Text="";
				}

			}
		}

		private void userTxtBox_TextChanged(object sender, EventArgs e)
		{
			label3.Visible = false;
			label4.Visible = false;
		}
	}
}
