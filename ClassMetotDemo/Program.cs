// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

{
    Musteri musteri1 = new Musteri();
    musteri1.Id = 1;
    musteri1.Ad = "Aysenur";
    musteri1.SoyAd = "Kaya";

    Musteri musteri2 = new Musteri();
    
        musteri2.Id = 2;
        musteri2.Ad = "Furkan";
        musteri2.SoyAd = "Duzsuzoğlu";


        MusteriManager musteri = new MusteriManager();
        musteri.Ekle(musteri1);
        musteri.Listele(musteri1);


    
    

}   

