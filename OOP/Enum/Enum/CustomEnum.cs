using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class CustomEnum
    {
        public CustomEnum(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;

    }
    public class DaysOfWeekCustomEnum
    {
        public static CustomEnum Sunday => new CustomEnum(1, nameof(Sunday));
        public static CustomEnum Monday => new CustomEnum(2, nameof(Monday));
        public static CustomEnum Tuesday => new CustomEnum(3, nameof(Tuesday));
        public static CustomEnum Wednesday => new CustomEnum(4, nameof(Wednesday));
        public static CustomEnum Thursday => new CustomEnum(5, nameof(Thursday));
        public static CustomEnum Friday => new CustomEnum(6, nameof(Friday));
        public static CustomEnum Saturday => new CustomEnum(7, nameof(Saturday));
    }
}
