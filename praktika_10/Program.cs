//1)Числа Fibonacci

/* int Fibonacci(int N)
{
    if (N==1) return 1;
    else return  N+Fibonacci(N-1);
}
Console.WriteLine(Fibonacci(5));  */
//2)из букв вывести все значения
/* Console.WriteLine("Введите буквы из которых хотите собрать слово");
string words = Console.ReadLine().Split(" ").ToString();
string temp = words; */
/* int n =1;
void FineWords (string alphabet, char[] word, int length=0  )
{
    if(length==word.Length)
    {
        Console.WriteLine($"{n++} {new string(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length]=alphabet[i];
        FineWords(alphabet, word, length+1);
    }

}
FineWords("aисв", new char[2]); */

// в указанном диапазоне вывести все взаимно простые числа указанному число от А до В и вводим число N// без N

string NumberLook(int M, int N)
{   
    

    for (int i = M; i < N; i++)
    {
       if (i%2!=0 &&i%3!=0&&i%5!=0&&i%7!=0)
    {
    if(i==N) return N.ToString();
    else return i+" "+NumberLook(i+1,N);
    }
    if ((i/2<2&&i/3<=1||i%5==0||i%7==0)&&i<10)
    {
        return i+" "+NumberLook(i+1,N);
    } 
    }

    return " ";
    
    
    
}
Console.WriteLine(NumberLook(1,50));