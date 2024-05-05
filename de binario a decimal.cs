// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] A = { 1, 0, 1, 1, 0 };
Array.Reverse(A);
int s = 0;
for (int i = 0; i < A.Length; i++)
{
    if (A[i] == 1)
    {
        s = s + (int)Math.Pow(2, i);
    }
}
Console.WriteLine(s);
