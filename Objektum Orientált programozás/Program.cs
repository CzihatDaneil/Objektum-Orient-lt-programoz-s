using Objektum_Orientált_programozás;
List<Konyv> konyvek = new List<Konyv>();
if (File.Exists("konyvek.txt"))
{
    foreach (string sor in File.ReadAllLines("szobak.txt"))
    { 
        string[] adatok = sor.Split(';');
        int db = adatok.Count();
        if (db != 5) continue;
        if (int.TryParse(adatok[1], out int azonosito) && int.TryParse(adatok[2], out int cim)&& int.TryParse(adatok[3], out int szerzo)&& int.TryParse(adatok[4], out int ar)&& int.TryParse(adatok[5], out int raktarKeszlet))
        //string azonosito = adatok[0];
        //string cim = adatok[1];
        //string szerzo = adatok[2];

        ////int ar = int.TryParse(adatok[3], out int parsedAr);
        ////int raktarKeszlet = int.TryParse(adatok[4], out int parsedRaktarKeszlet);
        //Konyv konyv = new Konyv(azonosito, cim, szerzo, ar, raktarKeszlet);
        //konyvek.Add(konyv);
    }
}
else
{
    Console.WriteLine("A konyvek.txt fájl nem található.");
}