# String Kütüphanesi

* .ToUpper() = Karakterlerin hepsini tamamen büyük harf yapar. Tersi .ToLower()'dır.
* String.Concat(string değişken, eklenecek **string ifade**) = String değişkenin yanında **ifadeyi** ekler. 
*  Değişken1.CompareTo(değişken2) = değişken 1=2 olursa 0 döner; 1>2 olursa 1 döner; 1<2 olursa -1 döner.
  * String.Compare(değişken1, değişken2,IgnoreCaseCondition) = Yukardakinin aynısı, sadece ICC true olursa büyük küçük harf duyarlılığı olmaz.
* .Contains("aranan değer") = aranan değer değişkenin içinde varsa True döner.
* .Endwith("Sonda aranan değer")= String'in sonunda değer arar, varsa True döner. .Startwith() de aynısı.
* .IndexOf("Aranan Değer") = A harfini değişkende arar ve index'ini bulup verir. Bulamazsa -1 çıkar. .LastIndexOf ise son indexi getirir.
* .Insert(0,"Eklenecek değer") = 0. index'e **değeri** ekler.
* Değişken.PadLeft(n) = eğer değişkenin karakter sayısı n'den küçükse soluna 30'a tamamlayacak kadar boşluk ekler. Padleft(n,"*") bu şekildeyse n tane *(veya herhangi bir karakter) ekleyebilirsin.
* .Remove(start index, n) = belli indexten başlayarak n tane karakter siler. n yerine bir şey yazmazsan star'tan sonra ne varsa siler.
*  .Replace("değer1","değer2") = değer1 yerine değer2'yi koyar.
* .Split(" ")= verilen değere göre stringi böler ve bir dizi oluşturur. Hatta .Split(" ")[1] yaparsan bir dizi olduğu için bölüp birinci indexteki veriyi getirir.
* .Substring(4,6) = 4. indexten başlayarak 6 karakter getirir.





----------------

# Date Time Kütüphanesi



* DateTime bir kütüphane olduğu için nasıl String. yapıp kullanıyorsan bunda da DateTime.Now gibi kullanacaksın.

* DateTime.Now = Gün.Ay.Yıl Saat:Dakika: Saniye çıktısını verir.
  * DateTime.Now.Day gibi yaparak sadece günü alacak şekilde ayarlayabilirsin.
* DateTime.Now.DayOfWeak = Haftanın hangi gününde olduğunu söyler, _Saturday_ gibi.
* DateTime.Now.DayOfYear = Yılın _kaçıncı_ gününde olduğunu söyler, 64 gibi.
* DateTime.Now.**ToLongDateString()** = Tarihleri uzun bir şekilde yazmanı sağlar, tersi ise sadece long yerine short yazılarak yapılır.
* DateTime.Now.ToLongTimeString() = gğnğn saniyeye kadar olan saatini yazar. Short koyunca saniye gözükmez.
* DateTime.Now.TimeOfDay = Saliseye kadar günün andaki saatini gösterir.
* DateTime.Now.AddDays(2) = Bulunduğun ana 2 saat ekler, çeşitleri de mevcuttur.
## DateTime Format
Now.ToString("dd")= 2 tane d ile _day_'i sayıyla getirirsin; 3 taneyle Sat gibi kısa metinle, 4 tane ile metnin en uzun haliyle (Saturday). Month için de mantık aynı, yılda ise sadece 2 ila 4 y koyabilirsin. ToString("dd, MMMM, yyyy") olarak hepsini bir arada kullanabilirsin.


-------------
# Math Kütüphanesi

* Math.Abs(Value) =İçine yazılanı Absolute-Mutlak- değere sokar.
* Math.Sin/Cos/Tan/Cot(Value) =
* Math.Ceiling = Double değişkenleri bir yukarı sayıya yuvarlar.
* Math.Round = Double değişkenleri küsüratına bağlı aşağı ya da yukarı yuvarlar. (22.5 ise 22 yapar.)
* Math.Floor = Double değişkenleri aşağı yuvarlar.
* .Max(2,4) = 4 döner. Min de tersi.
* .Pow(4,4) = 4 üzeri 4'ü verir.
* .Sqrt(16) = 16'nın karekökünü alır.
* .log(4) = e tabanındaki logaritmanın 4 olan değerini verir.
* .Exp(3) = e üzeri 3'ü verir.
* .log10(100)= 10 tabanındaki logaritmanın 100 olan değerini verir.