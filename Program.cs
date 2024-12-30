using Metotlar;

string urunAdi = "Elma";
double fiyati = 12;
string aciklama = "elma amasyadan";

Urun urun1 = new Urun();
urun1.adi = "elma";
urun1.acıklama = "asd";
urun1.fiyati = 22;


Urun urun2 = new Urun();
urun2.adi = "ddd";
urun2.acıklama = "aa";
urun2.fiyati = 222;

Urun[] urunler = new Urun[] {urun1, urun2};
foreach (var item in urunler)
{
    Console.WriteLine("-------------");
    Console.WriteLine(item.adi);
    Console.WriteLine(item.acıklama);
    Console.WriteLine(item.fiyati);

}

Console.WriteLine(  "-------metotlar");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);