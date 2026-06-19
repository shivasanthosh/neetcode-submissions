public class Solution {
    public int[] GetConcatenation(int[] nums) {
        List<int> r = new List<int>();
        for(int i =0 ;i<2;i++)
        {
            for(int j =0 ;j< nums.Length ; j++)
            {
                r.Add(nums[j]);
            }
        }
        return r.ToArray();
    }
}