# Итоговая проверочная работа
- Условие задачи:
  - Написать программу, которая из имеющегося массива строк формирует массив из строк,
    длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
    либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
    лучше обойтись исключительно массивами.
#### Просим пользователя ввести количество слов, для определения длины массива:
```
Console.Write("Введите количество слов, которые Вы хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(size);
```

#### Инициализируем массив и создаем цикл для его заполнения:
```
string[] array = new string[size];

Console.WriteLine("Введите любые слова или символы через Enter: ");
for (int i = 0; i < size; i++)
{
    array[i] = Console.ReadLine() ?? "";
}
```

#### Пишем метод для обработки полученного массива по условию задачи и через цикл записываем новый массив:
```
string[] GetArray(String[] arr)
{
    string[] str = new string[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i].Length <= 3)
        {
            str[i] = arr[i];
        }

    }
    return str;

}
```
#### Объявляем метод в новой переменной и выводим полученный результат в консоль:
```
string[] newstr = GetArray(array);
Console.Write("[{0}] -> [{1}]", string.Join(", ", array), string.Join(", ", newstr.Where(s => !string.IsNullOrEmpty(s))));
```