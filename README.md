# C# Windows Forms ile Dinamik Sipariş Yönetim Sistemi

Bu proje, **C# Windows Forms** kullanılarak geliştirilmiş dinamik bir e-ticaret sipariş ve otomasyon arayüzüdür. Kullanıcıların müşteri bilgilerini girmesine, sepete ürün ekleyip çıkarmasına ve gerçek zamanlı olarak indirim, kargo ve genel toplam hesaplamalarına olanak tanır.

## Uygulama Ekran Görüntüsü
([<img width="777" height="541" alt="Screenshot 2026-05-16 002323" src="https://github.com/user-attachments/assets/1b8380ef-4b2b-4610-898c-a0044b7323f3" />
])

## Özellikler
* **Müşteri Bilgileri Yönetimi:** Ad-Soyad, TC Kimlik, Maskeli Telefon formatı ve Şehir seçimi.
* **Dinamik Sepet Sistemi:** Ürün ve adet seçerek sepete ekleme, seçilen ürünü sepetten dinamik olarak silme.
* **Gelişmiş İndirim Mantığı:** * Öğrenci indirimleri (%5) ve Premium üye indirimleri (%10).
  * 10 adet ve üzeri toplu alımlarda ekstra %5 hacim indirimi.
* **Lokasyon Bazlı Kargo Hesaplama:** Seçilen kargo türüne (Standart, Hızlı, Express) göre ücretlendirme ve İstanbul, Ankara, İzmir gibi şehirlere özel kargo indirimleri.
* **Görsel Durum Bildirimi:** Genel toplamın 1000 TL sınırını aşması durumunda panel renginin dinamik olarak değişmesi.

## Kullanılan Teknolojiler
* **Dil:** C# (C-Sharp)
* **Framework:** .NET Windows Forms Application
* **Kütüphaneler:** `System.Globalization` (Kültüre duyarlı para birimi formatlaması için)

## Nasıl Çalıştırılır?
1. Bu repository'yi bilgisayarınıza indirin (Clone veya ZIP olarak).
2. `GorselProgramlamaProjesi.sln` dosyasını **Visual Studio** ile açın.
3. Yukarıdaki **"Start" (Başlat)** butonuna basarak projeyi derleyin ve çalıştırın.
