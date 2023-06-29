using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    //Generic means general form
    //It does not specify pariticular datatype
    //we are using <> with type name
    //TypeName <T> -T is your type parameter
    //Generic allow us to a single class or method that can be used in different datatype
    //Advantages - we can reuse the code
    public class Generics<T>
    {
        public T data;
        public Generics(T data) 
        {
            this.data = data;
            Console.WriteLine(data);
        }
        public void Demo(T num)
        {
            Console.WriteLine(num);
        }
        public void Demo_Two(int num)
        {
            Console.WriteLine(num);
        }
    }
    public class Generics
    {
        public void Demo<T>(T num) 
        {
              Console.WriteLine(num); 
        }
        public void Demo_one(int num)
        {
            Console.WriteLine(num);
        }
    }
}
