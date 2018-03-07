using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace WinPro1
{

	class Yoneticiİşlemleri
	{
		private static string mainDirectoryPath = @"C:\Users\Z50\source\repos\WinPro1\WinPro1";
		private static string managerPath = Path.Combine(mainDirectoryPath, "YoneticiXml.xml");

		public static List<string> managerNames = new List<string>();
		public static List<string> managerPasswords = new List<string>();


		public static void KlasorYarat()
		{
			if (!Directory.Exists(mainDirectoryPath))
				Directory.CreateDirectory(mainDirectoryPath);
		}

		public static void MenuDosyaYarat()
		{
			KlasorYarat();
			if (!File.Exists(managerPath))
			{
				var file = File.Create(managerPath);
				file.Close();
			}
		}
		public static void yoneticiEkle(string kullanıcıID,string kullanıcıSifre)
		{
			XDocument doc = XDocument.Load(managerPath);
			XElement root = new XElement("Yönetici");
			root.Add(new XElement("KullaniciAdi", kullanıcıID));
			root.Add(new XElement("Sifresi", kullanıcıSifre));
			doc.Element("Yöneticiler").Add(root);
			doc.Save(managerPath);
		}

		public static void YoneticiBul()
		{
			string xmlFile = File.ReadAllText(managerPath);
			XmlDocument xmldoc = new XmlDocument();
			xmldoc.LoadXml(xmlFile);
			XmlNodeList nodeUserNameList = xmldoc.GetElementsByTagName("KullaniciAdi");
			XmlNodeList nodeUserPassList = xmldoc.GetElementsByTagName("Sifresi");

			foreach (XmlNode node in nodeUserNameList)
			{ 
				managerNames.Add(node.InnerText);
			}

			foreach (XmlNode node in nodeUserPassList)
			{
				managerPasswords.Add(node.InnerText);
			}

		}
	}
}
