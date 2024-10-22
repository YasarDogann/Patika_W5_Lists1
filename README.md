# Patika+ Week5 Array Uygulaması
Merhaba,
Bu proje C# ile Patika+ 5.hafta Arrays için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Diziler ve kullanımını öğrenmek
- Döngüler'i kullanmak


## İstenilen Görev
Patika Plus gala gecesine davetlisiniz!
Bu Pratik'te sizden ziyaretçilerin isimlerini eklediğimiz bir liste oluşturmanızı ve bu liste içerisinde for ya da foreach döngüsü ile dönerek isimlerini tek tek ekrana yazdırmanız isteniyor.
![2rdiMGU-davetliler](https://github.com/user-attachments/assets/ff98583f-1ceb-4079-b84a-25ca4833b838)


## Kod Region1 
```csharp
static void Main(string[] args)
{
    // List ile dinamik liste oluşturdum ve içine 4 adet string türünde veri girdim.
    List<string> names = new List<string>() { "Bülent Ersoy", "Ajda Pekkan", "Ebru Gündeş", "Hadise" };
    Console.WriteLine("\r\n** GALA **\r\n");

    // list'in Add() methodunu kullanarak ekleme işlemi yaptım
    names.Add("Hande Yener");
    names.Add("Tarkan");
    names.Add("Funda Arar");
    names.Add("Demet Akalın");
    names.Add("Mauro Icardi");
    names.Add("Victor Osimhen");
    names.Add("Gabrie Sara");
    names.Add("Fernando Muslera");

    
    int i = 0;
    foreach (string name in names)
    {
        Console.WriteLine(i+1+". "+name);
        i++;
    }

    // Count() ile listede bulunan eleman sayısı yazdırma
    Console.WriteLine("Listede Bulunan İsim Sayısı: "+ names.Count());

    Console.ReadKey();

}
```





