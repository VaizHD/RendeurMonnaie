using System;

namespace RendeurMonnaie
{

    class Program {

        public struct Wallet {
            public Wallet(){

            }

            public int Cent = 0;
            public int Cinquante = 0;
            public int Vingt = 0;
            public int Dix = 0;
            public int Cinq = 0;
            public int DeuxEuros = 0;
            public int UnEuros  = 0;

        }

        public static uint getInputUser(){
            Console.Write("Veuillez saisir un montant : ");
            while (true){
                if (uint.TryParse(Console.ReadLine(), out uint nombre)){
                    if (nombre >= 0 && nombre <= uint.MaxValue){
                        return nombre;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[!] Veuillez saisir un montant correct !");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        
       

        public static Wallet Calcul(uint nombre){
            Wallet wallet = new();
            while(nombre >= 100){
                wallet.Cent++;
                nombre -= 100;
            }
            while (nombre >= 50){
                wallet.Cinquante++;
                nombre -= 50;
            }
            while (nombre >= 20){
                wallet.Vingt++;
                nombre -= 20;
            }
            while (nombre >= 10){
                wallet.Dix++;
                nombre -= 10;
            }
            while (nombre >= 5){
                wallet.Cinq++;
                nombre -= 5;
            }
            while (nombre >= 2){
                wallet.DeuxEuros++;
                nombre -= 2;
            }
            while (nombre >= 1){
                wallet.UnEuros++;
                nombre -= 1;    
            }
            return wallet;
        }

        public static void Start(){
            while (true){
                uint money = getInputUser();
                Wallet wallet = Calcul(money);
                Console.WriteLine("[?] Avec " + money + " Vous pouvez obtenir : ");
                Console.ForegroundColor = ConsoleColor.Green;
                if (wallet.Cent > 0)
                    Console.WriteLine(wallet.Cent + " Billet" + ((wallet.Cent > 1) ? "s" : "") + " de 100e ");
                if (wallet.Cinquante > 0)
                    Console.WriteLine(wallet.Cinquante + " Billet" + ((wallet.Cinquante > 1) ? "s" : "") + " de 50e");
                if (wallet.Vingt > 0)
                    Console.WriteLine(wallet.Vingt + " Billet" + ((wallet.Vingt > 1) ? "s" : "") + " de 20e");
                if (wallet.Dix > 0)
                    Console.WriteLine(wallet.Dix + " Billet" + ((wallet.Dix > 1) ? "s" : "") + " de 10e");
                if (wallet.Cinq > 0)
                    Console.WriteLine(wallet.Cinq + " Billet" + ((wallet.Cinq > 1) ? "s" : "") + " de 5e");
                if (wallet.DeuxEuros > 0)
                    Console.WriteLine(wallet.DeuxEuros + " Piece" + ((wallet.DeuxEuros > 1) ? "s" : "") + " de 2e");
                if (wallet.UnEuros > 0)
                    Console.WriteLine(wallet.UnEuros + " Piece" + ((wallet.UnEuros > 1) ? "s" : "") + " de 1e");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Voulez vous recommencer un calcul ? (O/n)");
                Console.ForegroundColor = ConsoleColor.White;
                switch (Console.ReadLine())
                {
                    case "":
                    case "o":
                    case "O":

                        break;
                    default:
                        Console.WriteLine("Merci beaucoup d'avoir utilisé le programme !");
                        return;
                }
            }
            Console.WriteLine("Merci beaucoup d'avoir utilisé le programme !");
        }



        public static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║        Calculateur de Monnaie      ║");
            Console.WriteLine("║                                    ║");
            Console.WriteLine("║          Fait par @VaizHD          ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            Start();
        }
    }
}
