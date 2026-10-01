List<double> vegosszegek = new List<double>();

string BNev = "";
int KölcsönzöttNapok = 0;
string VIP = "";
for (int i = 0; i < 4; i++)
{
    Console.Write("Adja meg a nevét:");
    BNev = Console.ReadLine();
    Console.Write("Adja meg a kölcsönzött napok számát:");
    KölcsönzöttNapok = int.Parse(Console.ReadLine());
    Console.Write("Adja meg hogy VIP tag-e:('Igen' v. 'Nem')");
    VIP = Console.ReadLine();
}
bool VIPtag = false;

if (VIP=="igen" ||VIP=="Igen")
{
    VIPtag = true;
}

double alapdij = 12000 * KölcsönzöttNapok;

if (KölcsönzöttNapok>=7||VIPtag)
{
    alapdij *= 0.85;
    vegosszegek.Add(alapdij);
}
else if (KölcsönzöttNapok>=3)
{
    alapdij *= 0.95;
    vegosszegek.Add(alapdij);
}
else
{
    alapdij *= 1;
    vegosszegek.Add(alapdij);
}
