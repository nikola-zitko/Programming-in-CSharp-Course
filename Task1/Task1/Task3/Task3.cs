using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{

    class Task3 {
        public struct BankAccount
        {
            public BankAccount(double x, double y, string z) {
                BrojRacuna = x;
                IznosNaRacunu = y;
                VrstaRacuna = z;
            }
            public double BrojRacuna { get; }
            public double IznosNaRacunu { get; }
            public string VrstaRacuna { get; }
        }

        static void Main(string[] args) {
            List<BankAccount> Racuni = new List<BankAccount>();
            
            Racuni.Add(new BankAccount(1, 0, "tekuci"));
            Racuni.Add(new BankAccount(2, 0, "tekuci"));
            Racuni.Add(new BankAccount(3, 0, "ziro"));
            Racuni.Add(new BankAccount(4, 0, "stednja"));
            Racuni.Add(new BankAccount(5, 0, "tekuci"));

            int exit = 0;
            int odabir;
            
            do {
                Console.WriteLine("1. Unos novog računa      2. Ispis računa     3. Izlaz");
                Int32.TryParse(Console.ReadLine(), out odabir);
                switch (odabir) {
                    case (1):
                        double brojracuna, iznos;
                        int choice;
                        string tip;
                        Console.WriteLine("Unesite broj racuna: ");
                        Double.TryParse(Console.ReadLine(), out brojracuna);
                        Console.WriteLine("Unesite iznos racuna: ");
                        Double.TryParse(Console.ReadLine(), out iznos);
                        do {
                            
                            Console.WriteLine("Odaberite tip racuna: 1. Ziro, 2. Tekuci, 3. Stednja");
                            Int32.TryParse(Console.ReadLine(), out choice);
                            
                        } while (choice < 1 && choice > 3);
                        if (choice == 1)
                            tip = "ziro";
                        else if (choice == 2)
                            tip = "tekuci";
                        else
                            tip = "stednja";
                        Racuni.Add(new BankAccount(brojracuna, iznos, tip));

                        break;
                    case (2):
                        foreach (BankAccount racun in Racuni) {
                            Console.WriteLine("Broj: " + racun.BrojRacuna + " Iznos: " + racun.IznosNaRacunu.ToString("C") + " Tip: " + racun.VrstaRacuna);
                        }
                        break;
                    default:
                        exit = 1;
                        break;
                }
                
            } while (exit == 0);
            

        }
    }
}
