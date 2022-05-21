//Задача 2
// По заданному номеру четверти показать возможный диапазон точек

//Console.WriteLine("Введите номер четверти");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number == 1) Console.WriteLine("Возможные координаты: x от 0 до бесконечности, у от 0 до бесконечности");
//if (number == 2) Console.WriteLine("Возможные координаты: x от минус бесконечности до 0, у от 0 до бесконечности");
//if (number == 3) Console.WriteLine("Возможные координаты: x от минус бесконечности до 0, у от минус бесконечности до 0");
//if (number == 4) Console.WriteLine("Возможные координаты: x от 0 до бесконечности, у от минус бесконечности до  0");

//Другое решение

Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

string koordinates = Coordinates(number);
Console.WriteLine(koordinates);

string Coordinates(int number)
{
    string result = " ";
    if (number == 1) { result = "Возможные координаты: x от 0 до бесконечности, у от 0 до бесконечности";}
    else if (number == 2) { result = "Возможные координаты: x от минус бесконечности до 0, у от 0 до бесконечности";}
    else if (number == 3) { result = "Возможные координаты: x от минус бесконечности до 0, у от минус бесконечности до 0";}
    else if (number == 4) { result = "Возможные координаты: x от 0 до бесконечности, у от минус бесконечности до  0";}

    return result;
}
