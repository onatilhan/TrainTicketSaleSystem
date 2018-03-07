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
	public partial class SeferGörüntüle : Form
	{
		public SeferGörüntüle()
		{
			InitializeComponent();
		}

		private void SeferGörüntüle_Load(object sender, EventArgs e)
		{
			SqlConnection Conn = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm1 = new SqlCommand("SELECT * FROM Seferler", Conn);
			Conn.Open();
			SqlDataReader DR1 = Comm1.ExecuteReader();
			while (DR1.Read())
			{
				string[] row = new string[] { DR1.GetString(0), DR1.GetString(1), DR1.GetString(2), DR1.GetString(3), DR1.GetString(4) };
				dataGridView1.Rows.Add(row);
			}
		}
	}
}
