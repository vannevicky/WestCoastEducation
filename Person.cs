namespace WestCoastEducation;
public class Person (string FirstName, string LastName, string TelefonNummer, string personNummer, string Adress, string Postnummer, string Ort) 
{
  public string FirstName { get; private set; } =  FirstName; 
  public string LastName { get; private set; } = LastName;
  public string TelefonNummer { get; private set; } = TelefonNummer;
  public string PersonNummer { get; private set; } = personNummer;
  public string Adress { get; private set; } = Adress;
  public string PostNummer { get; private set; } = Postnummer;
  public string Ort { get; private set; } = Ort;

  public virtual void PrintPerson()
    {
        Console.WriteLine($"Namn: {FirstName} {LastName}");
        Console.WriteLine($"Personnr: {PersonNummer}");
        Console.WriteLine($"TelefonNummer: {TelefonNummer}");
        Console.WriteLine($"Adress: {Adress}, {PostNummer} {Ort}");

        Console.WriteLine();
    }
}