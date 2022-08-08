void FillArray(int[] collection){ // метод для заполнения массива случайными числами
    int length = collection.Length; // определяем длину входного массива и записываем в переменую
    int index = 0; // счетчик
    while (index<length){
        collection[index] = new Random().Next(1,9); // генератор случайных целых чисел, с диапозоном
        index++;
    }
}

void PrintArray(int[] col){ // метод вывода всех чисел массива в качестве аргумента используется созданый массив
    int count =col.Length; // получение длины массива и запись в переменную
    int position = 0;  
    while (position < count){
        Console.Write(col[position]); // печать каждого значения элемента массива
        position++; 
    }
}

int IndexOf(int[] collection, int find){ // поиск элемента массива, первый аргумент массив, второй аргумент число которое необходимо найти
    int count = collection.Length; // запись длины входного массива в переменную
    int index = 0;
    int position = -1; //ставиться значение -1 для того, если искомого эленета нет то выводил "-1" а не 0(так как 0 это и есть элемент массива)
    while (index < count){
        if (collection[index] == find){
            position = index; // найденая позиия
            break;// первая найденая позиция заканчивает цикл
        }
        index++;    
    }
    return position;    // возвращает найденый индекс
}


int[] array = new int[12];  //создание массива(все элементы будут равны 0
FillArray(array); //заполение созданого массива случайными числами. в качестве аргумента передаем имя массива
PrintArray(array);// вывод всех чисел массива 
Console.WriteLine ();
int pos = IndexOf(array,4); // передаем в переменую результат поиска элемента.первый агрумент имя массива, 
                            // второй элемент число которое надо найти
Console.WriteLine(pos);