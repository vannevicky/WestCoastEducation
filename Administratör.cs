namespace WestCoastEducation;

public class Administratör(string FirstName, string LastName, string TelefonNummer, string PersonNummer, string Adress, string Postnummer, string Ort, string Kunskapsområde, string Anställningsdatum) 
: Person (FirstName, LastName, TelefonNummer, PersonNummer, Adress, Postnummer, Ort)
{
    public string Kunskapsområde { get; set; } = Kunskapsområde;
    public string Anställningsdatum { get; set; } = Anställningsdatum;

    public override void PrintPerson()
    {
        base.PrintPerson();
        Console.WriteLine($"Kunskapsområde: {Kunskapsområde}");
        Console.WriteLine($"Anställningsdatum: {Anställningsdatum}");
    }
}
