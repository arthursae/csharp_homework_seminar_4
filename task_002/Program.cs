// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CalculateSumOfDigits(string verifiedInput) 
{

    int sumOfDigits = 0;

    foreach(char digitChar in verifiedInput) {

        int digit = (int)Char.GetNumericValue(digitChar);
        sumOfDigits += digit;

    }

    return sumOfDigits;

}

bool CheckStringForNumericValues(string userInput)
{
    
    foreach (char singleChar in userInput) {

        int charToIntConverted = (int)Char.GetNumericValue(singleChar); // returns -1 if conversion fails
        
         if (charToIntConverted < 0) {

            return false;
            
        }

    }

    return true;

}

string GetUserInputData(string message)
{

    Console.Write(message);
    string userInput = Console.ReadLine();

    if (CheckStringForNumericValues(userInput)) {

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
