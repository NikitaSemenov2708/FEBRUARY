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
int n =1;
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
FineWords("aисв", new char[2]);

