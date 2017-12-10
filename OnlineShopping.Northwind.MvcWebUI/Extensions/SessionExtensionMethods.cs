using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Northwind.MvcWebUI.Extensions
{
    public static class SessionExtensionMethods
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            var obj = JsonConvert.SerializeObject(value);
            session.SetString(key, obj);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            var obj = session.GetString(key);
            if (string.IsNullOrEmpty(obj))
                return null;

            T value = JsonConvert.DeserializeObject<T>(obj);
            return value;
        }
    }
}
