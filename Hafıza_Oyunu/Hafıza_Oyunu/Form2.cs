using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafıza_Oyunu
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            InitializeTimer();
            InitializeTimer2();
            InitializeTimer3();
            InitializeTimer4();
        }


        private void InitializeTimer4()
        {
            timer4 = new System.Windows.Forms.Timer();
            timer4.Interval = 1000;
            timer4.Tick += Timer_Tick4;
        }//şuan kullanılmıyor
        public void InitializeTimer3()
        {
            timer3 = new System.Windows.Forms.Timer();
            timer3.Interval = 1000;
            timer3.Tick += Timer_Tick3;
        }

        private void InitializeTimer2()
        {
            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 1000;
            timer2.Tick += Timer_Tick2;
        }
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }
        private void StopTimer()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose(); // Timer'ı temizle
                InitializeTimer();// Timer'ı yeniden oluştur
                kalanSure = 5;
            }
        }
        private void StopTimer3()
        {
            if (timer3 != null)
            {
                timer3.Stop();
                timer3.Dispose();
                InitializeTimer3();
                kitle = 2;
            }
        }

        int oyuncu1 = 0;
        int oyuncu2 = 0;
        PictureBox chosen1;
        PictureBox chosen2;
        public bool sıra = true;
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<string> resimListesi = new List<string>();
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private int kitle = 2;
        private int kalanSure = 5;
        private int ilksure = 5;
        private bool izin = false;
        static string kk = Path.Combine(Application.StartupPath, "Kayıt");
        static string kapalıresim = Path.Combine(kk, "#.png");
        public bool ilk=true;
        public void BoxBagla()
        {
            foreach (Control pb in GBP.Controls)
            {
                pictureBoxes.Add((PictureBox)pb);
                pb.Click += All_Click;
            }
        }
        public void ResimAyarları()
        {

            string klasorYolu = Path.Combine(Application.StartupPath, "Images");
            resimListesi = ResimDosyalariniGetir(klasorYolu);
            if (resimListesi.Count < 10) { MessageBox.Show("Hata: ", "Images Klasöründe Yeterli Resim Yok"); this.Close(); }
            resimListesi = ResimleriSec();
        }

        public List<string> ResimleriSec()
        {
            List<string> kopyaListe = resimListesi;
            List<string> sonucListe = new List<string>();
            Random random = new Random();

            while (sonucListe.Count < 20)
            {
                int rastgele = random.Next(kopyaListe.Count);
                sonucListe.Add(kopyaListe[rastgele]);
                sonucListe.Add(kopyaListe[rastgele]);
                kopyaListe.RemoveAt(rastgele);
            }

            sonucListe = ResimleriKaristir(sonucListe);


            return sonucListe;
        }

        public List<string> ResimleriKaristir(List<string> sonuc)
        {
            Random random = new Random();

            for (int i = sonuc.Count - 1; i > 0; i--)
            {
                int rastgele = random.Next(i + 1);
                string gecici = sonuc[i];
                sonuc[i] = sonuc[rastgele];
                sonuc[rastgele] = gecici;
            }

            return sonuc;
        }
        public List<string> ResimDosyalariniGetir(string klasorYolu)
        {
            try
            {
                // Klasördeki tüm dosyaları al, sadece resim dosyalarını filtrele
                string[] dosyaListesi = Directory.GetFiles(klasorYolu);
                List<string> resimListesi = dosyaListesi
                    .Where(dosya => dosya.ToLower().EndsWith(".jpg") || dosya.ToLower().EndsWith(".png") || dosya.ToLower().EndsWith(".bmp"))
                    .ToList();

                return resimListesi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : ", "Resim Dosyalarına Ulaşılırken bir hata oluştu Lütfen tekrar deneyin");
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
                return new List<string>();
            }
        }

        public void ResimleriAta()
        {
           
            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                pictureBoxes[i].Tag = resimListesi[i];
                if(ilk)pictureBoxes[i].ImageLocation = resimListesi[i];
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                
            }ilk =false;
        }
        
     
        public void PuanKontrol()
        {
            if (oyuncu1 > 5 || oyuncu2 > 5 || (oyuncu1 == 5 && oyuncu2 == 5))
            {
                string mesaj = "Sanırım Bir Hata Oluştu";
                if (oyuncu1 == 5 && oyuncu2 == 5) mesaj = "Oyun berabere Dostluk Kazandı. Birlikte ortak bir kurabiye alın ve onu bölüşün.";
                if (oyuncu1 > 5) mesaj = "Kurabiye yi 1. Oyuncu Kazandı kurabiyeyi 2. oyuncu ısmarlayacak";
                if (oyuncu2 > 5) mesaj = "Kurabiye yi 2. Oyuncu Kazandı kurabiyeyi 1. oyuncu ısmarlayacak";
                MessageBox.Show(mesaj, "Tebrikler");
                this.Close();
            }

        }
        public void SecimleriKaldır()
        {
            chosen1.Visible = false;
            chosen2.Visible = false;
        }
        public void SayaclarıSıfırla()
        {
            O1T.Text = "_";
            O2T.Text = "_";
        }

        public void PuanArttır()
        {
            if (sıra) oyuncu1++;
            else oyuncu2++;
            PuanGuncelle();
        }
        public void SecimleriSıfırla()
        {
            chosen2 = null;
            chosen1 = null;
        }
        public void PuanGuncelle()
        {
            OP1.Text = oyuncu1.ToString();
            OP2.Text = oyuncu2.ToString();
        }
        public void SırayıDegistir()
        {
            sıra = !sıra;
            Label suan = sıra ? O1S : O2S;
            Label eski = !sıra ? O1S : O2S;
            SayaclarıSıfırla();
            suan.Text = "Sıra Sizde";
            eski.Text = "Sıranı Bekle";


        }

        public void TümResimleriGizle()
        {
            foreach (PictureBox pb in pictureBoxes)
            {
                pb.ImageLocation = kapalıresim;
            }
        }

        public void SeciliResimleriKapat()
        {
            
            if (chosen2!=null)chosen2.Tag = chosen2.ImageLocation = kapalıresim; ;
            chosen1.ImageLocation = kapalıresim;
            
        }

        private void Timer_Tick(object sender, EventArgs e)//İlk resim seçildiğinde 2. yi seçmek için
        {
            Label label = sıra ? O1T : O2T;

            if (kalanSure > 0)
            {
                label.Text = kalanSure.ToString();
                kalanSure--;
            }
            else
            {
                label.Text = "_";
                SeciliResimleriKapat();
                SecimleriSıfırla();
                StopTimer();
                
            }
        }

        private void Timer_Tick2(object sender, EventArgs e)// Uygulama ilk açıldığında
        {
            if (ilksure > 0)
            {
                O1T.Text = ilksure.ToString();
                O2T.Text = ilksure.ToString();
                ilksure--;
            }
            else
            {
                timer2.Stop();

                SayaclarıSıfırla();
                TümResimleriGizle();
                izin = true;
            }

        }
        private void Timer_Tick3(object sender, EventArgs e)//seçme işlemi yanlışsa çalışır sırayı karşıya geçirir
        {
            Label hata = sıra ? H1 : H2;
            if(chosen1.Tag!=chosen2.Tag)hata.Visible = true;
            if (kitle > 0)
            {
                
                kitle--;
            }
            else
            {
                hata.Visible = false;
                izin= true;
                
                SırayıDegistir();
                SeciliResimleriKapat(); 
                SecimleriSıfırla();
                StopTimer3();
                
            }

        }
        private void Timer_Tick4(object sender, EventArgs e)// şuan kullanılmıyor
        {
            Label label = sıra ? O1T : O2T;

            if (kalanSure > 0)
            {
                label.Text = kalanSure.ToString();
                kalanSure--;
            }
            else
            {
                label.Text = "_";
                timer4.Stop();

                SırayıDegistir();
            }
        }
        private void All_Click(object sender, EventArgs e)
        {//Bu metodda timer kullanılıyor
            if (izin)
            {
                PictureBox pb = sender as PictureBox;

                if (chosen1 == null && !string.IsNullOrEmpty(pb.ImageLocation))
                {
                    
                    chosen1 = pb;
                    chosen1.ImageLocation = chosen1.Tag.ToString();
                    timer.Start();
                    
                }
                else if (chosen1.Name != pb.Name && chosen2==null)
                {
                    izin = false;
                    StopTimer();
                    
                    chosen2 = pb;
                    chosen2.ImageLocation = chosen2.Tag.ToString();
                    if (chosen1.Tag == pb.Tag)
                    {
                        
                        PuanArttır();
                        SecimleriKaldır();
                        SecimleriSıfırla();
                        izin = true;
                    }
                    else
                    {
                        izin = false;
                        timer3.Start();
                        
                        

                    }
                    
                    SayaclarıSıfırla();
                    PuanKontrol();

                }
                ResimleriAta();
            }
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            BoxBagla();
            ResimAyarları();

            ResimleriAta();
            timer2.Start();

        }


    }
}
