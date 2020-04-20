using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneAraSinav
{
    class İndirimliBilet:AnaBilet
    { //kalıtıma ek olarak indirimli bilet özelikleri tanımlandı.
        public string İndirimKodu;
        public int İndirimMiktari ;
        int c = 1;
        //indirimli bilet constructoru olusturuldu.
       public İndirimliBilet(string Ad,string Soyad ,int Tc,int Fiyat, string İndirimKodu,int İndirimMiktari)
        { 
            if(Bilet_Fiyat>c)
            {
                Bilet_Fiyat = Bilet_Fiyat - İndirimMiktari;
               
            }
         Bilet_Fiyat = Fiyat;
            İsim = Ad;
            Soyİsim = Soyad;
            Tc_No = Tc;
            this.İndirimKodu = İndirimKodu;
            this.İndirimMiktari = İndirimMiktari;
            
        }
     


    }
}
