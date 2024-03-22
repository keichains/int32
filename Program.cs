namespace int32
{
    public class IntStruct
    {
        static void Main()
        {
            int num; string snum;
            Console.Write("Enter a number: "); snum = Console.ReadLine(); num = Int32.Parse(snum);
            Console.WriteLine(num);
        }

    }
}