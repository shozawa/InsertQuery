using System.Linq;

namespace InsertQuery
{
    public class Query 
    {
        public static string Construct(object entity)
        {
            var type = entity.GetType();
            var properties = type.GetProperties();
            var keys = properties.Select(p => p.Name);
            var values = keys.Select(k => $"@{k}");

            return $"INSERT {type.Name} SET ({string.Join(", ", keys)}) VALUES ({string.Join(", ", values)})";
        }
    }
}
