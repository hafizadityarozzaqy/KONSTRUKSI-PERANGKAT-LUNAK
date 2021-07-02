using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Software_Construction_BEN_ID
{
    class DesignPattern
    {

        public enum Status
        {
            Empty, Pengisian, Pembayaran
        }

        private static readonly Lazy<SingletonPattern> _singleton = new Lazy<SingletonPattern>(() => new SingletonPattern());

        public static SingletonPattern GetInstance() => _singleton.Value;

        private Status homepage;

        public void isiBBM()
        {
            if (!IsEmpty) return;
            Console.WriteLine("isi pengisian");
            homepage = Status.Pengisian;
        }

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
