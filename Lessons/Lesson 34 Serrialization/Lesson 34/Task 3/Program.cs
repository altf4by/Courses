using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Car : ISerializable
{
    public string name;
    public int speed;

    public Car(string name, int speed)
    {
        this.name = name;
        this.speed = speed;
    }


    private Car(SerializationInfo propertyBag, StreamingContext context)
    {

        Console.WriteLine("[ctor] ContextState: {0}", context.State.ToString());

        // Из мешка со свойствами извлекаем значения свойств помещенных ранее в методе GetObjectData()
        name = propertyBag.GetString("name");
        speed = propertyBag.GetInt32("speed");
    }

    // Метод ISerializable.GetObjectData() вызывается Formatter-ом
    void ISerializable.GetObjectData(SerializationInfo propertyBag, StreamingContext context)
    {

        Console.WriteLine("[GetObjectData] ContextState: {0}", context.State.ToString());

        // В мешок со свойствами добавляем два свойства и соответственно значения для них.
        propertyBag.AddValue("name", name);
        propertyBag.AddValue("speed", speed);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Mersedes-Benz", 250);
        Stream stream = File.Create("CarData.dat");

        BinaryFormatter formatter = new BinaryFormatter();

        // Сериализация (Вызов метода ISerializable.GetObjectData()).
        formatter.Serialize(stream, car);
        stream.Close();

        stream = File.OpenRead("CarData.dat");

        // Десериализация (Вызов спецконструктора).
        car = formatter.Deserialize(stream) as Car;

        Console.WriteLine(car.name + "\n" + car.speed);

        Console.ReadKey();
    }
}
