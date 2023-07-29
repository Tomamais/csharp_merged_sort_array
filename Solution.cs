public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // it should merge nums2 into nums1 in non-decreasing order
        // m + n is the final size of the array of elements
        // nums2 can be changed freely
        // do not return anything!
        int cap = m + n - 1;

        // exceptions
        if (m > 0)
        {
            m--;
        }
        if (n > 0)
        {
            n--;
        }
        else 
        {
            return;
        }

        while (cap >= 0)
        {
            if (nums1[m] > nums2[n])
            {
                nums1[cap] = nums1[m--];
            }
            else if (nums1[m] < nums2[n])
            {

                nums1[cap] = nums2[n--];
            }
            else
            {
                nums1[cap--] = nums2[n--];
                nums1[cap--] = nums1[m--];
            }

            cap--;
        }

        Console.WriteLine("[{0}]", string.Join(", ", nums1));
    }
}