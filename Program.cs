List<double> vegosszegek = new List<double>();

string BNev = "";
int KölcsönzöttNapok = 0;
string VIP = "";
bool VIPtag = false;
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"{i + 1}. bérlés adatai:");
    Console.Write("Adja meg a nevét:");
    BNev = Console.ReadLine();
    Console.Write("Adja meg a kölcsönzött napok számát:");
    KölcsönzöttNapok = int.Parse(Console.ReadLine());
    Console.Write("Adja meg hogy VIP tag-e:('Igen' v. 'Nem')");
    VIP = Console.ReadLine();
    Console.WriteLine("");
    if (VIP == "igen" || VIP == "Igen")
    {
        VIPtag = true;
    }

    double alapdij = 12000 * KölcsönzöttNapok;

    if (KölcsönzöttNapok >= 7 || VIPtag)
    {
        alapdij *= 0.85;
        vegosszegek.Add(alapdij);
    }
    else if (KölcsönzöttNapok >= 3)
    {
        alapdij *= 0.95;
        vegosszegek.Add(alapdij);
    }
    else
    {
        alapdij *= 1;
        vegosszegek.Add(alapdij);
    }

}
Console.WriteLine("Rögzített kölcsönzések díjai:");
for (int i=0; i < 4; i++)
{
    Console.WriteLine($"\t-{i + 1}. bérlés:{vegosszegek[i]} Ft");
}
double teljesbev = vegosszegek[0] + vegosszegek[1] + vegosszegek[2] + vegosszegek[3];
double atlagbevetel = (vegosszegek[0] + vegosszegek[1]+ vegosszegek[2]+ vegosszegek[3])/4;

string statusz = "";
if (teljesbev>= 200000)
{
    statusz = "Kiemelkedő forgalmú nap!";
}
else if (teljesbev>=100000)
{
    statusz = "Átlagos forgalmú nap.";
}
else
{
    statusz = "Gyenge forgalmú nap.";
}
Console.WriteLine($"Napi teljes bevétel:{teljesbev}");
Console.WriteLine($"Átlagos kölcsönzési díj: {atlagbevetel}");
Console.WriteLine($"Napi értékelés:{statusz}");