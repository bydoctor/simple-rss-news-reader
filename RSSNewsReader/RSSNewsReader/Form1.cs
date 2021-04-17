using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSOkumaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
          List<Haber> kayitlar=  xmlCevir();
            lst_baslik.DataSource = kayitlar;
        }
        private List<Haber> xmlCevir()
        {
            List<Haber> haberKayitlari = new List<Haber>();
            XDocument XMLKaynak = XDocument.Load(txt_rssurl.Text);
            List<XElement> Rows = XMLKaynak.Descendants("item").ToList();
            foreach (var item in Rows)
            {
                Haber temp = new Haber();
                temp.Baslik = item.Element("title").Value;
                temp.Link = item.Element("link").Value;
                temp.Aciklama = item.Element("description").Value;
                haberKayitlari.Add(temp);

            }
            return haberKayitlari;

        }

        private void lst_baslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox secilenDeger = (ListBox)sender;
            Haber secilenHaber = (Haber)secilenDeger.SelectedItem;
            web_browser.DocumentText = secilenHaber.Aciklama;
        }
    }
}
