using System;
using System.Collections.Generic;
using LibrarieModele;
using NivelStocareDate;

namespace EvidentaEvenimente
{
    class Program
    {
        static void Main()
        {
            AdministrareEvenimenteMemorie admin = new AdministrareEvenimenteMemorie();
            Eveniment evNou = null;
            string optiune;

            do
            {
                Console.WriteLine("\nMENIU EVENIMENTE");
                Console.WriteLine("C - Citire eveniment");
                Console.WriteLine("I - Afisare ultim eveniment introdus");
                Console.WriteLine("A - Afisare toate evenimentele");
                Console.WriteLine("F - Cauta eveniment dupa nume");
                Console.WriteLine("T - Cauta evenimente dupa tip");
                Console.WriteLine("S - Salvare eveniment");
                Console.WriteLine("X - Inchidere");
                Console.Write("Alegeti optiunea: ");

                optiune = Console.ReadLine().ToUpper();

                switch (optiune)
                {
                    case "C":
                        evNou = CitireEveniment();
                        break;

                    case "I":
                        if (evNou != null)
                            AfisareEveniment(evNou);
                        else
                            Console.WriteLine("Nu exista eveniment introdus.");
                        break;

                    case "A":
                        AfisareEvenimente(admin.GetEvenimente());
                        break;

                    case "F":
                        Console.Write("Introduceti numele evenimentului: ");
                        string nume = Console.ReadLine();
                        Eveniment gasit = admin.GetEveniment(nume);
                        if (gasit != null)
                            AfisareEveniment(gasit);
                        else
                            Console.WriteLine("Evenimentul nu a fost gasit.");
                        break;

                    case "T":
                        Console.Write("Introduceti tipul evenimentului: ");
                        string tip = Console.ReadLine();
                        List<Eveniment> listaTip = admin.GetEvenimenteTip(tip);
                        if (listaTip.Count > 0)
                            AfisareEvenimente(listaTip);
                        else
                            Console.WriteLine("Nu exista evenimente de acest tip.");
                        break;

                    case "S":
                        if (evNou != null)
                        {
                            admin.AddEveniment(evNou);
                            Console.WriteLine("Eveniment salvat.");
                        }
                        else
                            Console.WriteLine("Nu exista eveniment de salvat.");
                        break;

                    case "X":
                        Console.WriteLine("Program inchis.");
                        break;

                    default:
                        Console.WriteLine("Optiune invalida.");
                        break;
                }

            } while (optiune != "X");
        }

        static Eveniment CitireEveniment()
        {
            Eveniment ev = new Eveniment();

            Console.Write("Nume eveniment: ");
            ev.NumeEveniment = Console.ReadLine();

            Console.Write("Tip eveniment: ");
            ev.TipEveniment = Console.ReadLine();

            Console.Write("Organizator: ");
            ev.Organizator = Console.ReadLine();

            Console.Write("Data eveniment (yyyy-mm-dd hh:mm): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime data);
            ev.DataEveniment = data;

            Console.Write("Locatie: ");
            ev.Locatie = Console.ReadLine();

            Console.Write("Numar invitati: ");
            int.TryParse(Console.ReadLine(), out int nr);
            ev.NrInvitati = nr;

            return ev;
        }

        static void AfisareEveniment(Eveniment ev)
        {
            Console.WriteLine(ev.Info());
        }

        static void AfisareEvenimente(List<Eveniment> lista)
        {
            Console.WriteLine("\nLista evenimente:");
            foreach (var ev in lista)
            {
                AfisareEveniment(ev);
            }
        }
    }
}