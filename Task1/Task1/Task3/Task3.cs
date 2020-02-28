using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{

    class Task3 {
        enum TipRacuna{
            Ziro=1,
            Tekuci=2,
            Stednja=3
             
        }
        struct BankAccount
        {
            public BankAccount(double broj, double iznos, TipRacuna tip) {
                this.BrojRacuna = broj;
                this.IznosNaRacunu = iznos;
                this.VrstaRacuna = tip;
            }
            public double BrojRacuna { get; }
            public double IznosNaRacunu { get; }
            public TipRacuna VrstaRacuna { get; }
        }

        static void Main(string[] args) {
            List<BankAccount> Racuni = new List<BankAccount>();
            
            Racuni.Add(new BankAccount(1, 0, TipRacuna.Stednja));
            Racuni.Add(new BankAccount(2, 0, TipRacuna.Stednja));
            Racuni.Add(new BankAccount(3, 0, TipRacuna.Tekuci));
            Racuni.Add(new BankAccount(4, 0, TipRacuna.Tekuci));
            Racuni.Add(new BankAccount(5, 0, TipRacuna.Ziro));

            int exit = 0;
          
            do {
                Console.WriteLine("1. Unos novog računa      2. Ispis računa     3. Izlaz");
                int odabir;
                Int32.TryParse(Console.ReadLine(), out odabir);
                switch (odabir) {
                    case (1):
                        double brojracuna, iznos;
                        int choice;
                        Console.WriteLine("Unesite broj racuna: ");
                        Double.TryParse(Console.ReadLine(), out brojracuna);
                        Console.WriteLine("Unesite iznos racuna: ");
                        Double.TryParse(Console.ReadLine(), out iznos);
                        do {
                            
                            Console.WriteLine("Odaberite tip racuna: 1. Ziro, 2. Tekuci, 3. Stednja");
                            Int32.TryParse(Console.ReadLine(), out choice);
                            
                        } while (choice < 1 && choice > 3);
                        
                        string tip = Enum.GetName(typeof(TipRacuna), choice);
                        TipRacuna TipRacuna;
                        Enum.TryParse(tip, out TipRacuna);
                        
                        Racuni.Add(new BankAccount(brojracuna, iznos, TipRacuna));

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
