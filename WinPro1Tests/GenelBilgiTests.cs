using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinPro1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace WinPro1.Tests
{
	[TestClass()]
	public class GenelBilgiTests
	{
		[TestMethod()]
		public void CiroTest()
		{
			object sender = null;
			EventArgs e = new EventArgs();
			GenelBilgi test = new GenelBilgi();
			int ciro = 0;

			SqlConnection Conn = new SqlConnection("Server=LENOVO; database=TrenBiletiSatisSistemi; Trusted_Connection=True");
			SqlCommand Comm = new SqlCommand("SELECT Tutar  FROM Biletler", Conn);
			Conn.Open();
			SqlDataReader DR = Comm.ExecuteReader();

			while(DR.Read())
			{
				ciro += DR.GetInt32(0);
			}
			test.GenelBilgi_Load(sender, e);

			Assert.AreEqual(test.genelToplam, ciro);
		}

		[TestMethod()]
		public void XmlYöneticiKontrolüTesti()
		{
			bool kontrol = false;
		    string mainDirectoryPath = @"C:\Users\Z50\source\repos\WinPro1\WinPro1";
			string managerPath = Path.Combine(mainDirectoryPath, "YoneticiXml.xml");
			string xmlFile = File.ReadAllText(managerPath);
			XmlDocument xmldoc = new XmlDocument();
			xmldoc.LoadXml(xmlFile);
			XmlNodeList nodeUserNameList = xmldoc.GetElementsByTagName("KullaniciAdi");
			XmlNodeList nodeUserPassList = xmldoc.GetElementsByTagName("Sifresi");

			//string userName = string.Empty;

			foreach (XmlNode node in nodeUserNameList)
			{
				if (node.InnerText == "onatilhan")
					kontrol = true;
			}
		
			Assert.IsTrue(kontrol);

		}
	}
}