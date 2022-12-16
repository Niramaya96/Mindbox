# Задача на C#

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры

- Проверку на то, является ли треугольник прямоугольным"

# Задача на SQL

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Решение: 

## 1) Создадим Таблицы:

```
  CREATE TABLE Products(id INT PRIMARY KEY, name VARCHAR(255) NOT NULL);
  CREATE TABLE Category(id INT PRIMARY KEY, name VARCHAR(255) NOT NULL);
  CREATE TABLE ProductCategories(products_id INT NOT NULL, category_id INT NOT NULL);
```
  
  
## 2) Заполним таблицы:
```
INSERT INTO Products VALUES(1, 'Порошок'), (2, 'Мыло'), (3, 'Яблоко'), (4, 'Спортивная куртка');
INSERT INTO Category VALUES(1, 'Хоз-товары'), (2, 'Продукты питания');
INSERT INTO ProductCategories VALUES(1, 1), (2, 1), (3, 2);
```

## 3) Выполним запрос:
```
    SELECT prod.name [Product], cat.name [Category] FROM Products prod 
      LEFT JOIN ProductCategories prodcat ON prod.id = prodcat.products_id 
      LEFT JOIN Category cat ON cat.id = prodcat.category_id 
    ORDER BY prod.name;
 ```
 В результате мы получим таблицу с продуктами и соответстующими им категориями, и если для продукта нет категории, то отобразится имя продукта, а в столбце категории будет NULL.
