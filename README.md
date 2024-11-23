# 🌟 WebApiPanelAdminRapor

**WebApiPanelAdminRapor**, yönetim panelleri için özel olarak geliştirilmiş bir **ASP.NET Core Web API** uygulamasıdır. Bu uygulama, yönetim paneli kullanıcılarına raporlama ve veri yönetimi hizmetleri sunar. Proje, modern yazılım geliştirme standartlarına uygun olarak tasarlanmıştır.

---

## 🛠️ Özellikler

- **🌐 RESTful API Desteği**:
  - Yönetim panelleri için tüm CRUD (Create, Read, Update, Delete) işlemlerini sağlar.

- **📂 Modüler Tasarım**:
  - Proje; `Controllers`, `Models` ve yapılandırma dosyaları ile temiz ve düzenli bir yapıya sahiptir.

- **⚡ Hızlı ve Esnek**:
  - JSON tabanlı konfigürasyonlar ve Entity Framework Core ile kolay veritabanı bağlantısı sağlar.

- **🔒 Güvenlik ve Ölçeklenebilirlik**:
  - Modern API standartlarına uygun altyapı.

---

## 📂 Proje Yapısı

### 📁 Klasörler

- **Controllers**:
  - API'nin tüm endpoint'lerini içerir. Örnek: `WeatherForecastController`.

- **Models**:
  - Veritabanı modelleri ve veri yapıları bu klasörde tanımlanır.

- **Properties**:
  - Projenin yapılandırma dosyalarını içerir.

### 📄 Önemli Dosyalar

- **Program.cs**:
  - Uygulamanın başlangıç noktasıdır.
  
- **appsettings.json** & **appsettings.Development.json**:
  - Veritabanı bağlantı dizgileri ve yapılandırmalar burada yer alır.



---

## 🚀 Kurulum ve Çalıştırma

1. **📥 Depoyu Klonlayın**:
   ```bash
   git clone https://github.com/Sarizeybekk/WebApiPanelAdminRapor.git
   cd WebApiPanelAdminRapor
