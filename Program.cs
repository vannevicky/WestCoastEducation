namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        Klassrum klassrum = new("C#101", "C# Grundkurs", 4, "2026-10-01", "2026-10-28", "Sal A1");
        Klassrum klassrum2 = new("C#102", "C# Fortsättning", 4, "2026-10-01", "2026-10-28", "Sal A2");
        Distans distans = new("DATA#101","Databasteknik", 5, "2026-11-01", "2026-12-28", "https://teams.microsoft.com/meetup-join/...");        
 
        List<Lärare> lärareLista = [];
        Lärare lärare = new("Mickey", "Mouse", "070222222", "19901020", "Klubbgatan 13C","21453","Malmö", "C# Grundkurs och Databasteknik");
        lärare.AnsvarigaKurser.Add(klassrum);
        lärare.AnsvarigaKurser.Add(distans);
        lärareLista.Add(lärare);
        
        Utbildningsledare utbildningsledare = new("Donald", "Duck", "07023333333", "19910214", "Ankvägen 40B", "21521", "Malmö", "C# Fortsättning", "2020-12-01");
        utbildningsledare.AnsvarigaKurser.Add(klassrum2);

        Administratör administratör = new("Bugs", "Bunny", "0702456456", "19930404", "Morotsgatan 32", "21723", "Malmö", "Administration", "2023-09-01");

        List<Kurs> kurser = [];
        kurser.Add(klassrum);
        kurser.Add(distans);
        kurser.Add(klassrum2);

        Studerande elev0 = new("Roberta", "Tubbs", "0722222222", "19950607", "Trävägen 23", "21212", "Malmö");
        Studerande elev1 = new("Cleveland", "Brown", "0744444444", "19991010", "Blågatan 10A", "21313", "Malmö");
        Studerande elev2 = new("Chris", "Griffin", "0755555555", "19950220", "Kalasgatan 15", "21414", "Malmö");
        Studerande elev3 = new("Meg", "Griffin", "0777777777", "19960430", "Kalasgatan 15", "21515", "Malmö");
        Studerande elev4 = new("Bart", "Simpson", "0788888888", "19970218", "Glasvägen 44", "21616", "Malmö");
        Studerande elev5 = new("Lisa", "Simpson", "0799999999", "19990523", "Glasvägen 44", "21717", "Malmö");
        
        List<Studerande> studerande = [];
        studerande.Add(elev0);
        studerande.Add(elev1);
        studerande.Add(elev2);
        studerande.Add(elev3);
        studerande.Add(elev4);
        studerande.Add(elev5);

        string? val = "";
        int elevIndex = 0;

        while (val != "x")
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Välkommen till WestCoast Education!");
            Console.WriteLine("=====================================");
            Console.WriteLine("MENYVAL:");
            Console.WriteLine("1. Lägg till elever till kursen.");
            Console.WriteLine("2. Lägg till kurs"); 
            Console.WriteLine("3. Visa lärare"); 
            Console.WriteLine("4. Visa Utbildningsledare"); 
            Console.WriteLine("5. Visa administratör"); 
            Console.WriteLine("6. Visa kurser"); 
            Console.WriteLine("7. Visa elever"); 
            Console.WriteLine("8. Lägg till nya elever."); 
            Console.WriteLine("9. Lägg till lärare."); 
            Console.WriteLine("x. Avsluta");
    
            val = Console.ReadLine();
            switch (val)
            {
                case "x":
                Console.WriteLine("Programmet har avslutats.");
                break;

                case "1":
                if (elevIndex < studerande.Count)
                    {
                       Studerande elev = studerande[elevIndex];
                       klassrum.LäggTillElev(elev);
                       elevIndex++;
                       klassrum.KursStatus();
                    }
                    else
                    {
                        Console.WriteLine("Alla elever har redan lagts till.");
                    }
                break;

                case "2":
                try
                {
                Console.WriteLine("Vad heter kursen?");
                string titel = Console.ReadLine()!;
                Console.WriteLine("Hur lång är kursen?");
                string Längd = Console.ReadLine()!;
                if (!int.TryParse(Längd, out int längd))
                    {
                        throw new Exception("Du måste ange i hela siffror.");
                    }
                Console.WriteLine("Vilket datum startar kursen?");
                string Startdatum = Console.ReadLine()!;
                Console.WriteLine("Vilket datum avslutas kursen?");
                string Slutdatum = Console.ReadLine()!;
                Console.WriteLine("Vad är kursnummret?");
                string Kursnummer = Console.ReadLine()!;
                Console.WriteLine("Vilken typ av kurs vill du skapa?");
                Console.WriteLine("1.Klassrumskurs");
                Console.WriteLine("2.Distanskurs");
                string typ = Console.ReadLine()!;
                if (typ == "1")
                        {
                            Console.WriteLine("Du valde klassrumskurs");
                            Console.WriteLine("Vilken sal ska kursen vara i?");
                            string sal = Console.ReadLine()!;
                            Klassrum klassrum1 = new(Kursnummer, titel, längd, Startdatum, Slutdatum, sal);
                            kurser.Add(klassrum1);
                        }
                        else if (typ == "2")
                        {
                            Console.WriteLine("Du valde Distanskurs");
                            Console.WriteLine("Vad är möteslänken?");
                            string möteslänk = Console.ReadLine()!; 
                            Distans distans1 = new(Kursnummer, titel, längd, Startdatum, Slutdatum, möteslänk);
                            kurser.Add(distans1);
                        }
                        else
                        {
                            Console.WriteLine("Ogiltligt val!");
                        }
                }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                break;

                case "3":
                foreach (Lärare lärare1 in lärareLista)
                    {
                        lärare1.PrintPerson();
                    }
                break;

                case "4":
                utbildningsledare.PrintPerson();
                break;

                case "5":
                administratör.PrintPerson();
                break;

                case "6":
                foreach(Kurs kurs in kurser)
                {
                  kurs.PrintKurs();
                  Console.WriteLine();
                }
                break;

                case "7":
                foreach (Studerande person in studerande)
                {
                   person.PrintPerson();
                }
                break;

                case "8":
                {
                Console.WriteLine("Ange förnamn:");
                string förnamn = Console.ReadLine()!;
                Console.WriteLine("Ange efternamn:");
                string efternamn = Console.ReadLine()!;
                Console.WriteLine("Ange telefonnummer:");
                string telefonnummer = Console.ReadLine()!;
                Console.WriteLine("Ange personnummer:");
                string personnummer = Console.ReadLine()!;
                Console.WriteLine("Ange adress:");
                string adress = Console.ReadLine()!;
                Console.WriteLine("Ange postnummer:");
                string postnummer = Console.ReadLine()!;
                Console.WriteLine("Ange ort:");
                string ort = Console.ReadLine()!;

                Studerande nyElev = new(förnamn, efternamn, telefonnummer, personnummer, adress, postnummer, ort);
                studerande.Add(nyElev);
                break;
                }

                case "9":
                {
                Console.WriteLine("Ange förnamn:");
                string förnamn = Console.ReadLine()!;
                Console.WriteLine("Ange efternamn:");
                string efternamn = Console.ReadLine()!;
                Console.WriteLine("Ange telefonnummer:");
                string telefonnummer = Console.ReadLine()!;
                Console.WriteLine("Ange personnummer:");
                string personnummer = Console.ReadLine()!;
                Console.WriteLine("Ange adress:");
                string adress = Console.ReadLine()!;
                Console.WriteLine("Ange postnummer:");
                string postnummer = Console.ReadLine()!;
                Console.WriteLine("Ange ort:");
                string ort = Console.ReadLine()!;
                Console.WriteLine("Ange kunskapsområde:");
                string kunskapsområde = Console.ReadLine()!;

                Lärare nyLärare = new(förnamn, efternamn, telefonnummer, personnummer, adress, postnummer, ort, kunskapsområde);
                lärareLista.Add(nyLärare);
 
                break;
                }
            }
        }
    }
}