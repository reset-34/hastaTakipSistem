Hasta Takip Sistemi

Bu proje, bir sağlık merkezindeki hasta kayıtlarını, muayene geçmişlerini ve randevuları dijital ortamda yönetmek için geliştirilmiş bir backend sistemidir.

Kullanılan Teknolojiler
* Dil / Framework:C# / .NET Core Web API
* Veritabanı:MS SQL Server (Entity Framework Core)
* Mimari:Katmanlı Mimari (Layered Architecture)

Özellikler
* Hasta Yönetimi:Hasta kayıt ekleme, güncelleme ve listeleme.
* Randevu Sistemi:Hastalara randevu oluşturma ve takvim takibi.
* Hızlı Arama:T.C. Kimlik numarası veya isim ile hasta sorgulama.

Kurulum ve Çalıştırma
1. Bu projeyi bilgisayarınıza indirin (clone edin).
2. `appsettings.json` dosyasındaki `ConnectionString` alanını kendi SQL Server adresinize göre güncelleyin.
3. Paket Yöneticisi Konsolu'ndan (Package Manager Console) `Update-Database` komutunu çalıştırarak veritabanını oluşturun.
4. Projeyi çalıştırıp `Swagger` arayüzü üzerinden test edebilirsiniz.
