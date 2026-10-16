namespace WestCoastEducation;

public class Utbildningsledare (string FirstName, string LastName, string TelefonNummer, string PersonNummer, string Adress, string PostNummer, string Ort, string Kunskapsområde, string Anställningsdatum) 
: Lärare (FirstName, LastName, TelefonNummer, PersonNummer, Adress, PostNummer, Ort, Kunskapsområde)
{
  public string Anställningsdatum { get; private set; } = Anställningsdatum;
   public override void PrintPerson()
    {
      base.PrintPerson();
      Console.WriteLine($"Anställningsdatum: {Anställningsdatum}");
    }
}
