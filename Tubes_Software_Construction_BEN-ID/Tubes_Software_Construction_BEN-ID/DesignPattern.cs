using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Software_Construction_BEN_ID
{
    class DesignPattern
    {
        // Komponen pada enum status.
        public enum Status
        {
            Empty, Pengisian, Pembayaran
        }

        private static readonly Lazy<SingletonPattern> _singleton = new Lazy<SingletonPattern>(() => new SingletonPattern());

        public static SingletonPattern GetInstance() => _singleton.Value;

        // Method homepage.
        private Status homepage;

        // Kondisi dimana pada tampilan masih kosong.
        private SingletonPattern()
        {
            Console.WriteLine("login");
            homepage = Status.Empty;
        }

        // Kondisi dimana pada tampilan isi bbm status sebagai pengisian pembelian.
        public void isiBBM()
        {
            if (!IsEmpty) return;
            Console.WriteLine("isi pengisian");
            homepage = Status.Pengisian;
        }


        // Kondisi dimana pada tampilan pembayaran status sebagai pembayaran dalam pengisian BBM.
        public void Pembayaran()
        {
            if (IsPembayaran || IsEmpty) return;
            Console.WriteLine("bayar");
            homepage = Status.Pembayaran;
        }

        private bool IsEmpty => (homepage == Status.Empty);

        private bool IsPembayaran => (homepage == Status.Pembayaran);
    }
}
