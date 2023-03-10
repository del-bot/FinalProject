void FindSM (string[] FirstArray, string[] SecondArray)
{
    int k = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if(FirstArray[i].Length <= 3)
        {
            SecondArray[k] = FirstArray[i];
            k++;
        }
    }
}

void PrintArray(string [] printArray)
{
    for (int i = 0; i < printArray.Length; i++)
    {
        Console.Write($"{printArray[i]}");
    }
    Console.WriteLine();
}

string [] UseFirstArray = new string [4]{"hello","2","world",":-)"};
string [] SecArray = new string[UseFirstArray.Length];

FindSM(UseFirstArray, SecArray);
PrintArray(SecArray);