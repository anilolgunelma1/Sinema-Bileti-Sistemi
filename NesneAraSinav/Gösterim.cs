using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneAraSinav
{
    class Gösterim
    {// gosterıme ait ozelikler olusturuldu.
        private List<Koltuk> koltuklar1;
        private string FilmAdi;
        private int Seans;
        private string Tarih;
        private int SalonNo;

      
        //Gosterım yapıcı metodu olusturuldu.
        public Gösterim(string FilmAdi, int Seans, string Tarih, int SalonNo)
        {
            koltuklar1 = new List<Koltuk> { };
            this.FilmAdi = FilmAdi;
            this.Seans = Seans;
            this.Tarih = Tarih;
            this.SalonNo = SalonNo;
        }
        //koltuk ekleme olusturuldu.
        public void Ekle(Koltuk koltuk)
        {
            koltuklar1.Add(koltuk);
        }


        public bool koltukDurumu(int siraNo, int koltukNo)
        {
            foreach (Koltuk k in koltuklar1)
            {
                if (k.boşKoltuk)
                {
                    return true;
                }
            }
            return false;
        }
        //gosterıme aıt bilgiler donduruluyor.
        public override string ToString()
        {
            return "Film Adı: " + FilmAdi + "\nSeans: " + Seans + "\nSalon: " + SalonNo + "\nTarih: " + Tarih;
        }
    }
}
