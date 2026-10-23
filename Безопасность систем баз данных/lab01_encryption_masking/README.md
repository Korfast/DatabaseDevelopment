# ЛР1. Шифрование и маскирование

## Варианты

Варианты выбраны по номеру студента в списке группы: 14.
Если число вариантов меньше 14, используется циклическое распределение.

- TDE: вариант 2, алгоритм `AES_192`.
- Always Encrypted: вариант 4, данные о зарплате.
- Dynamic Data Masking: вариант 4, анонимизация зарплаты для аналитики.

## Окружение

- Виртуальная машина: `DBSecurity`.
- SQL Server: экземпляр `WIN-8PB5C78B03Q\SQLSERVER`.
- База данных: `AdventureWorks2017`.

## Что собрать для отчета

- Скриншот подключения к SQL Server в SSMS.
- Скриншот списка баз данных с `AdventureWorks2017`.
- SQL-скрипты из папки `sql`.
- Скриншоты результата TDE.
- Скриншоты настройки и проверки Always Encrypted.
- Скриншоты настройки и проверки Dynamic Data Masking.
- Краткий вывод по каждой технологии защиты.

## Сделанные ключевые проверки

- TDE: `AdventureWorks2017` находится в состоянии `Encrypted`, алгоритм `AES`, длина ключа `192`.
- TDE: сертификат и закрытый ключ сохранены в `C:\DBSecurity\Backups`.
- Always Encrypted: столбец `HumanResources.EmployeePayHistory.Rate` зашифрован как `RANDOMIZED`.
- Always Encrypted: при обычном чтении `Rate` отображается как шифртекст.
- Dynamic Data Masking: в `HumanResources.EmployeePayHistoryMaskingDemo` аналитик видит точные `Rate`, но замаскированные `BusinessEntityID`.

## Снимок виртуальной машины

Рекомендуемое имя снимка: `After lab01 encryption masking`.

Описание снимка:

```text
Lab 01 is complete. AdventureWorks2017 is encrypted with TDE using AES_192.
The TDE certificate and private key are backed up to C:\DBSecurity\Backups.
HumanResources.EmployeePayHistory.Rate is encrypted with Always Encrypted as RANDOMIZED.
For Dynamic Data Masking, the HumanResources.EmployeePayHistoryMaskingDemo table was created:
the analyst can see exact Rate values, but BusinessEntityID values are masked.
```
