using Methods;
using System.Text;

string urunAdi = "Elma";
double fiyati = 15;
string aciklama = "Amasya elmasi";
string[] meyveler = new string[] { };

Product urun1 = new Product();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elmasi";

Product urun2 = new Product();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakir karpuzu";

Product[] urunler = new Product[] { urun1, urun2 };

foreach (var urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("-------------------");
}

BasketManager basketManager = new BasketManager();
basketManager.Ekle(urun1);
basketManager.Ekle(urun2);

basketManager.Ekle2("Armut", "Yesil armut", 12, 10);
basketManager.Ekle2("Elma", "Yesil elma", 12, 20);
basketManager.Ekle2("Karpuz", "Diyarbakir karpuzu", 12, 30);