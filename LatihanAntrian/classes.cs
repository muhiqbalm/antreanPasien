using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAntrian
{
    public abstract class manusia
    {
        public string nama { get; set; }
        public string usia { get; set; }
    }

    public class pasien : manusia
    {
        protected string nomorUrut { get; set; }

        int[] arrNoUrut = new int[50];
        string[] arrNama = new string[50];
        int[] arrUsia = new int[50];

        Queue<string> antrian = new Queue<string>();

        int count = 1;

        public void showInfoPasien()
        {
            Console.Write("\nMasukkan Nomor Urut Pasien : ");
            int n = int.Parse(Console.ReadLine());

            if(arrNoUrut[n-1]!=0)
            {
                Console.WriteLine("\nBerikut info mengenai pasien nomor urut {0}", n);
                Console.WriteLine("Nomor Urut : " + arrNoUrut[n-1]);
                Console.WriteLine("Nama Pasien : " + arrNama[n-1]);
                Console.WriteLine("Usia Pasien : " + arrUsia[n-1] + " tahun");
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("Pasien dengan nomor urut {0} tidak ada\n", n);
            }
            
        }
        public void addPasien()
        {
            if (count <= 50)
            {
                arrNoUrut[count - 1] = count;
                Console.WriteLine("\nMasukkan Informasi Pasien");

                Console.WriteLine("Nomor Urut Pasien : {0}", count);
                Console.Write("Nama Pasien : ");
                arrNama[count - 1] = Console.ReadLine();
                antrian.Enqueue(arrNama[count - 1]);

                Console.Write("Usia Pasien : ");
                arrUsia[count - 1] = int.Parse(Console.ReadLine());

                Console.Write("\n");
                count = count + 1;
            }
            else
            {
                Console.WriteLine("Antrean penuh!!");
            }
            
        }

        public void majuPasien()
        {
            Console.WriteLine("\nPasien no urut 1 telah selesai menunggu");
            Console.WriteLine("Antrean akan bergerak maju\n");

            for(int i=1; i<=49; i++)
            {
                arrNama[i-1] = arrNama[i];
                arrUsia[i-1] = arrUsia[i];
            }

            antrian.Dequeue();

        }

        public void printAntrian()
        {
            Console.WriteLine("\nBerikut adalah daftar antrean pasien dari nomor urut 1 : ");
            foreach(var i in antrian)
            {
                Console.WriteLine(i);
            }
            Console.Write("\n");
        }
    }

}
