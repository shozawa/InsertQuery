using System;
using System.Reflection;
using System.Linq;

namespace InsertQuery
{    public class Query 
    {
        public static string Construct(object entity)
        {
            var type = entity.GetType();
            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            var keys = properties.Select(p => p.Name);
            var values = properties.Select(p => p.GetValue(entity));

            return $"INSERT FOO SET ({string.Join(",", keys)}) VALUES ({string.Join(",", values)})";
        }
    }
}
