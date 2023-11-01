using HerancaMultipla.Devices;

namespace HerancaMultipla
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Printer p = new Printer() {SerialNumber = 1080};
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() {SerialNumber = 2003};
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertations");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
