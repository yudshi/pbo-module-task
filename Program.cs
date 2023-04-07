using System;

class Laptop
{
    public string Merk { get; set; }
    public string Tipe { get; set; }
    public string Vga { get; set; }
    public string Processor { get; set; }

    public void LaptopDinyalakan()
    {
        Console.WriteLine("Laptop {0} {1} menyala", Merk, Tipe);
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine("Laptop {0} {1} mati", Merk, Tipe);
    }

    public void BermainGame()
    {
        Console.WriteLine("Laptop {0} {1} sedang memainkan game", Merk, Tipe);
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Vivobook : Laptop
{
    public Vivobook()
    {
        Vga = "Nvidia";
        Processor = "Core i5";
    }
}

class IdeaPad : Laptop
{
    public IdeaPad()
    {
        Vga = "AMD";
        Processor = "Ryzen";
    }
}

class Predator : Laptop
{
    public Predator()
    {
        Vga = "AMD";
        Processor = "Core i7";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek laptop1 dan mengisi nilainya dengan objek Vivobook
        Vivobook laptop1 = new Vivobook();
        laptop1.Merk = "ASUS";
        laptop1.Tipe = "Vivobook";

        // Memanggil method LaptopDinyalakan pada objek laptop1
        laptop1.LaptopDinyalakan();

        // Membuat objek laptop2 dan mengisi nilainya dengan objek IdeaPad
        IdeaPad laptop2 = new IdeaPad();
        laptop2.Merk = "Lenovo";
        laptop2.Tipe = "IdeaPad";

        // Memanggil method BermainGame pada objek laptop2
        laptop2.BermainGame();

        // Membuat objek predator dan mengisi nilainya dengan objek Predator
        Predator predator = new Predator();
        predator.Merk = "Acer";
        predator.Tipe = "Predator";

        // Memanggil method BermainGame pada objek predator
        predator.BermainGame();

        // Memanggil method LaptopDimatikan pada objek laptop1
        laptop1.LaptopDimatikan();

        // Memanggil method Ngoding pada objek predator
        predator.Ngoding();

        Console.ReadKey();
    }
}
