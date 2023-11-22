System.Console.Write("Enter length of array: ");
int len = Convert.ToInt32(Console.ReadLine());

string[] start_array = new string[len];
string[] final_array = new string[len];

void Fill_Array(string[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        System.Console.Write($"Enter {index + 1} str for start array: ");
        array[index] = Console.ReadLine();
    }
}

void Print_Array(string[] array)
{
    System.Console.Write("[");
    for (int index = 0; index < array.Length; index++)
    {
        if (index == array.Length - 1)
            System.Console.Write(array[index]);
        else
            System.Console.Write($"{array[index]}, ");
    }
    System.Console.WriteLine("]");
}

string[] modify_final_arr(string[] start_array)
{
    int temp = 0;
    string[] final_array = new string[start_array.Length];
    for (int index = 0; index < start_array.Length; index++)
    {
        if (start_array[index].Length <= 3)
        {
            final_array[temp] = start_array[index];
            temp++;
        }
        else
            continue;
    }
    return final_array;
}

Fill_Array(start_array);
Print_Array(start_array);
final_array = modify_final_arr(start_array);
final_array = final_array.Where(x => x != null).ToArray();
Print_Array(final_array);