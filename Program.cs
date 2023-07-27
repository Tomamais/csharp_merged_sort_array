// See https://aka.ms/new-console-template for more information
var solution = new Solution();

// test case 1
var nums1 = new int[] { 1,2,3,0,0,0 };
var nums2 = new int[] { 2,5,6 };
solution.Merge(nums1, 3, nums2, 3);
// expected
Console.WriteLine("Expected: [1, 2, 2, 3, 5, 6]");

// test case 2
nums1 = new int[] { 1 };
nums2 = new int[] { };
solution.Merge(nums1, 1, nums2, 0);
// expected
Console.WriteLine("Expected: [1]");

// test case 3
nums1 = new int[] { 0 };
nums2 = new int[] { 1 };
solution.Merge(nums1, 0, nums2, 1);
// expected
Console.WriteLine("Expected: [1]");
