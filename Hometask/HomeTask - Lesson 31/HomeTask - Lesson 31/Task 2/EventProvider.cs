using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class EventProvider
    {
        private EventHandler<SomeEventArgs> _event;
        public event EventHandler<SomeEventArgs> SomeEvent
        {
            add
            {
                FieldInfo fi = typeof(EventProvider).GetField("_event", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
                var handler = (EventHandler<SomeEventArgs>)fi.GetValue(this);
                Delegate[] delegates = handler?.GetInvocationList();
                var signedMethod = delegates?.FirstOrDefault(item => item.Method.Name.Equals(value.Method.Name));

                if (signedMethod == null)
                {
                    _event += value;
                }
                else Console.WriteLine("This method is already signed");


                if (_event.GetInvocationList().Contains(value.Target))
                    Console.WriteLine("This object is already signed");

                else
                {
                    _event += value;
                }


            }
            remove
            {
            }
        }


        //public void CreateEvent(int input)
        //{
        //    EventHandler<SomeEventArgs> sEvent = SomeEvent;

        //    if (sEvent != null)
        //    {
        //        sEvent(this, new SomeEventArgs(input));
        //    }
        //}
    }
}
