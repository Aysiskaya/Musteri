// See https://aka.ms/new-console-template for more information
using Odevler;

Product product1 = new Product();
product1.productName = "Aranan Programcı Olma Kamp Kursu";
product1.fiyat = 100;
product1.egitmenAdı = "Engin Demiroğ";
product1.Category = "BT ve Yazılım";

Product product2 = new Product();
product2.productName = "Sıfırdan Zirveye İngilizce Eğitim Seti";
product2.fiyat = 149;
product2.egitmenAdı = "Serdar Hoca";
product2.Category = "Kişisel Gelişim";

Product[] products = new Product[] { product1, product2};

foreach (Product productlar in products)
{
    Console.WriteLine(productlar.productName);
    Console.WriteLine(productlar.egitmenAdı);
    Console.WriteLine(productlar.fiyat);
    Console.WriteLine(productlar.Category);
}
{
    ProductFonksiyon productfonksiyon =  new ProductFonksiyon();
    productfonksiyon.Ekle(product1);
    productfonksiyon.Ekle(product2);
}

{
    for (int k = 0; k < products.Length; k++) 

    {
        Console.WriteLine(products[k].productName);
        Console.WriteLine(products[k].fiyat);

    }
}

int dondurme = 0;

while (dondurme < products.Length)
{
    Console.WriteLine(products[dondurme].productName);
    Console.WriteLine(products[dondurme].Category);
    dondurme++;
}





 
