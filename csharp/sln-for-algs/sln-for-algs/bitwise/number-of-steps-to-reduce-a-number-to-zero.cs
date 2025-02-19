namespace sln_for_algs.bitwise;
internal static class number_of_steps_to_reduce_a_number_to_zero
{
    public static float NumberOfSteps(int num)
    {
        int x = 0;
        while (num > 0)
        {
            if (num % 2 == 1)
                num--;
            else
                num /= 2;
            x++;
        }

        return x;
    }

    public static float NumberOfStepsBitwise(int num)
    {
        int x = 0;
        while (num > 0)
        {
            if ((num & 1) == 1)
                num--;
            else
                num>>=1;

            x++;
        }

        return x;
    }
}
/*
    110
   &001
    001

*/