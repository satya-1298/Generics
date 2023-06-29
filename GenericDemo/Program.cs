using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            Generics<int> generics = new Generics<int>(25);
            Generics<char> genericschar = new Generics<char>('S');
            Generics<string> genericstring = new Generics<string>("Satya");
            Generics<bool> genericsbool = new Generics<bool>(true);
            Generics<double> genericsdouble = new Generics<double>(2.544234);
            Generics<float> genericsfloat = new Generics<float>(2.4f);
            generics.Demo_Two(4);
            Console.WriteLine("Enter a Value");
             var num = Convert.ToInt32(Console.ReadLine());
            generics.Demo(num);
            genericstring.Demo("satya");
            genericschar.Demo('d');
            Console.WriteLine("***************");
            Generics obj = new Generics();
            obj.Demo<int>(32);
            obj.Demo<string>("hello");
            obj.Demo<bool>(false);
            obj.Demo_one(3);
           Console.ReadLine(); 
        }
    }
}
