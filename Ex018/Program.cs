// Напишите программу, к-ая по заданному номеру четверти, показывает диапозон
// возможных координат точек в этой четверти (х и у) 

// Console.WriteLine("Введите номер четверти: ");
// bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

// if (isNumberX != true)
// {
//     Console.WriteLine("Число введено не верно.");
//     return;
// }

// bool isValid = ValidateInput(x);
// if(isValid == false)
// {
//     Console.WriteLine($"{x} - неверный номер четверти");
//     return;
// }

// string result = GetCoordinates(x);
// Console.WriteLine(result);

// bool ValidateInput(int x)
// {
//     if (x > 4 || x < 1)
//     {
//         return false;
//     }
//     return true;
// }

// string GetCoordinates(int x)
// {
//     if (x == 1)
//     {
//         return "x > 0 && y > 0";
//     }

//     if (x == 2)
//     {
//         return "x < 0 && y > 0";
//     }

//     if (x == 3)
//     {
//         return "x < 0 && y < 0";
//     }

//     if (x == 4)
//     {
//         return "x > 0 && y < 0";
//     }
//     return "Координаты не найдены.";
// }


int Param = Convert.ToInt32(Console.ReadLine());
string GetCoordinates(int param)
{
    switch (param)
    {
        case 1: return "x>0;y>0";
        case 2: return "x<0;y>0";
        case 3: return "x<0;y<0";
        case 4: return "x>0;y<0";
        default: return ("Ошибка");
    }
}
string result = GetCoordinates(Param);
Console.WriteLine(result);