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