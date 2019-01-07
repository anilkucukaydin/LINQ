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
    public partial class Form1 : Form
    {
        int[] sayilar = { 9, -4, 56, -28, 0 };
        List<string> isimler = new List<string>();
        public Form1()
        {
            InitializeComponent();
            isimler.Add("Doğan");
            isimler.Add("Furkan");
            isimler.Add("Anıl");
            isimler.Add("Buğra");
            isimler.Add("Nazım");
            isimler.Add("Nedim");
        }

        private void sayilar_tumsayilar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.ToList();
        }

        private void sayilar_negatif_Click(object sender, EventArgs e)
        {
            //lambda expression
            IEnumerable<int> n = sayilar.Where(birsey => birsey < 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void sayilar_pozitif_Click(object sender, EventArgs e)
        {
            //bunu yazarken sayı öyleki anlamı var 
            IEnumerable<int> p = sayilar.Where(sayi => sayi > 0);
            listBox1.DataSource = null;
            listBox1.DataSource = p.ToList();
        }

        private void sayilar_cift_Click(object sender, EventArgs e)
        {
            IEnumerable<int> c = sayilar.Where(sayi => sayi % 2 == 0);
            listBox1.DataSource = null;
            listBox1.DataSource = c.ToList();
        }

        private void sayilar_tek_Click(object sender, EventArgs e)
        {
            IEnumerable<int> c = sayilar.Where(sayi => sayi % 2 == 1 || sayi % 2 == -1);
            listBox1.DataSource = null;
            listBox1.DataSource = c.ToList();
        }

        private void sayilar_enbuyuk_Click(object sender, EventArgs e)
        {
            int enbuyuksayi = sayilar.Max();
            MessageBox.Show(enbuyuksayi.ToString());
        }

        private void sayilar_enkucuk_Click(object sender, EventArgs e)
        {
            int enkucuksayi = sayilar.Min();
            MessageBox.Show(enkucuksayi.ToString());
        }

        private void sayilar_kactane_Click(object sender, EventArgs e)
        {
            int kactanesayivar = sayilar.Length;
            int kactanesayivar2 = sayilar.Count();
            MessageBox.Show(kactanesayivar.ToString());
        }

        private void isimler_alfabetik_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            // IOrderedEnumerable<string> sirali = isimler.OrderBy(x => x);
            listBox1.DataSource = isimler.OrderBy(x => x).ToList();
            //ToList() -> List<string>
        }

        private void isimler_tersalfabetik_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.OrderByDescending(x => x).ToList();
        }

        private void isimler_uzunluk_Click(object sender, EventArgs e)
        {
            List<string> liste = new List<string>();
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Select(x => x.Length).ToList();
        }

        private void isimler_iBarindiran_Click(object sender, EventArgs e)
        {

            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x => x.Contains("d")).ToList();
        }

        private void isimler_N_ilebaslayanlar_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x => x.StartsWith("N")).ToList();
        }

        private void siparisler_tarih_Click(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Order.GetDataTable("SELECT OrderDate FROM Orders");
        }

        private void siparisler_ilk5_Click(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Order.GetDataTable("SELECT TOP 5* FROM Orders");
        }

        private void siparisler_hepsi_Click(object sender, EventArgs e)
        {
            List<Order> orders = new List<Order>();
            var gorunen = orders.Select(satir => new {SiparisNo=satir.OrderID, Tarih = satir.OrderDate,Musteri =satir.Customer.ContactName });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.ToList();
        }

        private void siparisler_son5_Click(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.OrderByDescending(x => x.OrderID).Take(5).Select(x => new
            {
                x.OrderID,
                x.Customer.ContactName,
                x.OrderDate
            }).ToList();
           
        }

        private void yangwang_Click(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrders();
            var filter = orders.Where(x => x.Customer.ContactName == "Yang Wang").ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filter;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Order> orders = Order.GetOrders();
            int sayi = orders.Count;
        }
    }
}
