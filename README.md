Chart UygulamasıASP.NET Core 8.0 MVC tabanlı, dinamik grafik görselleştirme uygulaması.📊 Proje HakkındaBu proje, veritabanından alınan verileri farklı grafik türlerinde görselleştiren bir web uygulamasıdır. CanvasJS kütüphanesi kullanılarak interaktif ve responsive grafikler oluşturulur.🛠️ Kullanılan Teknolojiler
ASP.NET Core 8.0 - Web framework
Entity Framework Core 8.0.1 - ORM
SQL Server - Veritabanı
CanvasJS - Grafik görselleştirme kütüphanesi
Bootstrap - UI framework
Newtonsoft.Json - JSON serialization
📋 Özellikler
Doughnut Chart (Halka Grafik): Veritabanından çekilen Quarter ve Sales verilerini halka grafik olarak gösterir
Bar Chart (Sütun Grafik): Çalışan sayılarını yöneticilere göre görselleştirir
Funnel Chart (Huni Grafik): Sipariş analizi süreçlerini huni grafiği ile gösterir
🚀 KurulumGereksinimler
.NET 8.0 SDK
SQL Server (LocalDB veya tam sürüm)
Visual Studio 2022 veya Visual Studio Code
Adımlar

1. Projeyi klonlayın veya indirin

2. Veritabanı bağlantı ayarlarını yapılandırın
    appsettings.json dosyasındaki connection string'i kendi SQL Server bilgilerinize göre güncelleyin:
         "ConnectionStrings": {
         "Default": "Data Source=SUNUCU_ADINIZ; Initial Catalog=chartDB; Integrated Security=True;Connect Timeout=30;Encrypt=False;..."
         }
3. Veritabanını oluşturun
   Package Manager Console'da:
   Update-Database

4. Örnek veri ekleyin
   SQL Server'da chartDB veritabanına bağlanıp Examples tablosuna örnek veriler ekleyin:
   INSERT INTO Examples (Quarter, Sales) VALUES 
   ('Q1 2024', 25000),
   ('Q2 2024', 32000),
   ('Q3 2024', 28000),
   ('Q4 2024', 41000);


💾 Veritabanı Şeması
Examples Tablosu
KolonTipAçıklamaIdintPrimary KeyQuarterstringÇeyrek bilgisiSalesdoubleSatış tutarı (₺)
🎨 Kullanım

Ana sayfada üç farklı grafik türüne erişim linkleri bulunur
Dougnut: Veritabanındaki verileri dinamik olarak çeker ve halka grafik olarak gösterir
Bar Chart: Statik veri ile sütun grafiği gösterir
Funnel Chart: Sipariş süreci analizini huni grafiği ile gösterir

🔧 Özelleştirme
Grafik renklerini, animasyonları ve diğer görsel özellikleri .cshtml dosyalarındaki CanvasJS ayarlarından değiştirebilirsiniz.
📝 Notlar

Doughnut grafiğinde Türk Lirası (₺) sembolü kullanılmaktadır
Tüm grafikler animasyonlu ve interaktif olarak tasarlanmıştır
CanvasJS CDN üzerinden yüklenmektedir

📄 Lisans
Bu proje eğitim amaçlı geliştirilmiştir.

Geliştirici Notu: CanvasJS ücretsiz lisansı ticari olmayan projeler için kullanılabilir. Ticari kullanım için lisans satın almanız gerekebilir.
