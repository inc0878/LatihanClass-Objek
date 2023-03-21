using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObjek
{
    public class Taxi
    {
        // Properties
        public string NAMA { get; set; }
        public bool Bertugas { get; set; }
        public int JML { get; set; }

        // method
        public void TaxiInfo()
        {
            Console.WriteLine("\nNama driver: {0}", NAMA);

            if (Bertugas == true)
            {
                Console.WriteLine("Sedang bertugas: Iya", Bertugas);
            }
            else if (Bertugas == false)
            {
                Console.WriteLine("Sedang bertugas: Tidak", Bertugas);
            }

            Console.WriteLine("Jumlah penumpang: {0}", JML);
        }

        public void Menjemput_penumpang()
        {

            if (Bertugas == true)
            {
                Console.WriteLine("\n{0} Sedang menjemput penumpang", NAMA);
            }
            else if (Bertugas == false)
            {
                Console.WriteLine("\n{0} Sedang tidak menjemput penumpang", NAMA);
            }
        }

        public void Menurunkan_penumpang()
        {
            if (Bertugas == true)
            {
                Console.WriteLine("{0} belum selesai mengantar penumpang", NAMA);
            }
            else if (Bertugas == false)
            {
                Console.WriteLine("{0} Selesai mengantar penumpang", NAMA);
            }
        }

    }
}