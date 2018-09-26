using System.Linq;

namespace DdfGuide.Core
{
    public class Dumper
    {
        public string Dump(object obj)
        {
            var properties = obj.GetType().GetProperties();

            var dump = string.Empty;
            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(obj);

                dump += $"{propertyName}:{propertyValue}";

                if (property != properties.Last())
                {
                    dump += ",";
                }
            }

            return dump;
        }
    }
}
