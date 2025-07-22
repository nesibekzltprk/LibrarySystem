# Library Viewer (Client-Server)

Bu proje, SQL Server veritabanından kitap, yazar ve yayınevi bilgilerini listelemek için geliştirilmiş bir .NET uygulamasıdır.

## Yapı

- **ASP.NET Core Web API**: Veritabanından gelen verileri JSON olarak sunar.
- **WinForms Uygulaması**: API'den verileri çekerek kullanıcıya listeler.
- **SQL Server (LibraryDb)**: Kitap, Yazar, Yayınevi gibi temel tabloları içerir.

## Özellikler

- Tüm veriler sadece GET istekleri ile okunur.
- Author, Publisher ve Book bilgileri görüntülenebilir.
- Basit bir client-server yapısı ile çalışır.

## Notlar

- `appsettings.json` dosyasındaki bağlantı string’i güncellenmelidir.
- Veritabanı script’i `LibraryDb.sql` dosyasındadır.
