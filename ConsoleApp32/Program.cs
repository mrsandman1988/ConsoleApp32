namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW();
            Opel opel = new Opel();
            Mercedes mercedes = new Mercedes();
            Driver driver1 = new Driver(bmw);
            driver1.Go();
            Driver driver2 = new Driver(opel);
            Driver driver3 = new Driver(mercedes);
            Driver driver4 = new Driver(new Lexus());
            Mexanik mexanik = new Mexanik(opel);
             
        }
    }
}