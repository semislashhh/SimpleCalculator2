using System;

namespace SimpleCalculator
{
    class Program
    {
       

        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Che scimmia che sei.. Non hai inserito abbastanza numeri");
                Console.WriteLine();
                Manuale();
              
                return;
            }


            if (args.Length > 3 && args[3]  != "=")
            {
                Console.WriteLine("Ma sei una scimmia.. Hai inserito troppi argomenti. Inserisci solo il primo numero, un simbolo e il secondo numero. Premi invio dopo l'inserimento"); 
                Console.WriteLine();
                Manuale();
                return;
            }
            

            double numero1 = 0;

            try
            {
                numero1 = Convert.ToDouble(args[0]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Non hai inserito un numero valido scimmia. Attento a non inserire lettere, simboli o caratteri speciali. Inserisci solo numeri");
                Console.WriteLine();
                Manuale();
                return;
            }
            catch(OverflowException)
            {
                Console.WriteLine("Errore! Scimmia!");
                Console.WriteLine();
                
                return;
            }

            
            double numero2 = 0;


            try
            {
                numero2 = Convert.ToDouble(args[2]);
            }
            catch (FormatException)
            {                
                Console.WriteLine("Non hai inserito un numero valido scimmia"); 
                Console.WriteLine();
                Manuale();
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Il numero che hai inserito è troppo piccolo scimmia"); 
                Console.WriteLine();
                return;
            }

            string simbolo = args[1];
            double risultato = 0;


            switch (simbolo)
            {
                case "+":
                    risultato = Addizzione(numero1, numero2);
                    if (double.IsInfinity(risultato))
                    {
                        Console.WriteLine("Macaco!! Uno o più numeri sono troppo grandi");
                    }
                    else
                    {
                        Console.WriteLine("Brava scimmietta!! Il risultato dell'operazione è " + risultato);
                    }
                    
                    break;
                case "-":
                    risultato = Sottrazzione(numero1, numero2);

                    if (double.IsInfinity(risultato))
                    {
                        Console.WriteLine("Macaco!! Uno o più numeri sono troppo grandi");
                    }
                    else
                    {
                        Console.WriteLine("Brava scimmietta!! Il risultato dell'operazione è " + risultato);
                    }
                    break;
                case "/":
                    risultato = Divisione(numero1, numero2);
                    if (double.IsInfinity(risultato))
                    {
                        Console.WriteLine("Macaco!! Uno o più numeri sono troppo grandi");
                    }
                    else
                    {
                        Console.WriteLine("Brava scimmietta!! Il risultato dell'operazione è " + risultato);
                    }
                    break;
                case "*":
                    risultato = Moltiplicazione(numero1, numero2);
                    if (double.IsInfinity(risultato))
                    {
                        Console.WriteLine("Macaco!! Uno o più numeri sono troppo grandi");
                    }
                    else
                    {
                        Console.WriteLine("Brava scimmietta!! Il risultato dell'operazione è " + risultato);
                    }
                    break;
                default:
                    Console.WriteLine("Scimmia + per chiedere un'addizzione - per chiedere una sottrazione * per chiedere una moltiplicazione / per chiedere la divisione"); 
                    Console.WriteLine();
                    Console.WriteLine("Che babbuino.. Non hai inserito il simbolo corretto. Ricordati che puoi inserire solo i seguenti simboli."); 
                    Console.WriteLine();
                    break;                
            }
            
             //string[] simboli = { "+", "-", "/", "*" };

            //for (int i = 0; i < simboli.Length; i++)
            //{

            //}           
        }

        private static double Moltiplicazione(double numero1, double numero2)
        {
            double risultato = numero1 * numero2;
            return risultato;

        }

        private static double Divisione(double numero1, double numero2)
        {
            double risultato = numero1 / numero2;
            return risultato;
        }

        private static double Sottrazzione(double numero1, double numero2)
        {
            double risultato = numero1 - numero2;
            return risultato;
        }

        private static double Addizzione(double numero1, double numero2)
        {
            double risultato = numero1 + numero2;
            return risultato;
        }

        private static void Manuale()
        {
            Console.WriteLine("Questo programma è a prova di scimmia, può fare addizzioni, sottrazzioni, moltiplicazioni e divisioni");
            Console.WriteLine();
            Console.WriteLine("Il programma ha bisogno di tre dati");
            Console.WriteLine();
            Console.WriteLine("Il primo dato che devi inserire è uno dei numeri da elaborare. Premi Spazio per poter inserire il secondo dato");
            Console.WriteLine();
            Console.WriteLine("Il secondo dato è il simbolo dell'operazione che vuoi richiedere. Scegli tra i seguenti simboli da inserire");
            Console.WriteLine();
            Console.WriteLine(" +  per chiedere un'addizzione \n- per chiedere una sottrazione \n* per chiedere una moltiplicazione \n/ per chiedere la divisione");
            Console.WriteLine();
            Console.WriteLine("Poi scimmia urlatrice, l'ultimo dato da inserire è il secondo numero desiderato. Premi INVIO per avviare il programma e ottenere il risultato dell'operazione.");
            Console.WriteLine();            
        }
    }
}
