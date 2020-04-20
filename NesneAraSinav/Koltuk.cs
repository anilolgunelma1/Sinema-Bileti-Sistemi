using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneAraSinav
{
    class Koltuk:Iİnterface1
    { //koltuk clasına aıt ozelıkler tanımlandı.
        private int SıraNo;
        private int KoltukNo;
        private bool BoşKoltuk = true;

        // koltuk yapıcı metodu olusturuldu.
        public Koltuk(int SıraNo, int KoltukNo, bool BoşKoltuk)
        {
            this.SıraNo = SıraNo;
            this.KoltukNo = KoltukNo;
            this.BoşKoltuk = BoşKoltuk;

        }
        // properyler olusturuldu.
        public int sıraNo
        {
            get { return SıraNo; }

            set { SıraNo = value; }

        }


        public int koltukNo
        {
            get { return KoltukNo; }

            set { KoltukNo = value; }

        }

        public bool boşKoltuk
        {
            get { return BoşKoltuk; }
            set { BoşKoltuk = value; }


        }
        //koltugun bos olup olmamasına gore yer ayırma metodu olusturuldu.
        public  bool YerAyırma()
        {

            if (BoşKoltuk==true)
            {
                
                return true;
            }
            else
            {
                return false;
            }

            Console.WriteLine("Yeriniz Ayrılmiştir");

        }

    }
}
