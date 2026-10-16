namespace WestCoastEducation;

public class Klassrum (string kursNummer, string titel, int längd, string startdatum, string slutdatum, string sal) 
: Kurs (kursNummer, titel, längd, startdatum, slutdatum)
{
   public string Sal { get; private set; } = sal;
   public override void PrintKurs()
   {
    base.PrintKurs();
    Console.WriteLine($"Sal: {Sal}");
   }

}
