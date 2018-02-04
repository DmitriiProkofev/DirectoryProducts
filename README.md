# DirectoryProducts
Пример DirectoryProducts:

Отображение товаров по указанной группе.

Запуск:

- В Service\App.Config изменить строку подключения к базе данных (для двух контекстов данных ProductContext и GroupProductContext)

  <connectionStrings>
    <add name="Core.Context.ProductContext" connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=Products;Integrated Security=True" providerName="System.Data.SqlClient" />
    <add name="Core.Context.GroupProductContext" connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=GroupProducts;Integrated Security=True" providerName="System.Data.SqlClient" />
  </connectionStrings>

- С помощью консоли диспетчера пакетов выполнить миграции базы данных.

	- выбрать проект по умолчанию: Core;
	- выполнить миграции: Update-Database.

- Запустить приложение.

Структура приложения

 - Core: бизнес логика и миграции к бд;
 - Data: доступ к данным бд;
 - Service: wcf служба, доступ к Data;
 - Client: клиентская часть.
