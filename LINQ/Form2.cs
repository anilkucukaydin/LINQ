using LINQ.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form2 : Form
        
    {
        List<Personel> liste = new List<Personel>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liste.Add(new Personel());
            string psayisi = liste.Count.ToString();
            lbl_personelsayi.Text = Resources.sablon1.Replace("0", psayisi);
            string ort = liste.Average(x => x.Maas).ToString("C"); //("C") tl cinsinden gösteriyor kuruşuyla berber 
            lbl_personelmaasortalama.Text = Resources.sablon2.Replace("0", ort);
            liste.Last();
            Personel sonkisi = liste.Last();
            lbl_maas.Text = Resources.sablon4.Replace("0", sonkisi.Maas.ToString());
            lbl_personelyas.Text = Resources.sablon3.Replace("0", sonkisi.Yas.ToString());

            
        }
    }
}
