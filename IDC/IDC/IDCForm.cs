using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace IDC
{
    
    public partial class IDCForm : Form
    {
        public string görev { get; set; }
        public string hedef { get; set; }
        public int fark { get; set; }
        public IDCForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //apikey = 12804071d788957
            //apiurl = https://api.ocr.space/parse/imageurl?apikey=12804071d788957&url=xxx&language=tur
            var görevyol = "https://api.ocr.space/parse/imageurl?apikey=12804071d788957&url=" + textBox1.Text + "&language=tur";
            var json1 = function._indir_jason_dosya<RootObject>(görevyol);
            if (json1.OCRExitCode == 1)
            {
                for (int i = 0; i < json1.ParsedResults.Count(); i++)
                {

                    görev = görev + json1.ParsedResults[i].ParsedText;
                }
                MessageBox.Show(görev);

            }

            else
            {
                MessageBox.Show("Hata");
            }
            string hedefyol = "https://api.ocr.space/parse/imageurl?apikey=12804071d788957&url=" + textBox2.Text + "&language=tur";
            var json2 = function._indir_jason_dosya<RootObject>(hedefyol);
            if (json2.OCRExitCode == 1)
            {
                for (int i = 0; i < json1.ParsedResults.Count(); i++)
                {
                    hedef = hedef + json2.ParsedResults[i].ParsedText;
                }
                MessageBox.Show(hedef);
            }
            fark = function.FarkHesapla(string.Concat(görev.Where(c => !char.IsWhiteSpace(c))), string.Concat(hedef.Where(c => !char.IsWhiteSpace(c))));
            if (fark < 5)
            {
                MessageBox.Show("İki text benzer, farklı olan kelime sayısı: " + Convert.ToString(fark));
            }
            
        }

    

        private void IDCForm_Load(object sender, EventArgs e)
        {

        }
    }
}
