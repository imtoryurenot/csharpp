﻿void FillArray(int[] collection) // - войд (метод ничего не возвращает и поэтому не используем оператор return), 
// филлэррэй "название метода" + аргумент (коллекшн) 
{
    int length = collection.Length; // - длинна инт = длинна коллекции (массива)
    int index = 0; // - считаем всегда с 0, поэтому позиция 0
    while (index < length) // - пока индекс (0, 1 и тд) меньше длины - считать и добавлять единицу, как только дойдет до конечной точки = стоп
    {
        collection[index] = new Random().Next(1, 10); // - добавляем новое случайное число число из диапазона от 1 до 10
        //index = index +1;
        index++; // - каждый последующий раз добавлять единицу
    }
}

void PrintArray(int[] col) // - метод войд, который будет печатать массив уже с новым именем
{
    int count = col.Length; // - количество элементов 
    int position = 0; // - текущая позиция, но не через index, а через "position" считает начиная с нуля
    while (position < count) // - цикл = пока позиция меньше чем элемент (индекс меньше числа)
    {
        Console.WriteLine(col[position]); // - выводим значение текущего элемента
        position++; // - увеличиваем значение текущей позиции на 1
    }
}

 int IndexOf (int[] collection, int find) // - этот метод будет возвращать позиции (отличный от войд) называем его IndexOf
   // массив коллекшн какой-то элемент найти
{
    int count = collection.Length; // - определяем количество элементов
    int index = 0; // - нам нужны индексы
    int position = -1; // - еще одна позиция (-1 чтобы при попытке ввода числа которого не существует вместо 0 появлялась бы -1)
    
    while (index < count) // - будет проверять если индекс меньше чем каунт то сразу добавляем 1
    {
     if(collection[index] == find) // - если коллекшн индекс совпал
        {
        position = index; // - кладем сюда значение индекса
        break; // - добавляем оператор, который останавливает процесс на первом результате
        }
        index++; // добавляем 1 если индекс меньше чем каунт 
    }
    return position; // - когда цикл отработает мы ожидаем возврат позиции элемента
}

int[] array = new int[10]; // - определили массив из десяти элементов

FillArray(array); // - заполнил массив (аргумент = эррэй(название))
array[3] = 3;
array[5] = 3; // - принудительно добавили несколько четверок
PrintArray(array); // - вывел массив (отдельный метод напечатал)
Console.WriteLine(); // - выводим пустую строчку чтоб разделить и не сливалось в часть вывода массива

int pos = IndexOf(array, 3); // - дальше определяем переменную пос и в нее кладем результат работы метода indexOf 
//(аргумент будет передваться- тут наш массив) и ищем 4
Console.WriteLine(pos); // - метод отработает и на экране покажется пос