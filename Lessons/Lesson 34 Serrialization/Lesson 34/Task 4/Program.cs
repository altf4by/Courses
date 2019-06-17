using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    [Serializable]
    class ShoppingCartItem
    {
        public Int32 productId;
        public decimal price;
        public Int32 quantity;
        public decimal total;
        [field: NonSerialized]
        public int MyProperty { get; set; }
        [field: NonSerialized]
        public event EventHandler MyEvent;


        public ShoppingCartItem(int productId, decimal price, int quantity)
        {
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
            this.total = price * quantity;
            //public event EventHandler My = new EventHandler()
        }

        // Используйте OnSerializingAttribute, чтобы выполнять действия с объектом до выполнения сериализации. 
        // Чтобы использовать OnSerializingAttribute, метод должен содержать параметр StreamingContext.
        [OnSerializing]
        void CalculateTotal(StreamingContext context)
        {
            total = price * quantity;
            Console.WriteLine("Total = {0}", total);
        }


        // Используйте OnDeserializedAttribute, чтобы задать значения по умолчанию непосредственно после десериализации.
        // Чтобы использовать OnDeserializedAttribute, метод должен содержать параметр StreamingContext.
        [OnDeserialized]
        void CheckTotal(StreamingContext context)
        {
            if (total == 0)
                CalculateTotal(context);
            else
                Console.WriteLine("Total != 0");
        }

        public override string ToString()
        {
            return productId + ": " + price + " x " + quantity + " = " + total;
        }
    }

    class Program
    {
        static void Main()
        {
            FileStream stream;
            BinaryFormatter formatter = new BinaryFormatter();
            ShoppingCartItem item = new ShoppingCartItem(22, 50000, 2);

            // Сериализация
            stream = new FileStream("SerializedItem.txt", FileMode.Create);
            formatter.Serialize(stream, item);
            stream.Close();

            // Десериализация
            stream = new FileStream("SerializedItem.txt", FileMode.Open);
            item = (ShoppingCartItem)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine(item.ToString());

            Console.ReadKey();
        }
    }

}
