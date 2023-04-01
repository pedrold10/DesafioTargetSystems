using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Insira uma palavra:");
        string str = Console.ReadLine();
        char[] arr = str.ToCharArray();

        for (int i = 0, j = arr.Length - 1; i < j; i++, j--) {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        string reversed = new string(arr);
        Console.WriteLine($"=====================================\n");
        Console.WriteLine($"Palavra original:\n{str}");
        Console.WriteLine($"Palavra invertida:\n{reversed}"); 
    }
}
