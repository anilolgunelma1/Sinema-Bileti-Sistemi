using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NesneAraSinav
{
    class Program
    {
        static void Main(string[] args)
        {
            // gösterime ait özelikler , menu ve bilgiler yazdırıldı mainde.
            Şema şema = new Şema();
            şema.Goster();
           
            şema.tasarım();
            
           
            Console.ReadKey();

        }
    }
}
