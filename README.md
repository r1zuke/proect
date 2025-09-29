Порядок разработки
Фаза 0 — Подготовка

Создать Git-репозиторий и структуру решений (UI, Core, Services, Data, Utils, Tests).

Настроить CI/CD (GitHub Actions или аналог) для сборки и тестов.

Фаза 1 — Доменная модель и слой данных

Реализовать сущности: Transaction, Account, Category, Currency.

Настроить Entity Framework Core: AppDbContext, IRepository<T>, EfRepository<T>.

Создать миграции и seed-данные для тестирования.

Фаза 2 — Сервисы (бизнес-логика)

Определить интерфейсы сервисов (ITransactionService, IAccountService, IReportService).

Реализовать основные сервисы.

Покрыть unit-тестами ключевые методы.

Фаза 3 — Интерфейс (MVVM)

Создать MainViewModel, TransactionViewModel, ReportViewModel.

Реализовать Views: главное окно, список транзакций, отчёты.

Настроить привязку данных и команды.

Фаза 4 — Дополнительные функции

Реализовать экспорт/импорт CSV.

Добавить отчёты по категориям и периодам.

Подключить логирование и обработку ошибок.

Фаза 5 — Тестирование и выпуск

Написать интеграционные тесты.

Провести отладку и улучшение UI.

Подготовить инсталлятор/пакет для релиза.

Backlog (приоритеты H/M/L)

H — Инициализация репозитория и структура проектов. (Status: Done)

H — Core: классы Transaction, Account, Category, Currency. (Status: Done)

H — Data: AppDbContext, IRepository<T>, EfRepository<T>. (Status: ToDo)

H — Services: ITransactionService, TransactionService. (Status: ToDo)

H — UI: MainWindow, TransactionView, MainViewModel. (Status: Done — макет интерфейса)

M — CSV экспорт/импорт. (Status: ToDo)

M — Отчёты (свод по категориям и по датам). (Status: ToDo)

M — Логирование и обработка ошибок (Utils.Logger). (Status: ToDo)

L — Интеграционные тесты, CI настроить. (Status: ToDo)

L — Экспорт в Excel/PDF (опционально). (Status: ToDo)
