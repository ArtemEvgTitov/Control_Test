// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

int WordCount(string[] array, int wordLenght){
 
    int wordCount = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= wordLenght)
            wordCount++;

    return wordCount;
}

void ShowArray(string[] array){ 
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] FillingArray (string[] array, int wordCount, int wordLenght){ 

    string[] newArray = new string[wordCount];

    for (int i = 0, j = 0; i < array.Length; i++){
        if (array[i].Length <= wordLenght){
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}


string[] Array = { "Hi", "Pavel", "I", "am", "writing", "a", "test", 
                "in", "C#", "It's", "good", "that", "I", "learned", "the", 
                "material", ":)", "Thank", "you", ":)" };

Console.Write("\nВведите длинну строк для сортировки: ");
int wordLenght = Convert.ToInt32(Console.ReadLine());

int wordCount = WordCount(Array, wordLenght);
string[] newArray = FillingArray(Array, wordCount, wordLenght);
ShowArray(newArray);