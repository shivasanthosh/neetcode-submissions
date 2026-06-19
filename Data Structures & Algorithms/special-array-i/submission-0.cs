public class Solution {
    public bool IsArraySpecial(int[] nums) {
        if(nums.Length == 1)
            return true;
        int x = 0;
        for(int i = 1; i<=nums.Length -1 ;i++)
        {
            int prev = nums[i-1];
            bool IsEven1 = prev%2==0;
            int curr = nums[i];
            bool IsEven2 = curr%2 ==0;

            if(IsEven1 != IsEven2 || !IsEven1!= !IsEven2)
            {
                continue;
            }
            return false;
        };
        return true;
    }
}