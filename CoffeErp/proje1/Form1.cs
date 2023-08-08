using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=vt1.mdb");

        public void masaKontrol()
        {
            bag.Open();

            for (int i = 1; i < 12; i++)
            {
                int masaNo = i;

                OleDbCommand komut1 = new OleDbCommand("SELECT FIYAT FROM masa" + masaNo, bag);
                OleDbDataReader reader1 = komut1.ExecuteReader();

                int toplam = 0;
                while (reader1.Read())
                {

                    toplam = toplam + int.Parse(reader1["FIYAT"].ToString());

                    if (toplam >= 125) //masanın borcunu yazdırdık
                    {
                        label6.Text = "Masa Ücret: ";
                        label3.Text = "25TL";

                        label7.Text = "TOPLAM: ";
                        label1.Text = (toplam + 25) + "TL";
                    }

                    else if (toplam == 0)
                    {
                        label6.Text = "Masa Ücret: ";
                        label3.Text = "";

                        label7.Text = "TOPLAM: ";
                        label1.Text = "";
                    }

                    else if (toplam <= 125)
                    {
                        label6.Text = "Masa Ücret: ";
                        label3.Text = "50TL";

                        label7.Text = "TOPLAM: ";
                        label1.Text = (toplam + 50) + "TL";
                    }
                    else
                    {
                        label6.Text = "Masa Ücret: ";
                        label3.Text = "";

                        label7.Text = "TOPLAM: ";
                        label1.Text = "";
                    }



                    if (toplam > 0) //masalarda ürün varsa rengi kırmızı olacak
                    {
                        switch (masaNo)
                        {
                            case 1:
                                button1.BackColor = Color.Red;
                                break;

                            case 2:
                                button2.BackColor = Color.Red;
                                break;

                            case 3:
                                button3.BackColor = Color.Red;
                                break;

                            case 4:
                                button4.BackColor = Color.Red;
                                break;

                            case 5:
                                button5.BackColor = Color.Red;
                                break;

                            case 6:
                                button6.BackColor = Color.Red;
                                break;

                            case 7:
                                button7.BackColor = Color.Red;
                                break;

                            case 8:
                                button8.BackColor = Color.Red;
                                break;

                            case 9:
                                button9.BackColor = Color.Red;
                                break;

                            case 10:
                                button10.BackColor = Color.Red;
                                break;

                            case 11:
                                button11.BackColor = Color.Red;
                                break;
                        }
                    }
                    else //masalarda ürün yoksa rengi yeşil olacak
                    {
                        switch (masaNo)
                        {
                            case 1:
                                button1.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 2:
                                button2.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 3:
                                button3.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 4:
                                button4.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 5:
                                button5.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 6:
                                button6.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 7:
                                button7.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 8:
                                button8.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 9:
                                button9.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 10:
                                button10.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 11:
                                button11.BackColor = Color.FromArgb(128, 255, 128);
                                break;
                        }
                    }

                }
            }
            bag.Close();
        }
        public void adisyonGoruntule(int masaNo)
        {

            //masa adisyonunu görüntüledik            
            listView1.Items.Clear();
            bag.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM masa" + masaNo, bag);
            OleDbDataReader reader = komut.ExecuteReader();

            

            while (reader.Read())
            {
                int count = listView1.Items.Count;

                listView1.Items.Add(reader["URUNADI"].ToString());
                listView1.Items[count].SubItems.Add(reader["MIKTAR"].ToString());
                listView1.Items[count].SubItems.Add(reader["FIYAT"].ToString() + "TL");

                

            }

            OleDbCommand komut1 = new OleDbCommand("SELECT FIYAT FROM masa"+masaNo,bag);
            OleDbDataReader reader1 = komut1.ExecuteReader();

            if (listView1.Items.Count == 0)
            {
                label6.Text = "Masa Ücret: ";
                label3.Text = "";

                label7.Text = "TOPLAM: ";
                label1.Text = "";

                switch (masaNo)
                {
                    case 1:
                        button1.BackColor = Color.FromArgb(128, 255, 128);
                        break;

                    case 2:
                        button2.BackColor = Color.FromArgb(128, 255, 128);
                        break;

                    case 3:
                        button3.BackColor = Color.FromArgb(128, 255, 128);
                        break;

                    case 4:
                        button4.BackColor = Color.FromArgb(128, 255, 128);
                        break;

                    case 5:
                        button5.BackColor = Color.FromArgb(128, 255, 128);
                        break;

                    case 6:
                        button6.BackColor = Color.FromArgb(128, 255, 128);
                        break;

                    case 7:
                        button7.BackColor = Color.FromArgb(128, 255, 128);
                        break;

                    case 8:
                        button8.BackColor = Color.FromArgb(128, 255, 128);
                        break;

                    case 9:
                        button9.BackColor = Color.FromArgb(128, 255, 128);
                        break;

                    case 10:
                        button10.BackColor = Color.FromArgb(128, 255, 128);
                        break;

                    case 11:
                        button11.BackColor = Color.FromArgb(128, 255, 128);
                        break;
                }

            }
            else
            {
                int toplam = 0;
                while (reader1.Read())
                {

                    toplam = toplam + int.Parse(reader1["FIYAT"].ToString());

                    if (toplam >= 125) //masanın borcunu yazdırdık
                    {
                        label6.Text = "Masa Ücret: ";
                        label3.Text = "25TL";

                        label7.Text = "TOPLAM: ";
                        label1.Text = (toplam + 25) + "TL";
                    }

                    else if (toplam == 0)
                    {
                        label6.Text = "Masa Ücret: ";
                        label3.Text = "";

                        label7.Text = "TOPLAM: ";
                        label1.Text = "";
                    }

                    else if (toplam <= 125)
                    {
                        label6.Text = "Masa Ücret: ";
                        label3.Text = "50TL";

                        label7.Text = "TOPLAM: ";
                        label1.Text = (toplam + 50) + "TL";
                    }
                    else
                    {
                        label6.Text = "Masa Ücret: ";
                        label3.Text = "";

                        label7.Text = "TOPLAM: ";
                        label1.Text = "";
                    }


                    if (toplam > 0) //masalarda ürün varsa rengi kırmızı olacak
                    {
                        switch (masaNo)
                        {
                            case 1:
                                button1.BackColor = Color.Red;
                                break;

                            case 2:
                                button2.BackColor = Color.Red;
                                break;

                            case 3:
                                button3.BackColor = Color.Red;
                                break;

                            case 4:
                                button4.BackColor = Color.Red;
                                break;

                            case 5:
                                button5.BackColor = Color.Red;
                                break;

                            case 6:
                                button6.BackColor = Color.Red;
                                break;

                            case 7:
                                button7.BackColor = Color.Red;
                                break;

                            case 8:
                                button8.BackColor = Color.Red;
                                break;

                            case 9:
                                button9.BackColor = Color.Red;
                                break;

                            case 10:
                                button10.BackColor = Color.Red;
                                break;

                            case 11:
                                button11.BackColor = Color.Red;
                                break;
                        }
                    }
                    else //masalarda ürün yoksa rengi yeşil olacak
                    {
                        switch (masaNo)
                        {
                            case 1:
                                button1.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 2:
                                button2.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 3:
                                button3.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 4:
                                button4.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 5:
                                button5.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 6:
                                button6.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 7:
                                button7.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 8:
                                button8.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 9:
                                button9.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 10:
                                button10.BackColor = Color.FromArgb(128, 255, 128);
                                break;

                            case 11:
                                button11.BackColor = Color.FromArgb(128, 255, 128);
                                break;
                        }
                    }

                }
            }

            

            bag.Close();

        }
        public void masaButonTikla(int masaNo)
        {
            label1.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            //groupbox1 görünür yapılacak
            groupBox1.Visible = true;
            groupBox2.Text = "MASA " + masaNo;

            label6.Text = "Masa Ücret: ";
            label3.Text = "";

            label7.Text = "TOPLAM: ";
            label1.Text = "";

            adisyonGoruntule(masaNo);

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;

        }

        public void masaKapat(string masaNo)
        {
            label1.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            bag.Open();

            if ( label1.Text != "")
            {
                
                string fiyat = label1.Text.Remove(label1.Text.Count()-2,2);

                OleDbCommand komut1 = new OleDbCommand("insert into tblCiro (MASA,FIYAT) values(@masano, @fiyat)", bag);

                komut1.Parameters.AddWithValue("@masano", masaNo);
                komut1.Parameters.AddWithValue("@fiyat", fiyat);
                komut1.ExecuteNonQuery();
                komut1.Dispose();

                

            }

            OleDbCommand komut = new OleDbCommand("DELETE FROM " + masaNo, bag);
            komut.ExecuteNonQuery();
            komut.Dispose();

            bag.Close();

            listView1.Items.Clear();
            groupBox2.Text = "";

            label4.Text = "";
            label5.Text = "";

            switch (masaNo) //kapatılan masanın rengini yeşil yapar
            {
                case "masa1":
                    button1.BackColor = Color.FromArgb(128, 255, 128);
                    break;

                case "masa2":
                    button2.BackColor = Color.FromArgb(128, 255, 128);
                    break;

                case "masa3":
                    button3.BackColor = Color.FromArgb(128, 255, 128);
                    break;

                case "masa4":
                    button4.BackColor = Color.FromArgb(128, 255, 128);
                    break;

                case "masa5":
                    button5.BackColor = Color.FromArgb(128, 255, 128);
                    break;

                case "masa6":
                    button6.BackColor = Color.FromArgb(128, 255, 128);
                    break;

                case "masa7":
                    button7.BackColor = Color.FromArgb(128, 255, 128);
                    break;

                case "masa8":
                    button8.BackColor = Color.FromArgb(128, 255, 128);
                    break;

                case "masa9":
                    button9.BackColor = Color.FromArgb(128, 255, 128);
                    break;

                case "masa10":
                    button10.BackColor = Color.FromArgb(128, 255, 128);
                    break;

                case "masa11":
                    button11.BackColor = Color.FromArgb(128, 255, 128);
                    break;
            }

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;

        }

        public void urunSecVeEkle(string masaIsmi)
        {
            
            if (label4.Text != "" && label5.Text != "")
            {
                string URUNADI = label4.Text;
                int miktar = int.Parse(label5.Text);

                bool varMi = false;

                //ürün var mı yokmu konrol ediyoruz
                for (int i = 0; i < listView1.Items.Count; i++)
                {

                    string bas = (listView1.Items[i]).ToString().Remove(0, 15);
                    string urun = ((listView1.Items[i]).ToString().Remove(0, 15).Remove(bas.Length - 1, 1));

                    if (URUNADI == urun)
                    {
                        varMi = true;
                        break;
                    }

                }
                //masada ürün yoksa ürünü ekle
                if (varMi == false) 
                {

                    if (miktar > 0)
                    {
                        bag.Open();

                        OleDbCommand komut1 = new OleDbCommand("SELECT FIYAT FROM tblUrunler WHERE URUNADI='" + URUNADI + "'", bag);
                        OleDbDataReader reader = komut1.ExecuteReader();

                        string fiyatStr = "";
                        while (reader.Read())
                        {

                            fiyatStr = (int.Parse(reader["FIYAT"].ToString()) * miktar).ToString();

                        }
                        int fiyat = int.Parse(fiyatStr);

                        OleDbCommand komut = new OleDbCommand("insert into " + masaIsmi + " (URUNADI,MIKTAR,FIYAT) values(@urunadi, @miktar, @fiyat)", bag);

                        komut.Parameters.AddWithValue("@urunadi", URUNADI);
                        komut.Parameters.AddWithValue("@miktar", miktar);
                        komut.Parameters.AddWithValue("@fiyat", fiyat);
                        komut.ExecuteNonQuery();
                        komut.Dispose();

                        bag.Close();
                    }
                    else
                    {
                        MessageBox.Show("Miktar sıfırdan büyük olmalı!");
                    }

                    

                }
                //masada ürün varsa ve miktar sıfırdan büyük değilse ürün miktarını azalt veya arttır
                else
                {

                    if (miktar < 0) //azaltma işlemi
                    { 

                        bag.Open();

                        //ürünün tekil fiyatını bulma
                        OleDbCommand komut1 = new OleDbCommand("SELECT FIYAT FROM tblUrunler WHERE URUNADI='" + URUNADI + "'", bag);
                        OleDbDataReader reader = komut1.ExecuteReader();

                        string tekilFiyatStr = "";
                        while (reader.Read())
                        {

                            tekilFiyatStr = (int.Parse(reader["FIYAT"].ToString()) * miktar).ToString();

                        }
                        int tekilFiyat = int.Parse(tekilFiyatStr);

                        //ürünün masadaki toplam ücretini bulma
                        OleDbCommand komut = new OleDbCommand("SELECT * FROM "+masaIsmi+" WHERE URUNADI='"+URUNADI+"'",bag);
                        OleDbDataReader reader1 = komut.ExecuteReader();

                        string toplamFiyatStr = "";
                        string toplamMiktarStr = "";
                        while (reader1.Read())
                        {
                            toplamFiyatStr = reader1["FIYAT"].ToString();
                            toplamMiktarStr = reader1["MIKTAR"].ToString();
                            
                        }
                        int toplamFiyat = int.Parse(toplamFiyatStr);
                        int toplamMiktar = int.Parse(toplamMiktarStr);

                        toplamFiyat = toplamFiyat + tekilFiyat;
                        toplamMiktar = toplamMiktar + miktar;

                        if (toplamMiktar > 0 || toplamFiyat > 0)
                        {
                            //miktarı ve fiyatı azaltma işlemi
                            OleDbCommand komut2 = new OleDbCommand("UPDATE " + masaIsmi + " SET MIKTAR='" + toplamMiktar + "', FIYAT='" + toplamFiyat + "' WHERE URUNADI='" + URUNADI + "'", bag);
                            komut2.ExecuteNonQuery();
                            komut2.Dispose();
                        }
                        else
                        {
                            //ürünü tablodan silme işlemi
                            OleDbCommand komut3 = new OleDbCommand("DELETE FROM "+masaIsmi+" WHERE URUNADI= '"+URUNADI+"'",bag);
                            komut3.ExecuteNonQuery();
                            komut3.Dispose();


                        }


                        bag.Close();
                    }
                    else if(miktar > 0) //arttırma işlemi
                    {

                        bag.Open();

                        //ürünün tekil fiyatını bulma
                        OleDbCommand komut1 = new OleDbCommand("SELECT FIYAT FROM tblUrunler WHERE URUNADI='" + URUNADI + "'", bag);
                        OleDbDataReader reader = komut1.ExecuteReader();

                        string tekilFiyatStr = "";
                        while (reader.Read())
                        {

                            tekilFiyatStr = (int.Parse(reader["FIYAT"].ToString()) * miktar).ToString();

                        }
                        int tekilFiyat = int.Parse(tekilFiyatStr);

                        //ürünün masadaki toplam ücretini bulma
                        OleDbCommand komut = new OleDbCommand("SELECT * FROM " + masaIsmi + " WHERE URUNADI='" + URUNADI + "'", bag);
                        OleDbDataReader reader1 = komut.ExecuteReader();

                        string toplamFiyatStr = "";
                        string toplamMiktarStr = "";
                        while (reader1.Read())
                        {
                            toplamFiyatStr = reader1["FIYAT"].ToString();
                            toplamMiktarStr = reader1["MIKTAR"].ToString();

                        }
                        int toplamFiyat = int.Parse(toplamFiyatStr);
                        int toplamMiktar = int.Parse(toplamMiktarStr);

                        toplamFiyat = toplamFiyat + tekilFiyat;
                        toplamMiktar = toplamMiktar + miktar;

                        OleDbCommand komut2 = new OleDbCommand("UPDATE " + masaIsmi + " SET MIKTAR='" + toplamMiktar + "', FIYAT='" + toplamFiyat + "' WHERE URUNADI='" + URUNADI + "'", bag);
                        komut2.ExecuteNonQuery();
                        komut2.Dispose();

                        bag.Close();

                    }

                }

            }
            string masaNoStr = (masaIsmi.ToLower()).Remove(0, 4);
            int masaNo = Int32.Parse(masaNoStr);

            adisyonGoruntule(masaNo);

            label4.Text = "";
            label5.Text = "";
            
        }

        public void menuleriAc()
        {

            //groupbox1 içindeki listboxlar'a menüler yazdırılacak
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            try
            {
                bag.Open();

                OleDbCommand komut = new OleDbCommand("SELECT AD FROM tblSicaklar", bag);
                OleDbDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {

                    listBox1.Items.Add(reader.GetString(0));

                }

                OleDbCommand komut1 = new OleDbCommand("SELECT AD FROM tblSoguklar", bag);
                OleDbDataReader reader1 = komut1.ExecuteReader();
                while (reader1.Read())
                {

                    listBox2.Items.Add(reader1.GetString(0));

                }

                OleDbCommand komut2 = new OleDbCommand("SELECT AD FROM tblYemekler", bag);
                OleDbDataReader reader2 = komut2.ExecuteReader();
                while (reader2.Read())
                {

                    listBox3.Items.Add(reader2.GetString(0));

                }

                OleDbCommand komut3 = new OleDbCommand("SELECT AD FROM tblNargileler", bag);
                OleDbDataReader reader3 = komut3.ExecuteReader();
                while (reader3.Read())
                {

                    listBox4.Items.Add(reader3.GetString(0));

                }

                bag.Close();

            }
            catch (Exception hata)
            {
                if (bag.State == ConnectionState.Open)
                    bag.Close();
                MessageBox.Show(hata.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            masaKontrol();
            menuleriAc();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            masaButonTikla(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            masaButonTikla(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            masaButonTikla(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            masaButonTikla(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            masaButonTikla(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            masaButonTikla(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            masaButonTikla(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            masaButonTikla(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            masaButonTikla(9);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            masaButonTikla(10);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            masaButonTikla(11);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (groupBox2.Text != "")
            {
                string masaIsmi = (groupBox2.Text.ToLower()).Remove(4, 1);
                urunSecVeEkle(masaIsmi);

            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (groupBox2.Text != "")
            {
                string masaNo = (groupBox2.Text.ToLower()).Remove(4, 1);
                masaKapat(masaNo);
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label4.Text = listBox1.SelectedItem.ToString();
            label5.Text = "0";
        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            label4.Text = listBox2.SelectedItem.ToString();
            label5.Text = "0";
        }

        private void listBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            label4.Text = listBox3.SelectedItem.ToString();
            label5.Text = "0";
        }

        private void listBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            label4.Text = listBox4.SelectedItem.ToString();
            label5.Text = "0";
        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label5.Text != "") //miktar kısmı boş değilse
            {

                int miktar = Int32.Parse(label5.Text);
                miktar++;
                label5.Text = miktar.ToString();

            }
            else // miktar kısmı boşsa
            { }

        }
        private void button16_Click(object sender, EventArgs e)
        {

            if (label5.Text != "") //miktar kısmı boş değilse
            {

                int miktar = Int32.Parse(label5.Text);
                miktar--;
                label5.Text = miktar.ToString();

            }
            else // miktar kısmı boşsa
            { }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bag.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM tblCiro",bag);
            DataTable tablo = new DataTable();
            OleDbDataReader reader = komut.ExecuteReader();
            tablo.Load(reader);
            dataGridView1.DataSource= tablo;

            bag.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("'Günlük Ciro' tablosunu sıfırlamak istediğinize emin misiniz?\n",
                "DİKKAT!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                DialogResult result2 = MessageBox.Show("Kaybolan veriler geri alınamaz.\nEmin misiniz?",
                    "DİKKAT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result2 == DialogResult.Yes)
                {

                    bag.Open();

                    OleDbCommand komut1 = new OleDbCommand("DELETE FROM tblCiro", bag);
                    komut1.ExecuteNonQuery();
                    komut1.Dispose();

                    OleDbCommand komut = new OleDbCommand("SELECT * FROM tblCiro", bag);
                    DataTable tablo = new DataTable();
                    OleDbDataReader reader = komut.ExecuteReader();
                    tablo.Load(reader);
                    dataGridView1.DataSource = tablo;

                    bag.Close();

                }

            }

            
        }
    }
}
