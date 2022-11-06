//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ #41
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

Console.Write("Определите количество чисел, которые хотите ввести: ");
int size = int.Parse(Console.ReadLine()!);
int[] arr = new int [size];
for (int i = 0; i < arr.Length; i++){
    Console.Write("Введите число: ");
    arr[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"\nКоличество чисел больше 0 = {FindElement(arr)}");



//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ #43
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Доп.Задача (Если вдруг не можете решить 43, либо хотите решить для интереса)

//Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива –10. 
//Заполнение массива осуществить случайными числами от 50 до 100.

int[] array = GetArray(10, 50, 100); 
Console.WriteLine(String.Join(", ", array));
Console.WriteLine("Введите число от 50 до 100: ");
int n = int.Parse(Console.ReadLine()!);

if (CountElement(array, n) == 0){
    Console.WriteLine($"Чисел меньше заданного числа {n} в массиве нет");
}
else 
if (CountElement(array, n) == 1){
    Console.WriteLine($"В массиве есть только одно число меньше заданного числа {n}");
}
else{
    Console.WriteLine($"Произведение всех элементов массива меньших заданного числа {n} = {MultiplElement(array, n)}");
}














int FindElement (int[] collection){
    int count = 0;
    for (int i = 0; i < collection.Length; i++){
        if (collection[i] > 0){
            count += 1;
        } 
    }
    return count;
}


int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}


int MultiplElement (int[] arr, int num){
    int multipl = 1;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] < num){
            multipl *= arr[i]; 
        }
    }
    return multipl;
}

int CountElement (int[] arr, int num){
    int count = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] < num){
            count += 1;
        }
    }
    return count;
}