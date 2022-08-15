// вид1    <-----метод который ни чего не принимает и не чего не возвращает
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();



// Вид2 <-----метод который принимает аргумент но ничего не возвращает

void Method2(string msg){
    Console.WriteLine(msg);
}
 Method2("текст сообщения");

void Method2_0(string msg, int count){
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
 Method2_0("текст", 6); 
//  Method2_0 (msg:"Новый текст, count: 6) способы вызова методов.

// вид3  <----  методы что то возвращает, но не принимает аргументы

int Method3()
{
    return DateTime.Now.Year;
}
int yesrs = Method3();
Console.WriteLine(yesrs);

// вид 4  <---- методы которые что то принимают и что то возвращают

string Method4(int count,string c)
{
    int i = 0;
    string result = "";

    while(i<count){
        result = result + c;
        i++;
        
    }
    return result;
}
string res = Method4(5,"while");
Console.WriteLine(res);

// Через цикл фор

string Method4_1 (int count,string str)

{
    string result = string.Empty;
    for (int i =0; i<count; i++){
        result = result + str;
    }
    return result;
    }
string For = Method4_1(4,"for");
Console.WriteLine(For);