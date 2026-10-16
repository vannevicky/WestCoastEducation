namespace WestCoastEducation;

public class Lärare (string FirstName, string LastName, string TelefonNummer, string PersonNummer,string Adress,string PostNummer, string Ort,  string Kunskapsområde) 
: Person (FirstName, LastName, TelefonNummer, PersonNummer, Adress, PostNummer, Ort)
{
  public string Kunskapsområde { get; private set; } = Kunskapsområde;
  public List<Kurs>AnsvarigaKurser {get; private set;} = [];
   public override void PrintPerson()
    {
      base.PrintPerson();
      Console.WriteLine($"Kunskapsområde: {Kunskapsområde}");

      Console.WriteLine("Ansvarig för följande kurser:");

      foreach (var kurs in AnsvarigaKurser)
      {
        Console.WriteLine($"- {kurs.Titel}");
      }
    }
}
