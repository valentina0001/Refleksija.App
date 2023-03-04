using System;
using System.Reflection;

namespace String.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type StringType = typeof(string);

            if (StringType != null)

                Console.WriteLine("The class name is {0}.", StringType.Name);
            Console.WriteLine("The full class name is {0}.", StringType.FullName);
            Console.WriteLine("Class namescape is {0}.", StringType.Namespace);
            Console.WriteLine("Class assembly is {0}.", StringType.Assembly);

            Console.WriteLine("Base class is: {0}", StringType.BaseType);
            Console.WriteLine("Abstract: {0}", StringType.IsAbstract);
            Console.WriteLine("Sealed: {0}", StringType.IsSealed);
            Console.WriteLine("Generic: {0}", StringType.IsGenericTypeDefinition);
            Console.WriteLine("Class: {0}", StringType.IsClass);

         
            foreach (var i in StringType.GetInterfaces())
            Console.WriteLine("Interface:{0}", i.Name);


            ConstructorInfo[] p = StringType.GetConstructors();
            Console.WriteLine("Total number of constructors: {0}", p.Length);

            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(p[i]);
            }


            MethodInfo[] methods = StringType.GetMethods();

            for (int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine(methods[i]);
            }


            MemberInfo[] members = StringType.GetMembers();

            for (int i = 0; i < members.Length; i++)
            {
                Console.WriteLine(members[i]);
            }

    }

    }

}
