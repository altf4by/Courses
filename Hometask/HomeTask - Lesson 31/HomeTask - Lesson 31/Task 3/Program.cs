using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try { assembly = Assembly.Load("ClassLibrary1"); }
            catch (Exception) { }

            //запускаем программу и выводим список членов:
            Type[] types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Тип: {0}", type);
                foreach (var t in type.GetMembers())
                    Console.WriteLine("\t{0,-15}\t: {1}", t.MemberType, t);

                Console.WriteLine(new string('-', 80));
            }


            #region этот код создает файлик task.txt
            Type message = assembly.GetType("ClassLibrary1.Message");

            MethodInfo run = message.GetMethod("Run");

            object instance = Activator.CreateInstance(message);

            Console.WriteLine(run.Invoke(instance, null));
            #endregion

            try
            {
                #region Генерация исключения
                Type begin = assembly.GetType("ClassLibrary1.Begin");
                MethodInfo startMethod = begin.GetMethod("StartMethod");

                object i2 = Activator.CreateInstance(begin);

                Console.WriteLine(startMethod.Invoke(i2, null));
                #endregion
            }
            catch (Exception)
            {
                #region Обработка исключение - создание новой сущности и вызов на ней метода.
                Type beginSomething = assembly.GetType("ClassLibrary1.Begin+Something");
                MethodInfo selectMe = beginSomething.GetMethod("SelectMe");

                object instance3 = Activator.CreateInstance(beginSomething);
                Console.WriteLine(selectMe.Invoke(instance3, null));
                //Это приведет к ложному пути.
                #endregion
            }

            #region GetData, GetTargetSite, GetStackTrace, GetHelpLink, GetSource, GetObjectData, GetHResult
            Type bs = assembly.GetType("ClassLibrary1.Begin+Something");

            MethodInfo getData = bs.GetMethod("get_Data");
            MethodInfo getTargetSite = bs.GetMethod("get_TargetSite");
            MethodInfo getStackTrace = bs.GetMethod("get_StackTrace");
            MethodInfo getHelpLink = bs.GetMethod("get_HelpLink");
            MethodInfo getSource = bs.GetMethod("get_Source");
            MethodInfo getObjectData = bs.GetMethod("GetObjectData");
            MethodInfo getHResult = bs.GetMethod("get_HResult");

            PropertyInfo dataInfo = bs.GetProperty("Data");

            object bsObject = Activator.CreateInstance(bs);

            var gdCollection = getData.Invoke(bsObject, null);

            var gTargetSite = getTargetSite.Invoke(bsObject, null);
            var gStackTrace = getStackTrace.Invoke(bsObject, null);
            var gHelpLink = getHelpLink.Invoke(bsObject, null);
            var gSource = getSource.Invoke(bsObject, null);
            var gHResult = getHResult.Invoke(bsObject, null);

            var dI = dataInfo.GetValue(bsObject);


            #endregion

            #region class SomeType
            Type someType = assembly.GetType("ClassLibrary1.SomeType");

            MethodInfo getProperty = someType.GetMethod("get_Property_1");

            object stObject = Activator.CreateInstance(someType);

            var gMethod = getProperty.Invoke(stObject, null);
            #endregion

            #region SecondClass
            Type secondClass = assembly.GetType("ClassLibrary1.SecondClass");

            MethodInfo helpForDecode = secondClass.GetMethod("HelpForDecode");

            object scObject = Activator.CreateInstance(secondClass);

            ParameterInfo[] prms = helpForDecode?.GetParameters();

            object[] par = { "Первый полет человека в космос" };

            Console.WriteLine(helpForDecode.Invoke(scObject, par));
            //После этого просит дать этому методу результат поля FieldHelpp

            foreach (var p in prms)
            {
                Console.WriteLine(p.Name);
            }
            //var help = helpForDecode.Invoke(scObject, null);
            #endregion


            #region Generator
            ////метод генератор
            //Type generatorOfKeys = assembly.GetType("ClassLibrary1.GeneratorOfKeys");

            //MethodInfo generator = generatorOfKeys.GetMethod("generator");
            //FieldInfo arrayOfKeys = generatorOfKeys.GetField("arrayOfKeys");

            //object gOfKeys = Activator.CreateInstance(generatorOfKeys);

            //var aok = arrayOfKeys.GetValue(gOfKeys);

            //Console.WriteLine(generator.Invoke(gOfKeys, null));
            #endregion

            #region ШИФРОВАНИЕ
            string messsage = File.ReadAllText(@"C:\FortBoyard\task.txt");
            int key = 19610412;

            Console.WriteLine();

            Console.WriteLine("Расшифрованое сообщение:");

            Console.WriteLine(Decrypt(messsage, key));
            #endregion



            Assembly assembly2 = null;

            try { assembly2 = Assembly.Load("ClassLibrary2"); }
            catch (Exception) { }


            Type[] types2 = assembly2.GetTypes();
            //запускаем программу и выводим список членов:
            foreach (var type in types2)
            {
                Console.WriteLine("Тип: {0}", type);
                foreach (var t in type.GetMembers())
                    Console.WriteLine("\t{0,-15}\t: {1}", t.MemberType, t);

                Console.WriteLine(new string('-', 80));
            }

            #region TargetClass 
            Type targetClass = assembly2.GetType("ClassLibrary2.TargetClass");

            MethodInfo metod = targetClass.GetMethod("Metod");

            object tcOblect = Activator.CreateInstance(targetClass);
            object[] prmsToPusk = { "Пуск" };

            Console.WriteLine(metod.Invoke(tcOblect, prmsToPusk));
            #endregion

            #region classWithCollection
            Type classWithCollection = assembly2.GetType("ClassLibrary2.ClassWithCollection");

            MethodInfo genCollectionOfCities = classWithCollection.GetMethod("GenCollectOfCities");
            MethodInfo nextMetod = classWithCollection.GetMethod("NextMetod");

            object cwcObject = Activator.CreateInstance(classWithCollection);
            object[] parCWC = { @"TCP\IP" };

            ArrayList genCollection = (ArrayList)genCollectionOfCities.Invoke(cwcObject, parCWC);

            Dictionary<string, object> cities = new Dictionary<string, object>();

            foreach (var item in genCollection)
                cities.Add(item.ToString(), item);


            var query = cities.OrderBy(city => city.Key).Select(city => city);

            Dictionary<string, object> cities2 = new Dictionary<string, object>();

            foreach (var item in query)
                cities2.Add(item.Key, item.Value);


            object[] parCWC2 = { cities2 };

            nextMetod.Invoke(cwcObject, parCWC2);

            #endregion


            #region City
            //Type city = assembly2.GetType("ClassLibrary2.City");

            //MethodInfo get_Name = city.GetMethod("get_Name");

            //object cityObject = Activator.CreateInstance(city);

            //Console.WriteLine(get_Name.Invoke(cityObject, null));
            #endregion

            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }

        private static string Encrypt(string message, int key)
        {
            string result = "";
            for (int i = 0; i < message.Length; i++)
                result += (char)(message[i] ^ key);
            return result;
        }

        private static string Decrypt(string message, int key)
        {
            return Encrypt(message, key);
        }
    }
}
