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

## ✅ Предварительные требования

- Установлен [.NET SDK 8.0](https://dotnet.microsoft.com/).
- SQL Server LocalDB или другой совместимый сервер базы данных.

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
2. Убедитесь, что выполнены все [предварительные требования](#-предварительные-требования).
3. В корне репозитория выполните восстановление зависимостей:
```bash
dotnet restore
```
4. Установите инструмент командной строки Entity Framework Core:
```bash
dotnet tool install --global dotnet-ef
```
   Этот шаг необходим перед выполнением `dotnet ef database update`.
5. Перейдите в папку `CloudCityCenter` и примените миграции:
```bash
dotnet ef database update
```
6. Запустите проект:
```bash
dotnet run --project CloudCityCenter
```

## 📚 Frontend библиотеки

Bootstrap и jQuery подключены через CDN в файле `_Layout.cshtml`. Локальная папка `wwwroot/lib` не используется.

## 🧪 Запуск тестов

Все модульные тесты находятся в проекте `CloudCityCenter.Tests`. Запустите их командой:

```bash
dotnet test
```

## 🌱 Заполнение базы примерами

После применения миграций можно заполнить базу данных тестовыми серверами с помощью класса `SeedData`. Выполните:

```bash
dotnet run --project CloudCityCenter -- seed
```
При этом будет создан тестовый пользователь `test@example.com` с паролем `Pa$$w0rd` и несколько примерных заказов.

## 🔗 Изменение строки подключения

Строка подключения `DefaultConnection` по умолчанию указывает на LocalDB. Вы можете отредактировать её в файле `CloudCityCenter/appsettings.json` или передать значение через переменную окружения:

```bash
export ConnectionStrings__DefaultConnection="Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"
```

После изменения строки подключения примените миграции и, при необходимости, заполните базу примерами:

```bash
dotnet ef database update
dotnet run --project CloudCityCenter -- seed
```
