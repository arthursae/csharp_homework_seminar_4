// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int RequestUserToEnterData(string message)
{

    Console.Write(message);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;

}

double PowInt(int num, int pow)
{

    int storedNum = num;

    switch (pow) {

        case 0: // any number != 0 that is raised to power 0 equals = 1

            if (num == 0) {

                //Console.WriteLine("Ноль в степени ноль = " + Math.Pow(0,0)); // this statement returns 1
                //return 1; // Nothing in power of nothing is 1, really?
                return 0; // Let assume its 0

            }

            return 1;
            break;

        case < 0:

            for (int i = -1; i > pow; i--) {

                num *= storedNum;

            }
            
            double negPowResult = 1 / Convert.ToDouble(num);
            return negPowResult;
            break;

        default:

            for (int i = 1; i < pow; i++) {

                num *= storedNum;

            }

            double posPowResult = Convert.ToDouble(num);
            return posPowResult;
            break;

    }  

}

Console.Clear();
int numA = RequestUserToEnterData("Введите число: ");
int numB = RequestUserToEnterData("Введите натуральную степень в которую нужно возвести число " + numA + ": ");
double result = PowInt(numA, numB);
Console.WriteLine("Результат возведения числа " + numA + " в степень " + numB + " равен = " + result);
