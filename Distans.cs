namespace WestCoastEducation;

public class Distans(string kursNummer, string titel, int längd, string startDatum, string slutDatum, string  möteslänk) 
: Kurs (kursNummer, titel, längd, startDatum, slutDatum)
{
   public string Möteslänk { get; private set; } = möteslänk;
   public override void PrintKurs()
   {
    base.PrintKurs();
    Console.WriteLine($"Möteslänk: {Möteslänk}");
   }
}
