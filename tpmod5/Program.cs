using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod5
{
    internal class Program
    {
        class DataGeneric<T>
        {
            T Data { get; set; }
            public DataGeneric(T data)
            {
                Data = data;
            }
            public void PrintData()
            {
                Console.WriteLine($"Data yang tersimpan adalah: {Data}");
            }
        }
        public class HaloGeneric
        {
            public void SapaUser<T>(T userName)
            {
                Console.WriteLine($"Halo user {userName}");
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
