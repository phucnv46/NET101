using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiFinal_Generics_Reflection
{
    internal class ReflectionHelper
    {
        public static void SetProperties<T>(T person) where T : class, new()
        {
            foreach (var property in person.GetType().GetProperties())
            {
                if (property.CanWrite)
                {
                    Console.Write("Xin mời nhập {0} :", property.Name);
                    string input = Console.ReadLine();
                    try
                    {
                        var value = Convert.ChangeType(input, property.PropertyType);
                        property.SetValue(person, value);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Trường nhập sai");
                    }
                }
            }
        }
        

        public static void InRaThuocTinh<T>(T person) where T : class,new()
        {
            foreach (var property in person.GetType().GetProperties())
            {
                Console.Write($"{property.Name}: {property.GetValue(person)} ");
            }
        }
    }
}
