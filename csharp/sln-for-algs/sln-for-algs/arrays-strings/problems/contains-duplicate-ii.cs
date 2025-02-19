namespace sln_for_algs.arrays_strings.problems;
public static class contains_duplicate_ii
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> indexMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (indexMap.ContainsKey(nums[i]) && Math.Abs(i - indexMap[nums[i]]) <= k)
            {
                return true;
            }

            indexMap[nums[i]] = i;
        }

        return false;
    }
}
/*
 * 
 * nums[i] == nums[j] and abs(i - j) <= k
 * 
 * 
 Input: nums = [1,2,3,1], k = 3
 Output: true
 */