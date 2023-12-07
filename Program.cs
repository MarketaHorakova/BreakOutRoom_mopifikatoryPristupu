//Tvary a tělesa. Vytvořte základní třídu Teleso. Od ní odvoďte konkrétnější typy těles (krychle, koule,,,) a napište společné metody - objem, povrch. Vypište informaci o tělese pomocí methody ToString.
//Vytvořte seznam těles a pak vypište vlastnosti těchto těles pomocí ToString.

using BreakOutRoom_mopifikatoryPristupu;

Krychle kostka = new Krychle();
Koule koule = new Koule();

Console.WriteLine(kostka.ToStirng());
Console.WriteLine(koule.ToStirng());

Console.ReadLine();
