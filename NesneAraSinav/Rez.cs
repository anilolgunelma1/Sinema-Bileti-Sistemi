using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NesneAraSinav
{
    class Şema
    {


        // menu tasarlanarak bilet,indirimli bilet ve koltuk bilgileri girildi
        public void tasarım()
        {
            try
            {

            
          
            int deger ;
            int deger2;
            int deger3;
            Console.WriteLine("Bilet Bilgileri İçin 1'e Basınız");
            Console.WriteLine("İndirimli Bilet Bilgileri İçin 2'ye Basınız");
          
            deger = Convert.ToInt32(Console.ReadLine().ToString());
            switch (deger)
            {
               

                case 1: AnaBilet ana = new AnaBilet();
                    Console.WriteLine("İsminizi Giriniz:");
                    string a = Convert.ToString(Console.ReadLine());
                    ana.İsim = a;
                    Console.WriteLine("Soyİsminizi Giriniz:");
                    string b = Convert.ToString(Console.ReadLine());
                    ana.Soyİsim = b;
                    Console.WriteLine("Tc'nizi Giriniz:");
                    int c = Convert.ToInt32(Console.ReadLine());
                    ana.Tc_No = c;
                    
                   ana.Bilet_Fiyat = 15;
                    Console.WriteLine("Ad:"+a+"\nSoyad:"+b+"\n tc:"+ana.Tc_No+"\nFiyat:"+ana.Bilet_Fiyat   );

                    Console.WriteLine("Koltuk Bilgileri için 3'e Basınız");
                    deger2 = Convert.ToInt32(Console.ReadLine().ToString());
                    switch (deger2)
                    {
                        case 3:
                            Koltuk kt = new Koltuk(4, 17, true);
                            kt.YerAyırma();
                            Console.WriteLine(kt.koltukNo + " " + kt.sıraNo + " " + kt.boşKoltuk);
                            Console.WriteLine("Yeriniz Ayrılmiştir:");
                            
                            break;

                    }
                    break;
                
                case 2:
                    Console.WriteLine("sırasıyla isim,soyisim,tcno giriniz");
                    İndirimliBilet indirimli = new İndirimliBilet(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()),20, "Ind2003", 5);
                    Console.WriteLine("İsminiz:"+indirimli.İsim +"\nSoyİsminiz:" +indirimli.Soyİsim+"\nTc Numaranız:"+" "+indirimli.Tc_No+"\nBilet Fiyati:"+indirimli.Bilet_Fiyat+" \nGirilen İndirim Kodu:"+indirimli.İndirimKodu+" \nYapılan İndirim Miktari:"+ " "+indirimli.İndirimMiktari);
                    Console.WriteLine("Odeyecegınız Son Mıktar:"+(indirimli.Bilet_Fiyat-indirimli.İndirimMiktari));
                    Console.WriteLine("Koltuk Bilgileri için 4'e Basınız");
                    deger3 = Convert.ToInt32(Console.ReadLine().ToString());
                    switch (deger3)
                    {
                        case 4:
                            Koltuk kt = new Koltuk(4, 16, true);
                            kt.YerAyırma();
                            Console.WriteLine(kt.koltukNo + " " + kt.sıraNo + " " + kt.boşKoltuk);
                            Console.WriteLine("Yeriniz Ayrılmiştir:");

                            break;

                    }
                    break;

               




            }
        }
            catch(Exception rt)
            {
                Console.WriteLine(rt.Message);
            }
            }
        // gösterimList listesi olusturuldu .
        private List<Gösterim> gosterimList;
        private bool çalis;

        internal Şema()
        {
            gosterimList = new List<Gösterim> { };
        }

        // filmin adını ,seansını ,tarihini ve salon no yazdırıldı.
        public void Goster()
        {
            Dosya();
            Gösterim s = gosterimList[0];
            Console.WriteLine(s.ToString());
        }
        //Dosyadan veriler çekilerek çesitli yerlere atamalar yapıldı.
        private void Dosya()
        {
            try
            {
                çalis = true;


                string satir;
                string[] mat = new string[4];
                int SalonNo;
                int SıraNo;
                int KoltukNo;
                int yeni1 = 0;
                bool KoltukDurumu;
                Gösterim gosterim = null;
                string DosyaYolu = @"C:\Users\ADmin\Desktop\NesneAraSinav\NesneAraSinav\text.txt";

                FileStream h = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);
                StreamReader str = new StreamReader(h);

                while ((satir = str.ReadLine()) != null)
                {
                    mat = satir.Split(',');
                    SalonNo = Convert.ToInt32(mat[0]);
                    if (SalonNo > yeni1)
                    {
                        gosterim = new Gösterim("Asteriks ve Oburiks", 4, "10/10/2020", SalonNo);
                        
                        gosterimList.Add(gosterim);
                       
                    }
                    yeni1 = SalonNo;

                    SıraNo = Convert.ToInt32(mat[1]);
                    KoltukNo = Convert.ToInt32(mat[2]);
                    if (mat[3].Equals("dolu"))
                    {
                        KoltukDurumu = true;
                    }
                    else { KoltukDurumu = false; }
                    gosterim.Ekle(new Koltuk(SıraNo, KoltukNo, KoltukDurumu));

                }
            }
            catch (FileNotFoundException et)
            {
                Console.WriteLine(et.Message);
            }
            catch (DriveNotFoundException)
            {
                Console.WriteLine("Dosya Yolu Yanlış.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Bu Dosyayı Oluşturma İzniniz Yok.");
            }
            catch (NotSupportedException rt)
            {
                Console.WriteLine(rt.Message);
            }




        }

      


        }



    }

