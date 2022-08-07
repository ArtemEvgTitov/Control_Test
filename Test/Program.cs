// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

int WordCount(string[] array, int wordLenght)

void ShowArray(string[] array)

string[] FillingArray (string[] array, int wordCount, int wordLenght)


string[] Array = { "Hi", "Pavel", "I", "am", "writing", "a", "test", 
                "in", "C#", "It's", "good", "that", "I", "learned", "the", 
                "material", ":)", "Thank", "you", ":)" };
                
Console.Write("\nВведите длинну строк для сортировки: ");
int wordLenght = Convert.ToInt32(Console.ReadLine());