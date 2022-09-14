Console.Clear();
Console.WriteLine("#Task");

string[] GetNewArray() {
    int randomArraySize = new Random().Next(1,6);
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

string[] ConvertArray(int sizeLengthString, string[] str) {
    string[] newArray = new string[str.Length];
    int count = 0;
    // ищем элементы указанной длинны
    for(int i = 0; i < str.Length; i++) {
        if(str[i].Length <= sizeLengthString) {
            newArray[count] = (str[i]);
            count++;
        }
    }
    string[] resultArray = new string[count];
    // удаляем пустые элементы массива копируя в новый массив
    for(int i = 0; i < resultArray.Length; i++) {
        if(newArray[i] != "") {
            resultArray[i] = newArray[i];
        }
    }
    return resultArray;
}

void PrintResult(string[] str, int max) {
    string[] res = ConvertArray(max, str);
    if(res.Length == 0) {
        Console.WriteLine($"Результат: в массиве нет слов длинной меньше {max} символов.");
    } else {
        Console.WriteLine($"Результат: {string.Join(", ", res)}");
    }
}

string[] str = EnterWordToArray(GetNewArray());
int maxLengthWord = 3;

PrintResult(str, maxLengthWord);
