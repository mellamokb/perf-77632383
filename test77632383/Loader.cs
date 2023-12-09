using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test77632383
{
    public partial class Loader
    {
        public static List<Type1> List
        {
            get
            {
                var data = new List<Type1>();
                data.AddRange(Loader.List1);
                data.AddRange(Loader.List2);
                data.AddRange(Loader.List3);
                data.AddRange(Loader.List4);
                return data;
            }
        }
    }

    public class Type1
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int Order { get; set; }
        public int ID { get; set; }

        public Type2[] SubItems2 { get; set; }
        public Type3[] SubItems3 { get; set; }
    }

    public class Type2
    {
        public string Name { get; set; }
        public int Order { get; set; }
    }

    public class Type3
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Type4[] SubItems4 { get; set; }

    }

    public class Type4
    {
        public int ID { get; set; }
        public double From { get; set; }
        public double To { get; set; }
    }
}
