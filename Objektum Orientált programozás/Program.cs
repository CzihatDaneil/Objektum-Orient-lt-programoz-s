using Objektum_Orientált_programozás;
List<Konyv> konyvek = new List<Konyv>();
if (File.Exists("konyvek.txt"))
{
    foreach (string sor in File.ReadAllLines("konyvek.txt"))
    { 
        string[] adatok = sor.Split(';');
        int db = adatok.Count();
        if (db != 5) continue;
        if (int.TryParse(adatok[3], out int ar) && int.TryParse(adatok[4], out int raktarKeszlet)) 
        {
            if (!string.IsNullOrWhiteSpace(adatok[0]))
            {
                Konyv akt = new Konyv(adatok[0], adatok[1], adatok[2], ar, raktarKeszlet);
                konyvek.Add(akt);
            }
            else Console.WriteLine($"Hiáynzó adat(ok) a sorban: {sor}");
        }
        else Console.WriteLine($"Hibás számadat(ok) a sorban: {sor}\n");
    }
}
else Console.WriteLine("A konyvek.txt fájl nem található.");
Console.WriteLine("=== BEOLVASOTT KÖNXVEK ===");

