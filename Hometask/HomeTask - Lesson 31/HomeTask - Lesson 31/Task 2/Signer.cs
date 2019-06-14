using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Signer
    {
        public void Sign (HandlerProvider handler, EventProvider eProvider)
        {
            FieldInfo fi = typeof(EventProvider).GetField("SomeEvent", BindingFlags.Instance | BindingFlags.NonPublic);
            var handler2 = (EventHandler<SomeEventArgs>)fi.GetValue(eProvider);
            Delegate[] delegates = handler2.GetInvocationList();

            //var signedMethod = delegates.FirstOrDefault(item => item.Method.Name.Equals(handler.));

            //if (signedMethod == null)
            //    eProvider.SomeEvent += handler.SomeMethod;
            //    SomeEvent += value;



            Type t = eProvider.GetType();

            MethodInfo mi = handler.GetType().GetTypeInfo().GetDeclaredMethod(nameof(handler.SomeMethod));

            IEnumerable<EventInfo> events = t.GetEvents();

            var collection1 = events.SelectMany(e => e.GetOtherMethods(), (e, method) => new { EventName = e.Name, MethodName = method.Name });

            foreach (var item in collection1)
            {
                if (!item.MethodName.Equals(mi.Name))
                    eProvider.SomeEvent += handler.SomeMethod;

                else { Console.WriteLine("Method [{0}] is already signed", mi.Name); }
            }
        }

    }
}
