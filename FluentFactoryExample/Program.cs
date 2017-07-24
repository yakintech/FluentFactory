using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var kisi = Factory<Kisi>.Init(new Kisi()).GiveAValue(x => x.Ad, "Çağatay").Take();

        }
    }
}
