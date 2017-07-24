using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FluentFactoryExample
{
    interface IFluentFactory<T>
    {
        //IFluentFactory<T> GiveAValue(string propname, string value);
        IFluentFactory<T> GiveAValue(Expression<Func<T, object>> Property, object value);
        T Take();
    }
}
