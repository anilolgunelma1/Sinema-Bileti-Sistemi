using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneAraSinav
{
      class AnaBilet
    {  //anabilet özelikleri olusturuldu.
        private string Ad;
        private string Soyad;
        private int TcNo;
        private Koltuk koltuklar;
        private double Fiyat;


        //propetyler tanımlandı.
        public string İsim
        {
            get { return Ad; }

            set { Ad = value; }

        }

        public string Soyİsim
        {
            get { return Soyad; }

            set { Soyad = value; }

        }

        public int Tc_No
        {
            get { return TcNo; }

            set { TcNo = value; }

        }

        public double Bilet_Fiyat
        {
            get { return Fiyat; }

            set { Fiyat = value; }

        }
        protected Koltuk Koltuklar { get => koltuklar; set => koltuklar = value; }
      

        
        //Bilet bilgileri donduruluyor.
        public override String ToString()
        {
            return "Bilet:\n Ad: " + İsim + "\n Soyad: " + Soyİsim + "\nSıra: " + koltuklar.sıraNo + "\nNo: " + koltuklar.koltukNo + "\nBiletFiyat: " + Bilet_Fiyat;
        }



    }
}
