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
	public partial class TümBiletler : Form
	{
		public TümBiletler()
		{
			InitializeComponent();
		}

		private void TümBiletler_Load(object sender, EventArgs e)
		{
			/*//int indis = dataGridView1.Rows.Add();
			//indis = 0;
			SqlConnection Conn = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlDataAdapter biletler = new SqlDataAdapter("SELECT * FROM Biletler", Conn);
			DataSet ds = new DataSet();
			biletler.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];		Conn.Close();*/

			SqlConnection Conn = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm1 = new SqlCommand("SELECT * FROM Biletler", Conn);
			Conn.Open();
			SqlDataReader DR1 = Comm1.ExecuteReader();
			while(DR1.Read())
			{
				this.dataGridView1.Rows.Add(DR1.GetInt32(0).ToString(),DR1.GetString(1), DR1.GetString(2), DR1.GetString(3), DR1.GetString(4), DR1.GetInt32(5).ToString(), 
					DR1.GetInt32(6).ToString(), DR1.GetString(7), DR1.GetString(8), DR1.GetString(9), DR1.GetInt32(10).ToString(), DR1.GetInt32(11).ToString(), DR1.GetString(12), DR1.GetString(13));
			}
		}
	}
}
