using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CZE_API.Helper
{

    public static class MyEnumExtentions
    {
        public static IEnumerable<T> ToIEnumerable<T>(this T tip) where T : IConvertible
        {
            return Enum.GetValues(typeof(T)).Cast<T>();      
        }   
    }
}