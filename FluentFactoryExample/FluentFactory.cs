using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FluentFactoryExample
{
    class FluentFactory<T> : IFluentFactory<T>
    {
        T _instance;

        public FluentFactory(T instance)
        {
            _instance = instance;
        }

        public IFluentFactory<T> GiveAValue(Expression<Func<T, object>> Property, object value)
        {
            PropertyInfo pinfo = null;
            if (Property.Body is MemberExpression)
            {
                pinfo = (Property.Body as MemberExpression).Member as PropertyInfo;
            }
            else
            {
                pinfo = (((UnaryExpression)Property.Body).Operand as MemberExpression).Member as PropertyInfo;
            }

            pinfo.SetValue(_instance, value);
            return this;

        }

        //public IFluentFactory<T> GiveAValue(string propname, string value)
        //{
        //    var pInfo = _instance.GetType().GetProperty(propname);

        //    if (pInfo != null)
        //    {
        //        pInfo.SetValue(_instance, value);  
        //    }
        //    return this;
        //}

        public T Take()
        {
            return _instance;
        }
    }
}
