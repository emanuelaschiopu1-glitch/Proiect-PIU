namespace ExempluClase
{
    class Program
    {
        static void Main()
        {
            // instantiere obiect fara parametri
            var eveniment1 = new Eveniment();

            string ev1 = eveniment1.Info();
            Console.WriteLine(ev1);

            Console.WriteLine($"Este eveniment mare? {eveniment1.EsteEvenimentMare}");

            // instantiere obiect cu parametri
            Eveniment eveniment2 = new Eveniment(
                "Nunta Maria si Andrei",
                "Nunta",
                "Maria Popescu",
                new DateTime(2026, 6, 20),
                "Restaurant Royal",
                150,
                20000
            );

            string ev2 = eveniment2.Info();
            Console.WriteLine(ev2);

            Console.WriteLine($"Este eveniment mare? {eveniment2.EsteEvenimentMare}");

            Console.ReadKey();
        }
    }
}