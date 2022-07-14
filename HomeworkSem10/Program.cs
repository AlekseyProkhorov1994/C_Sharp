

// Задача 1
/*
string[] CreateNewStrArray(int size)
 {
    string[] words = new string[size];
    for( int i = 0; i < size; i++)
     {
         Console.Write($"Input {i + 1} words:");
         words[i] = Console.ReadLine();
     }

     return words;
 }

void ShowArray (string[] array)
 {
     for(int i = 0; i < array.Length; i++)
         Console.Write(array[i] + " ");
         Console.WriteLine();
 }

int CounterVowel(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i].ToLower();
        if(array[i][0] == 'a' || array[i][0]  == 'i' || array[i][0]  == 'e' || array[i][0]  == 'o' || array[i][0]  == 'u' || array[i][0]  == 'y')
            count++;
    }
    return count;
}

Console.Write("Input num of words: "); 
int size = Convert.ToInt32(Console.ReadLine());
string[] words = CreateNewStrArray(size);
Console.Write(CounterVowel(words));*/


//Задача2

string[] CreateNewStrArray(int size)
 {
    string[] words = new string[size];
    for( int i = 0; i < size; i++)
     {
         Console.Write($"Input {i + 1} words:");
         words[i] = Console.ReadLine();
     }

     return words;
 }

 void ShowArray (string[] array)
 {
     for(int i = 0; i < array.Length; i++)
         Console.Write(array[i] + " ");
         Console.WriteLine();
 }

string[] SumSrtringArray(string[] array)
{
    string[] MyArray = new string[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i + 1} words of MyArray:");
        MyArray[i] = Console.ReadLine() + array[i];
        
    }

    return MyArray;

}

Console.Write("Input num of words: "); 
int size = Convert.ToInt32(Console.ReadLine());
string[] words = SumSrtringArray(CreateNewStrArray(size));
ShowArray(words);
