using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAntrian
{
    public class menu
    {
        public bool status = true;
        pasien Pasien = new pasien();
       
        public void showMenu()
        {
            do
            {
                Console.WriteLine("Menu Antrean Pasien");
                Console.WriteLine("1. Tambah Antrean");
                Console.WriteLine("2. Hapus Antrian Paling Depan");
                Console.WriteLine("3. Lihat Info Pasien");
                Console.WriteLine("4. Cetak Antrian");
                Console.WriteLine("5. Exit");
                Console.Write("Pilihan Anda : ");
                string opsi = Console.ReadLine();

                if(opsi=="1")
                {
                    Pasien.addPasien();
                    showMenu();
                }
                else if(opsi=="2")
                {
                    Pasien.majuPasien();
                    showMenu();
                }
                else if(opsi=="3")
                {
                    Pasien.showInfoPasien();
                    showMenu();
                }
                else if(opsi=="4")
                {
                    Pasien.printAntrian();
                    showMenu();
                }
                else if(opsi=="5")
                {
                    status = false;
                }
                else
                {
                    Console.WriteLine("Input Tidak Dikenal!!");
                    showMenu();
                }
            }
            while (status == true);
        }

    }
}
