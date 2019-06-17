using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Radio
{
    [NonSerialized]
    private int id = 9;

    public void OnOff(bool state)
    {
        Console.WriteLine(state ? "Радио Включено." : "Радио Выключено.");
    }
}

[Serializable]
public class Car
{
    protected int speed;
    protected string name;
    protected Radio radio;

    public Car(string name, int speed)
    {
        this.name = name;
        this.speed = speed;
        radio = new Radio();
    }

    public void TurnOnRadio(bool state)
    {
        this.radio.OnOff(state);
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
}

public enum Mode
{
    Lux, Sport
}

[Serializable]
public class Mersedes : Car
{
    protected Mode mode;

    public Mersedes(string name, int speed, Mode mode)
        : base(name, speed)
    {
        this.mode = mode;
    }

    public void SetMode(Mode mode)
    {
        this.mode = mode;
        Console.WriteLine(this.mode);
    }

    public void ShowMode()
    {
        Console.WriteLine(this.mode);
    }
}

[Serializable]
public class Driver
{
    public string Name { get; set; }
    public Driver(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Mersedes auto = new Mersedes("G500", 250, Mode.Lux);
        auto.TurnOnRadio(true);
        auto.ShowMode();
        Driver driver = new Driver("Серега");

        FileStream stream = File.Create("CarData.dat");

        BinaryFormatter formatter = new BinaryFormatter();

        // Cериализация.
        formatter.Serialize(stream, auto);
        stream.Close();

        Stream stream2 = File.OpenWrite("CarData.dat");
        stream2.Seek(stream2.Length, SeekOrigin.Begin);
        formatter.Serialize(stream2, driver);
        stream2.Close();

        stream = File.OpenRead("CarData.dat");

        // Десериализация.
        auto = formatter.Deserialize(stream) as Mersedes;
        driver = formatter.Deserialize(stream) as Driver;


        Console.WriteLine("Имя     : " + auto.Name);
        Console.WriteLine("Скорость: " + auto.Speed);
        Console.WriteLine("Состояние:"); auto.ShowMode();
        Console.WriteLine("Водила: {0}", driver.Name);
        auto.TurnOnRadio(false);
        stream.Close();

        Console.ReadKey();
    }
}

