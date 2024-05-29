namespace SchoolClassProject
{
    /*
     Hozzon létre osztály SchoolClass néven az iskolában lévő osztályok tárolására!
Az osztályban deklaráljon property-ket a évfolyam, osztály azonosító, diákok havonta befizetendő osztálypénze!
Készítse el a szükséges konstruktorokat!
Készítse el az osztályt szöveggé alakító metódusát úgy, hogy az adatainak megjelenítésekor az adatok a következő formába jelenjenek meg:
      "9. a (7000 Ft)"
Példányosítsa és jelenítse is meg a fő programban a minta szerint a osztály adatait!
Hozza létre "9.b (6000 Ft)" osztályt is a főprogramban!
Írja ki algoritmus felhasználásával a "9.a osztály diákjai  havonta x forinttal többet fizetnek osztálypénzbe, mint 9.b osztály tanulói." vagy "9.b osztály diákjai  havonta x forinttal többet fizetnek osztálypénzbe, mint 9.a osztály tanulói." vagy a "9.a és 9.b osztály tanulói ugyan annyit fizetnek osztálypénzbe! havonta." !
A kiírás akkor is működjen ha az osztályok elnevezése más!
Egészítse ki a SchoolClass osztályt az osztályban járó diákok számát leíró property-vel!
Készítse el a ScoolClassRepo osztályt amely több osztály tárolására alkalmas adattípust tartalmazzon!
 A SchoolClass osztályba TDD módszerrel fejlessze ki a "MostPaydSchoolClass" (legtöbb osztálypénzt fizető osztály) metódust, amely visszaadja annak az osztálynak a nevét (pl. 9.a) amely a tárolt adattípusban a legtöbb osztálypénzt fizeti egy diák esetén! A metódust TDD módszerrel fejlessze ki! Legyen négy különböző tesztesete!
Ha az osztályok 10 hónapig gyűjtik az osztálypénzt és mindegyik osztályban 30 diák van és mindenki minden hónapban befizeti azt, akkor írja ki a képernyőre osztályonként a befizetett összes osztálypénzt!*/

    using System;

    class Program
    {
        static void Main(string[] args)
        {
            SchoolClass schoolClass1 = new SchoolClass(9, "a", 7000, 30);
            SchoolClass schoolClass2 = new SchoolClass(9, "b", 6000, 30);

            Console.WriteLine(schoolClass1.ToString());
            Console.WriteLine(schoolClass2.ToString());
            if (schoolClass1.MonthlyClassFee > schoolClass2.MonthlyClassFee)
            {
                Console.WriteLine($"9.a osztály diákjai havonta {schoolClass1.MonthlyClassFee - schoolClass2.MonthlyClassFee} forinttal többet fizetnek osztálypénzbe, mint 9.b osztály tanulói.");
            }
            else if (schoolClass2.MonthlyClassFee > schoolClass1.MonthlyClassFee)
            {
                Console.WriteLine($"9.b osztály diákjai havonta {schoolClass2.MonthlyClassFee - schoolClass1.MonthlyClassFee} forinttal többet fizetnek osztálypénzbe, mint 9.a osztály tanulói.");
            }
            else
            {
                Console.WriteLine("9.a és 9.b osztály tanulói ugyan annyit fizetnek osztálypénzbe! havonta.");
            }

            int totalClassFee1 = schoolClass1.MonthlyClassFee * schoolClass1.NumberOfStudents * 10;
            int totalClassFee2 = schoolClass2.MonthlyClassFee * schoolClass2.NumberOfStudents * 10;

            Console.WriteLine($"9.a osztály összes osztálypénze: {totalClassFee1} Ft");
            Console.WriteLine($"9.b osztály összes osztálypénze: {totalClassFee2} Ft");
        }
    }
}
