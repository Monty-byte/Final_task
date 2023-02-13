Console.Clear();

Console.Write("Введите количество слов, которые Вы хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(size);

string[] array = new string[size];

Console.WriteLine("Введите любые слова или символы через Enter: ");
for (int i = 0; i < size; i++)
{
    array[i] = Console.ReadLine() ?? "";
}
