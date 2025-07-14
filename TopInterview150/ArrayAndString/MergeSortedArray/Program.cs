public class Program
{
    public static void Main(string[] args)
    {
        var program = new Program();
        int[] nums1 = [2, 0];
        int nums1Length = 1;
        int[] nums2 = [1];
        int nums2Length = 1;
        program.Merge(nums1, nums1Length, nums2, nums2Length);

        foreach (int number in nums1)
        {
            System.Console.Write($"{number}");
        }
    }

    public void Merge(int[] nums1,
                      int nums1Length,
                      int[] nums2,
                      int nums2Length)
    {
        int pointer1 = nums1Length - 1;
        int pointer2 = nums2Length - 1;
        int sortedCount = (nums1Length + nums2Length) - 1;

        while (pointer1 >= 0 && pointer2 >= 0)
        {
            if (nums1[pointer1] > nums2[pointer2])
            {
                nums1[sortedCount] = nums1[pointer1];
                pointer1--;
            }

            else
            {
                nums1[sortedCount] = nums2[pointer2];
                pointer2--;
            }

            sortedCount--;
        }

        //Copy remaining elements to nums1
        while (pointer2 >= 0)
        {
            nums1[sortedCount] = nums2[pointer2];
            sortedCount--;
            pointer2--;
        }
    }
}