namespace AlgorithmsKatas
{
    public class FizzBuzz
    {
        //https://leetcode.com/problems/fizz-buzz/
        public IList<string> FizzBuzzes(int n)
        {
            List<string> result = new();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }

    }

}
