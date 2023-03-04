
using MyClassLibrary;
using System;
using System.IO;
using System.Reflection;

namespace Refleksija.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly assem = null;

            try
            {
                assem = Assembly.Load("MyClassLibrary");
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            if (assem == null)
                return;


            Type CountryType = assem.GetType("MyClassLibrary.Country");


            object obj = Activator.CreateInstance(typeof(Country), new object[] { "Srbija", 7001444 });


            MethodInfo methodInfo = CountryType.GetMethod("GetCountryInfo");

            object[] parameters = new object[] { };


            object returnValue = methodInfo.Invoke(obj, parameters);


            Console.WriteLine(returnValue);

        }

    }

}

