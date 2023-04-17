using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa(22_11_4857, "Rahmat Fauzi", 20);
            Mahasiswa mhs2 = new Mahasiswa(22_11_4856, "Jendral", 19);
            Mahasiswa mhs3 = new Mahasiswa(22_11_4820, "Dimas", 21);

            Console.WriteLine("Jumlah mahasiswa: {0}", Mahasiswa.JumlahMahasiswa); 

            Console.WriteLine("Mahasiswa 1:\n NIM {0}\n Nama {1}\n Umur {2}\n", mhs1.NIM, mhs1.Nama, mhs1.Umur); 
            Console.WriteLine("Mahasiswa 2:\n NIM {0}\n Nama {1}\n Umur {2}\n", mhs2.NIM, mhs2.Nama, mhs2.Umur);
            Console.WriteLine("Mahasiswa 3:\n NIM {0}\n Nama {1}\n Umur {2}\n", mhs3.NIM, mhs3.Nama, mhs3.Umur);

            Console.ReadKey();
        }
    }
}
