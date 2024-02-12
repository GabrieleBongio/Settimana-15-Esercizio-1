using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var culture = new CultureInfo("fr-FR");
            culture.NumberFormat.CurrencySymbol = "€";
            culture.NumberFormat.CurrencyDecimalSeparator = ",";
            culture.NumberFormat.CurrencyGroupSeparator = ".";
            culture.NumberFormat.CurrencyPositivePattern = 0;
            culture.NumberFormat.CurrencyNegativePattern = 2;

            double Price = 3.00;
            bool continuare = true;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("/================MENU================\\");
                Console.WriteLine("|                                    |");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 1: Coca Cola 150 ml (€ 2.50)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("       |\n");
                Console.WriteLine("|                                    |");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 2: Insalata di pollo (€ 5.20)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("      |\n");
                Console.WriteLine("|                                    |");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 3: Pizza Margherita (€ 10.00)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("      |\n");
                Console.WriteLine("|                                    |");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 4: Pizza 4 Formaggi (€ 12.50)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("      |\n");
                Console.WriteLine("|                                    |");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 5: Pz Patatine Fritte (€ 3.50)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("     |\n");
                Console.WriteLine("|                                    |");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 6: Insalata di Riso (€ 8.00)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("       |\n");
                Console.WriteLine("|                                    |");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 7: Frutta di Stagione (€ 5.00)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("     |\n");
                Console.WriteLine("|                                    |");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 8: Pizza Fritta (€ 5.00)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("           |\n");
                Console.WriteLine("|                                    |");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 9: Piadina Vegetariana (€ 6.00)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("    |\n");
                Console.WriteLine("|                                    |");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 10: Panino Hamburger (€ 7.90)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("      |\n");
                Console.WriteLine("|                                    |");

                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" 11: Stampa conto finale e conferma");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" |\n");
                Console.WriteLine("|                                    |");

                Console.WriteLine("\\================MENU================/");
                Console.WriteLine("");
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    int scelta = Convert.ToInt16(Console.ReadLine());
                    switch (scelta)
                    {
                        case 1:
                            Price += 2.50;
                            break;
                        case 2:
                            Price += 5.20;
                            break;
                        case 3:
                            Price += 10.00;
                            break;
                        case 4:
                            Price += 12.50;
                            break;
                        case 5:
                            Price += 3.50;
                            break;
                        case 6:
                            Price += 8.00;
                            break;
                        case 7:
                            Price += 5.00;
                            break;
                        case 8:
                            Price += 5.00;
                            break;
                        case 9:
                            Price += 6.00;
                            break;
                        case 10:
                            Price += 7.90;
                            break;
                        case 11:
                            continuare = false;
                            break;
                        default:
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Valore non valido");
                            System.Threading.Thread.Sleep(1000);
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valore non valido");
                    System.Threading.Thread.Sleep(1000);
                }
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            } while (continuare);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Prezzo Totale: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\t {Price.ToString("C", culture)}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Grazie e Arriverci! <3");
            Console.ReadLine();
        }
    }
}
