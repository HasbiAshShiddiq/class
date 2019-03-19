using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari Class Mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //Mengeset nilai properties Objek Saya dan Kamu
            saya.Nim = "12345";
            saya.Nama= "Hasbi";
            saya.Ipk = 3.95f;

            kamu.Nim = "54321";
            kamu.Nama= "Bimo";
            kamu.Ipk = 3.75f;

            //Memanggil method registrasis dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
