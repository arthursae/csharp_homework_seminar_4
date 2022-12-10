// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


bool IsValidNumber(string stringToCheck)
{

    int x = 0;

    if (Int32.TryParse(stringToCheck, out x)) {

        int number = int.Parse(stringToCheck);
        return true;

    }

    return false;

}

string GetUserInputData(string message)
{

    Console.Write(message);
    string userInput = Console.ReadLine();
    return userInput;

}

int GetNumberOfElements(string message)
{

    string userInput = GetUserInputData(message);

    if (IsValidNumber(userInput)) {
        
        int numOfElements = Math.Abs(Convert.ToInt32(userInput));
        return numOfElements;
    
    } 
        
    else {

        return GetNumberOfElements(message);

    }

}

int[] BuildArrayOfUserInputElements(int numberOfElements) {

    int[] numbersArray = new int[numberOfElements];

    for (int i = 0; i < numberOfElements; i++) {
        int order = i + 1;
        string userInput = GetUserInputData("Введите " + order + "-е число: ");

        if (IsValidNumber(userInput)) {

            int number = Convert.ToInt32(userInput);
            numbersArray[i] = number;

        }

        else {

            Console.WriteLine("Введите целое число для каждого элемента: ");
            return BuildArrayOfUserInputElements(numberOfElements);

        }


    }

    return numbersArray;

}

void OutputElementsArray(int[] elementsArray)
{
    int length = elementsArray.Length;
    string prefix = "Массив из " + length + " элементов -> [";
    string suffix = "]";
    string comma = ", ";

    Console.Write(prefix);

    for (int i = 0; i < length; i++) {

        if (i == length - 1) {

            comma = "";

        } 

        Console.Write(elementsArray[i] + comma);

    }

    Console.Write(suffix);

}

Console.Clear();
int numberOfElements = GetNumberOfElements("Введите количество элементов в массиве: ");
int[] elementsArray = BuildArrayOfUserInputElements(numberOfElements);
OutputElementsArray(elementsArray);
