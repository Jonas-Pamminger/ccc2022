class TestClass
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine(args.Length);
    }

    static int CountAllLetters(string inp, char sol)
    {
        int count = 0;
        for(int i = 0; i < inp.Length; i++)
        {
            if(sol == inp[i])
            {
                count++;
            }
        }
        return count;
    }
}