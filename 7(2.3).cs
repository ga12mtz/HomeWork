using System.IO;
using System;

class Program
{
    public enum Vus
    {
        KFY,
        MGY,
        SPBGY,
        ITMO,
        CrimeanKFY
    }
    struct Rabotnik
    {
        public string name;
        public string Sname;
        public int ZP;
        public Vus vus;
        public void Init(string n, string sn, int num,  Vus v)
        {
            ZP = num;
            name = n;
            Sname = sn;
            vus = v;
        }
        public void Write()

        {
            Console.WriteLine(name);
            Console.WriteLine(Sname);
            Console.WriteLine(ZP);
            Console.WriteLine(vus);
        }
    }
    static void Main()
    {
        Rabotnik client = new Rabotnik();
        client.Init("Artem", "Grig", 150000 , Vus.MGY);
        client.Write();
        
    }
}
