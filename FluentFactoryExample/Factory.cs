using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentFactoryExample
{
    class Factory<T> where T : class
    {
        public static FluentFactory<T> Init(T instance)
        {
            return new FluentFactory<T>(instance);
        }
    }
}
