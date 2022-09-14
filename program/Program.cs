Console.Clear();
Console.WriteLine("#Task");

string[] GetNewArray() {
    int randomArraySize = new Random().Next(1,10);
    string[] str = new string[randomArraySize];
    return str;
}

string[] EnterWordToArray(string[] str) {

    Console.WriteLine($"Введите слова в количестве {str.Length} шт.:");

    for(int i = 0; i < str.Length; i++) {
        Console.Write($"Введите {i+1} слово: ");
        str[i] = Console.ReadLine();
    }

    return str;
}


