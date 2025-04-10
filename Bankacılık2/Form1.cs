namespace Bankacılık2
{
    public partial class Form1 : Form
    {
        HesapBilgileri hesap = new HesapBilgileri();
        bool giris = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            KisiselBilgiler kisi = new KisiselBilgiler();
            string hesapBakiye = hesap.HesapToplami.ToString();
            string name = kisi.Ad;
            string surname = kisi.Soyad;
            string tcno = kisi.TcNo;


            kisi.Ad = textBox1.Text;
            kisi.Soyad = textBox2.Text;
            kisi.TcNo = textBox3.Text;
            if (kisi.Ad == name && kisi.Soyad == surname && kisi.TcNo == tcno)
            {
                MessageBox.Show("Kullanıcı Bilgileri Doğru.");
                label8.Text = hesapBakiye;
                giris = true;
            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileri Yanlış.");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (giris == true)
            {
                try
                {
                    if (hesap.HesapToplami > 0)
                    {
                        int paraTutari = Convert.ToInt32(textBox4.Text);
                        if (paraTutari > hesap.HesapToplami)
                        {
                            MessageBox.Show("Yetersiz Bakiye");

                        }
                        else
                        {
                            int paraMiktari = hesap.HesapToplami;
                            paraMiktari -= paraTutari;
                            label8.Text = Convert.ToString(paraMiktari);
                            hesap.HesapToplami = paraMiktari;
                        }
                    }
                    if (hesap.HesapToplami == 0)
                    {
                        MessageBox.Show("Hesabınızda Yeterli Miktarda Para Yok.");
                    }

                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Lütfen Doğru Formatta Değerler Giriniz.");

                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Lütfen Doğru Formatta Değerler Giriniz.");

                }
                if (!giris)
                {
                    MessageBox.Show("Lütfen Önce Kullanıcı Bİlgilerinizi Girin.");
                }

            }
        }
    }
}
