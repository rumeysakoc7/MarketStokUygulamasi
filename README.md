# Market Stok Uygulaması

Bu proje C# Windows Forms kullanılarak geliştirilmiş bir market stok takip ve satış otomasyonudur.  
Uygulama ile ürünlerin stok durumu takip edilebilir, tedarikçilerden ürün alımı yapılabilir ve müşterilere satış işlemleri gerçekleştirilebilir.

## Özellikler

### Kullanıcı Sistemi
- Kullanıcı giriş sistemi bulunmaktadır
- Kullanıcı şifreleri **MD5 şifreleme yöntemi** ile güvenli şekilde saklanmaktadır

### Ürün ve Stok Yönetimi
- Ürün ekleme, silme ve güncelleme işlemleri yapılabilir
- Kategori bazlı ürün yönetimi yapılabilir
- Stok miktarları takip edilebilir
- Stok azaldığında ürünler **kırmızı renkte gösterilerek uyarı verilir**
- Azalan ürünler için **tedarik edilmesi gereken ürün uyarısı** gösterilir

### Alış ve Tedarik İşlemleri
- Tedarikçilerden ürün alımı yapılabilir
- Alınan ürünler otomatik olarak stoklara eklenir
- Tedarikçi bilgileri kayıt altında tutulur

### Satış İşlemleri
- Müşterilere ürün satışı yapılabilir
- Sepet sistemi ile satış işlemleri gerçekleştirilebilir
- Satılan ürünler stoktan otomatik düşülür
- Satış detayları kayıt altına alınır

### Stok Hareketleri
- Sistemde yapılan tüm stok giriş ve çıkışları kayıt altına alınır
- Ürün bazlı stok hareketleri görüntülenebilir

### Raporlama Sistemi
- Satış raporları görüntülenebilir
- Toplam satış tutarı hesaplanabilir
- Kar hesaplaması yapılabilir
- Ürün bazlı satış bilgileri görüntülenebilir

## Kullanılan Teknolojiler

- C# Windows Forms
- .NET
- SQL Server
- ADO.NET
- Visual Studio

## Veritabanı Kurulumu

Projenin çalışması için gerekli veritabanı scripti proje içerisinde bulunmaktadır.

Aşağıdaki dosyayı SQL Server üzerinde çalıştırmanız yeterlidir:

sql.script.sql

## Projeyi Çalıştırma

1. Projeyi bilgisayarınıza indirin
2. SQL Server üzerinde veritabanını oluşturun
3. sql.script.sql dosyasını çalıştırın
4. Visual Studio ile MarketStokUygulamasi.sln dosyasını açın
5. Projeyi çalıştırın
