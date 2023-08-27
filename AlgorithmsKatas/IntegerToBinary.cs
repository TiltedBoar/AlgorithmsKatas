namespace AlgorithmsKatas
{
    //https://www.codewars.com/kata/55606aeebf1f0305f900006f/csharp
    public class IntegerToBinary
    {
        public string ToBinaryV2(int n)
        {
            string result = string.Empty;

            for (int i = 0; i < 32; i++)
            {
                result = (n & 1) + result;
                Console.WriteLine(n & 1);
                Console.WriteLine(result);
                n >>= 1;
            }
            int startindex = result.IndexOf('1');
            return result.Substring(startindex);
        }
        public string ToBinary(int n) => Convert.ToString(n, 2);
    }
}
