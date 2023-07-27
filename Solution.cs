public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int num1Index = 0;
        int num2Index = 0;
        int outputIndex = 0;
        int[] output = new int[m + n];

        while (outputIndex < m + n)
        {
            if(num1Index >= m && num2Index < n)
            {
                output[outputIndex] = nums2[num2Index];
                outputIndex++;
                num2Index++;
                continue;
            }
            if(num1Index < m && num2Index >= n)
            {
                output[outputIndex] = nums1[num1Index];
                outputIndex++;
                num1Index++;
                continue;
            }

            if (nums1[num1Index] == nums2[num2Index])
            {
                output[outputIndex] = nums1[num1Index];
                outputIndex++;
                output[outputIndex] = nums2[num2Index];
                outputIndex++;
                num1Index++;
                num2Index++;
            }
            else if(nums1[num1Index] < nums2[num2Index] && num1Index < m)
            {
                output[outputIndex] = nums1[num1Index];
                outputIndex++;
                num1Index++;
            }
            else if(nums1[num1Index] > nums2[num2Index] && num2Index < n)
            {
                output[outputIndex] = nums2[num2Index];
                outputIndex++;
                num2Index++;
            }
        }

        Console.WriteLine("[{0}]", string.Join(", ", output));
    }
}