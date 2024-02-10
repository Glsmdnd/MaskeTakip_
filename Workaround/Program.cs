using Business.Concrate;
using Entities.Concrete;


//string mesaj = "Merhaba Dünya!";
//double tutar = 10000;
//int sayi = 100;
//bool girisYapilmisMi = true;
//string ad = "Gül";
//string soyad = "Döndü";
//int dogumYili=1989;
//long TC = 22114455887;

//Console.WriteLine(mesaj);//db den gelir
//Console.WriteLine(tutar*1.18);//KDV
//using Entities.Concrete;

//Person person= new Person();


selamVer(isim:"Gül");
selamVer(isim: "Melih");
selamVer();
int sonuc = Topla(6,58);

//DİZİLER
string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";
string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";
//ogrenciler[3] = "ilker";koyarsak sınırı aşmış oluruz dizi 3 elemanlı olacak diye söz verdik çünkü;
//peki biz diziye yeni elemanı nasıl ekleyebiliriz??
ogrenciler = new string[4];
ogrenciler[3] = "ilker";

//ogrenciler dizisi ilk etapta engin kerem berkayı tutsada  ogrenciler=new string[4] ogrenciler[3] = "ilker"; yapısı ile
//dizi yeni baştan oluşturulurmuş gibi davranılır.diziler bir referans tiptir.
//dolayısıyla bu ifade ile artık yeni oluşturulan diziyi refere edeceğinden
//çıktısı ilk 3 elemanı boş 4.elemanı ilker olarak çıktı verir.
//işin özü arraya sonradan eleman ekleyemiyorsun
//ARRAY;CLASS;İNTERFACE

for (int i = 0; i <ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}
string[] sehirler1 =new [] {"ankara","istanbul","izmir"};
string[] sehirler2 = new[] { "bursa", "Antalya", "diyarbakır" };
sehirler2 = sehirler1;//sehirler2 in referansı sehirler1'yi, yani sehirler2 artık birinnci dizinin içeriğini gösterecek ve
sehirler1[0] = "Adana";//onun ilk elemanını ankarayı adana yapacak

foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}
Person person1 = new Person();
person1.FirstName = "Engin";
person1.LastName = "Demiroğ";
person1.DateOfBirthDay = 1985;
person1.NationalIdentity = 123;

//ARTIK ARRAYLAR YERİNE GENERİC COLLECTİONLAR KULLANILIYOR bu bir liste alt yapısı array gibi REFERANST TİP olsada
//eleman eklerken referans tip derdinden kurtarıyor, diziye eleman eklemeyi sağlıyor
List<string> yenisehirler = new List<string> { "balıkesir", "inegöl", "izmir" };
yenisehirler.Add("iznik");
foreach(var ysehir in yenisehirler)
{
    Console.WriteLine(ysehir);
}
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

static void selamVer(string isim="isimsiz")//bana bir isim ver yoksa isimsiz geç
{
    Console.WriteLine("Merhaba "+isim);
}
static int Topla(int sayi1=5,int sayi2=10)//bana sayı ver yoksa defoult 5 ve 10 u kullan
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam "+sonuc.ToString());
    return sonuc;
}
public class vatandas()
{
    public string ad { get; set; }
    public string soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}