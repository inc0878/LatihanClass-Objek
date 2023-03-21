using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObjek
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Taxi
            Taxi taxi = new Taxi();
            Taxi taksi = new Taxi();

            // pengesetan nilai properties
            taxi.NAMA = "Hassan";
            taxi.Bertugas = true;
            taxi.JML = 5;

            taksi.NAMA = "dono";
            taksi.Bertugas = false;
            taksi.JML = 0;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.Menjemput_penumpang();
            taxi.Menurunkan_penumpang();

            taksi.TaxiInfo();
            taksi.Menjemput_penumpang();
            taksi.Menurunkan_penumpang();

            Console.ReadKey();
        }
    }
}