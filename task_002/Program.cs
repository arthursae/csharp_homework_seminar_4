// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CalculateSumOfDigits(string userInput) 
{

    int userInputUInt = Math.Abs(Convert.ToInt32(userInput));
    int sumOfDigits = 0;
    
    int i = 0;

    while (userInputUInt > 0) {

        int num = userInputUInt % 10;
        sumOfDigits += num;
        userInputUInt = userInputUInt / 10;
        i++;
    }

    return sumOfDigits;

}

bool IsValidNumber(string stringToCheck)
{

    int x = 0;

    if (Int32.TryParse(stringToCheck, out x)) return true;

    return false;

}

string GetUserInputData(string message)
{

    Console.Write(message);
    string userInput = Console.ReadLine();

    if (IsValidNumber(userInput)) {

        return userInput;
 
    } 
    
    else {

        return GetUserInputData(message);

    }

}

Console.Clear();

string userInput = GetUserInputData("Введите целое натуральное число: ");
int sumOfDigits = CalculateSumOfDigits(userInput);
Console.WriteLine("Сумма цифр в числе " + userInput + " равна = " + sumOfDigits);
