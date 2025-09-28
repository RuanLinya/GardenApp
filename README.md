# GardenApp 🌱
## Projektbeschreibung

GardenApp ist eine Cross-Plattform-Anwendung (Windows, Android, iOS, MacCatalyst) auf Basis von .NET MAUI Blazor Hybrid.
Im GardenApp geht es um einen kleinen Garten-Shop, bei dem Produkte angezeigt, Detailseiten geöffnet und ein Warenkorb verwaltet werden können.

## Beispiel im Windows

<img width="1888" height="963" alt="image" src="https://github.com/user-attachments/assets/f433f5e5-558e-4b03-8f78-c0920bdd18f5" />
<img width="1891" height="975" alt="image" src="https://github.com/user-attachments/assets/6a0c88b5-0c19-4c0f-b9c3-b264f68dc845" />
<img width="1909" height="974" alt="image" src="https://github.com/user-attachments/assets/cba82844-1b07-42b8-8040-5b88a571001b" />
<img width="1909" height="967" alt="image" src="https://github.com/user-attachments/assets/cd257d2a-f808-4b0a-be47-f13a732ce482" />





## Funktionen

🏠 Startseite / Welcome-Seite

📦 Produktliste mit Kartenansicht (ProductCard.razor)

🔍 Produktdetails mit Beschreibung und Preis

🛒 Warenkorb mit Hinzufügen/Entfernen von Artikeln

🎨 Razor-Komponenten & Layout (MainLayout.razor)

📱 Cross-Plattform-Unterstützung (Windows, Android, iOS, MacCatalyst)

## 📂 Projektstruktur
```
GardenApp/
│   App.xaml / App.xaml.cs      → Einstiegspunkt (MAUI App)
│   MauiProgram.cs              → DI & App-Konfiguration
│   MainPage.xaml               → Startseite mit BlazorWebView
│   GardenApp.csproj            → Projektdatei
│
├── Components/                 → Wiederverwendbare Razor-Komponenten
│     ProductCard.razor
│
├── Pages/                      → Hauptseiten der App
│     Home.razor
│     ProductList.razor
│     ProductDetail.razor
│     Cart.razor
│     Welcome.razor
│
├── Shared/                     → Layout-Komponenten
│     MainLayout.razor
│
├── Data/                       → Daten- und Servicemodelle
│     Product.cs
│     CartItem.cs
│     ProductService.cs
│     CartService.cs
│
├── Platforms/                  → Plattform-spezifischer Code
│     Android/
│     iOS/
│     Windows/
│     MacCatalyst/
│
├── Resources/                  → Bilder, Fonts etc.
│
└── wwwroot/                    → Statische Webassets (index.html, CSS, Assets)
```
# Voraussetzungen

- .NET 8 SDK

- Visual Studio 2022 mit MAUI-Workload installiert

- Windows: benötigt Windows 10 oder höher

- Android: benötigt Android SDK & Emulator

- iOS: erfordert Mac mit Xcode (Pair to Mac)

