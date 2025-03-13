namespace sln_for_algs.arrays_strings.problems;
internal static class best_time_to_buy_and_sell_stock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int l_v = 11234;
            int profit = 0;
            for(int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < l_v)
                {
                    l_v = prices[i];                    
                }
                else
                {
                    if ((prices[i] - l_v) > profit)
                        profit = prices[i] - l_v;
                }
            }

            return profit;
        }
    }


    public static void main()
    {
        var s = new Solution();
        Console.WriteLine(s.MaxProfit([7, 1, 5, 3, 6, 4])); //5
        Console.WriteLine(s.MaxProfit([7, 6, 4, 3, 1])); //0
        Console.WriteLine(s.MaxProfit([])); //0
    }
}
