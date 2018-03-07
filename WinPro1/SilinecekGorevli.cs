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
	public partial class SilinecekGorevli : Form
	{
		public SilinecekGorevli()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label2.Visible = false;
			using (var db = new TrenBiletiSatisSistemiEntities6())
			{
				var itemToRemove = db.GiseGorevlileri.SingleOrDefault(x => x.UserId == textBox1.Text);
				if (itemToRemove != null)
				{
					db.GiseGorevlileri.Remove(itemToRemove);
					db.SaveChanges();
					label2.Visible = true;
				}else
				{
					MessageBox.Show("BU KULLANICI ADINA SAHİP GİŞE GÖREVLİSİ BULUNMAMAKTADIR!", "KULLANICI ADI HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
					textBox1.Text = "";
				}

			}
		}
	}
}
