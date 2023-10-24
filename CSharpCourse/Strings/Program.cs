//Intro();

String sentence = "My name is Özkan";

var result = sentence.Length; // 'sentence' değişkenin karakter uzunluğunu hesaplar
var result2 = sentence.Clone(); // 'sentence' değişkenin bir kopyasını oluşturur
sentence = "My name is Özkan Akkaya";

bool result3 = sentence.EndsWith("z"); // 'sentence' değişkenin sonunda "ğ" karakteri olup olmadığını kontrol eder
bool result4 = sentence.StartsWith("My name"); // 'sentence' değişkenin "My name" ile başlayıp başlamadığını kontrol eder

var result5 = sentence.IndexOf("namee"); // 'sentence' değişkenin içinde "namee" ifadesinin başladığı indeksi bulur. Eğer yoksa -1 döner
var result6 = sentence.IndexOf(" "); // 'sentence' değişkenin içinde boşluk karakterinin başladığı indeksi bulur
var result7 = sentence.LastIndexOf(" "); // 'sentence' değişkenin içindeki son boşluk karakterinin başladığı indeksi bulur

var result8 = sentence.Insert(0, "Hello,"); // 'sentence' değişkenin başına "Hello," metnini ekler
var result9 = sentence.Substring(3, 4); // 'sentence' değişkenin 3. indeksten başlayarak 4 karakterini alır
var result10 = sentence.ToLower(); // 'sentence' değişkenin tüm karakterlerini küçük harfe çevirir
var result11 = sentence.ToUpper(); // 'sentence' değişkenin tüm karakterlerini büyük harfe çevirir
var result12 = sentence.Replace(" ", "-"); // 'sentence' değişkenin içindeki tüm boşluk karakterlerini tire karakteri ile değiştirir
var result13 = sentence.Remove(2, 5); // 'sentence' değişkenin 2. indeksten başlayarak 5 karakterini siler

Console.WriteLine(result13);


Console.ReadLine();

static void Intro()
{
    string city = "Ankara";
    //Console.WriteLine(city[0]);

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";

    Console.WriteLine(String.Format("{0} {1}", city, city2));
}