using System;

namespace SchoolClassProject
{

    class SchoolClass
    {
        private byte evfolyam;
        private char osztaly_azonosito;
        private uint osztalypenz_havonta;
        private byte diakok_szama;

        public byte Evfolyam
        {
            get { return evfolyam; }
            set { evfolyam = value; }
        }

        public char Osztaly_Azonosito
        {
            get { return osztaly_azonosito; }
            set { osztaly_azonosito = value; }
        }

        public uint Osztalypenz_Havonta
        {
            get { return osztalypenz_havonta; }
            set { osztalypenz_havonta = value; }
        }

        public byte Diakok_Szama
        {
            get { return diakok_szama; }
            set { diakok_szama = value; }
        }

        public SchoolClass(byte evfolyam, char osztaly_azonosito, uint osztalypenz_havonta)
        {
            this.evfolyam = evfolyam;
            this.osztaly_azonosito = osztaly_azonosito;
            this.osztalypenz_havonta = osztalypenz_havonta;
        }

        public string as_string()
        {
            return $"{evfolyam}. {osztaly_azonosito} ({osztalypenz_havonta} Ft)";
        }

    }

    class SchoolClassRepo
    {
        private SchoolClass[] evfolyamok;

        public SchoolClass[] Evfolyamok
        {
            get { return evfolyamok; }
            set { evfolyamok = value; }
        }

        public SchoolClassRepo(SchoolClass[] evfolyamok)
        {
            this.evfolyamok = evfolyamok;
        }

        public string MostPaydSchoolClass()
        {
            uint legnagyobb = 0;
            uint legnagyobb_index = 0;

            for (uint i = 0; i < this.evfolyamok.Length; i++)
            {
                if (this.evfolyamok[i].Osztalypenz_Havonta > legnagyobb)
                {
                    legnagyobb = this.evfolyamok[i].Osztalypenz_Havonta;
                    legnagyobb_index = i;
                }
            }

            return $"{this.evfolyamok[legnagyobb_index].Evfolyam}.{this.evfolyamok[legnagyobb_index].Osztaly_Azonosito}";
        }

        public string[] Tiz_Honap_Osztalypenz()
        {
            var osszes_penz = new List<string>();

            for (uint i = 0; i < this.evfolyamok.Length; i++)
            {
                osszes_penz.Add($"{this.evfolyamok[i].Evfolyam}.{this.evfolyamok[i].Osztaly_Azonosito} {this.evfolyamok[i].Osztalypenz_Havonta * 30 * 10} Ft");
            }

            return osszes_penz.ToArray();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            SchoolClass schoolClass = new SchoolClass(9, 'a', 7000);
            Console.WriteLine(schoolClass.as_string());
            SchoolClass schoolClass2 = new SchoolClass(9, 'b', 6000);

            if (schoolClass.Osztalypenz_Havonta > schoolClass2.Osztalypenz_Havonta)
            {
                Console.WriteLine($"{schoolClass.Evfolyam}.{schoolClass.Osztaly_Azonosito} diákjai havonta {schoolClass.Osztalypenz_Havonta - schoolClass2.Osztalypenz_Havonta} forinttal többet fizetnek az osztálypénzbe, mint {schoolClass2.Evfolyam}.{schoolClass2.Osztaly_Azonosito} osztály tanulói.");
            }
            else if (schoolClass.Osztalypenz_Havonta < schoolClass2.Osztalypenz_Havonta)
            {
                Console.WriteLine($"{schoolClass2.Evfolyam}.{schoolClass2.Osztaly_Azonosito} diákjai havonta {schoolClass2.Osztalypenz_Havonta - schoolClass.Osztalypenz_Havonta} forinttal többet fizetnek az osztálypénzbe, mint {schoolClass.Evfolyam}.{schoolClass.Osztaly_Azonosito} osztály tanulói.");
            }
            else
            {
                Console.WriteLine($"{schoolClass.Evfolyam}.{schoolClass.Osztaly_Azonosito} és {schoolClass.Evfolyam}.{schoolClass.Osztaly_Azonosito} osztály tanulói ugyan annyit fizetnek az osztálypénzbe havonta.");
            }

            SchoolClassRepo schoolClassRepo = new SchoolClassRepo([schoolClass, schoolClass2]);
            Console.WriteLine(schoolClassRepo.MostPaydSchoolClass());
            foreach (string penz in schoolClassRepo.Tiz_Honap_Osztalypenz())
            {
                Console.WriteLine(penz);
            }
        }
    }
}
