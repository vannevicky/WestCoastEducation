namespace WestCoastEducation;

public class Kurs(string kursNummer, string titel, int längd, string startdatum, string slutdatum)
{
 public string KursNummer { get; private set; } = kursNummer;
 public string Titel { get; private set; } = titel;
 public int Längd { get; private set; } = längd;
 public string StartDatum { get; private set; } = startdatum;
 public string SlutDatum { get; private set; } = slutdatum;

 public List<Studerande> AnmäldaElever {get; private set; } = [];
 public void LäggTillElev(Studerande elev)
    {
        AnmäldaElever.Add(elev);  
    }
 public void KursStatus()
    {
       Console.WriteLine($"--- Status för kurs: {Titel} ----");

       if (AnmäldaElever.Count < 5)
        {
            Console.WriteLine($"Tyvärr har kursen bara {AnmäldaElever.Count} anmälda elever. Det krävs minst 5 för kursen ska genomföras! ");
        }
        else
        {
            Console.WriteLine($"Kursen är godkänd för start! Antal anmälda {AnmäldaElever.Count} ");
            Console.WriteLine("Anmälda elever");
        }
        foreach(var elev in AnmäldaElever)
        {
        Console.WriteLine($"{elev.FirstName} {elev.LastName}");
        }
    }
 public virtual void PrintKurs()
    {
        Console.WriteLine($"Kursnummer: {KursNummer}");
        Console.WriteLine($"Titel: {Titel}");
        Console.WriteLine($"Längd: {Längd} veckor");
        Console.WriteLine($"Startdatum: {StartDatum}");
        Console.WriteLine($"Slutdatum: {SlutDatum}");

    }
}
