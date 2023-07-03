using Oop2;

//Nizes Lore
Console.WriteLine("Hello, World!");
GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.TcNo = "12345678910";
musteri1.Adi = "Nizes";
musteri1.Soyadi = "Lore";

//Kodlama.io
TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;    
musteri2.MusteriNo= "54621";
musteri2.SirketAdi= "Kodlama.io";
musteri2.VergiNo = "101010101010";


Musteri musteri3 = new GercekMusteri();
Musteri musteri4= new TuzelMusteri();


MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);
musteriManager.Ekle(musteri4);


