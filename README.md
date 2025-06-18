# CloudCity Center

🌐 Интернет-магазин по аренде серверов, созданный с нуля на ASP.NET MVC и Entity Framework Core.

## ⚙️ Используемые технологии

- ASP.NET MVC (.NET 6/8)
- Entity Framework Core
- MS SQL Server
- Identity (регистрация и вход)
- Stripe / PayPal API (оплата)
- Bootstrap / Tailwind CSS (frontend)
- AdminLTE (панель администратора)

## 🔧 Возможности (будут реализованы)

- Каталог серверов по странам и характеристикам
- Личный кабинет клиента
- Панель администратора
- Онлайн-оплата аренды
- Автоматизация выдачи доступов

## 📦 Установка

1. Клонировать репозиторий:
```bash
git clone https://github.com/yourusername/CloudCityCenter.git
```
2. Убедитесь, что установлены [.NET SDK 8.0](https://dotnet.microsoft.com/) и SQL Server LocalDB.
3. В корне репозитория выполните восстановление зависимостей:
```bash
dotnet restore
```
4. Перейдите в папку `CloudCityCenter` и примените миграции:
```bash
dotnet ef database update
```
5. Запустите проект:
```bash
dotnet run --project CloudCityCenter
```

## 📚 Frontend библиотеки

Bootstrap и jQuery подключены через CDN в файле `_Layout.cshtml`. Локальная папка `wwwroot/lib` не используется.
