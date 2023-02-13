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


string[] newstr = GetArray(array);
Console.Write("[{0}] -> [{1}]", string.Join(", ", array), string.Join(", ", newstr.Where(s => !string.IsNullOrEmpty(s))));

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