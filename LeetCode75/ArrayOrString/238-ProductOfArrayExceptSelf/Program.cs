namespace _238_ProductOfArrayExceptSelf;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = ProductExceptSelf(nums = [1, 2, 3, 4]);
        Console.WriteLine(string.Join(',', nums));
    }
    
    static int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[nums.Length];

        result[0] = 1;
        
        for (int i = 1; i < n; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        int suffixProduct = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= suffixProduct;
            suffixProduct *= nums[i];
        }
        
        return result;
    }
}