/*                      Заменить все пробелы в тексте черточками, маленькие буквы "к"
                          поменять на большие "К", тоже самое с буквами "С"
*/

// string text = "- Я думаю, сказал князь, улыбаясь, - что, "
                // + "ежели бы вас послали вместо нашего милого Винценгороде, "
                // + "вы бы взяли приступом согласие прусского короля."
                // + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345

// string Replace(string text, char oldValue, char newValue)
// {
    // string result = string.Empty;
    // int length = text.Length;
    // for (int i = 0; i < length; i++)
    // {
        // if (text[i] == oldValue) result = result + $"{newValue}";
        // else result = result + $"{text[i]}";
    // }
    // return result;
// }
// 
// string newText = Replace(text, ' ', '|');
// newText = Replace(newText, 'к', 'К');
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();

//                                  Сортировка массива

int[] arr = {4,6,3,2,67,8,4,39,64,34};
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}

void Reformation(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        // int maxIndex = i;
        int maxIndex = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j]>array[maxIndex]) maxIndex = j;      
        }        
        int temp = array[i];
        array[i] = array[maxIndex];
        array[maxIndex] = temp;
    }

}
PrintArray(arr);
Reformation(arr);
Console.WriteLine();
PrintArray(arr);

       
