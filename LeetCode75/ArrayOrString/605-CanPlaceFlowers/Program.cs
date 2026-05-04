namespace _605_CanPlaceFlowers;

class Program
{
    static void Main(string[] args)
    {
        int[] flowerbed = [1, 0, 0, 0, 0, 1];
        int n = 1;
        CanPlaceFlowers(flowerbed, n);
    }

    static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0)
        {
            return true;
        }

        int i = 0;
        while (i < flowerbed.Length)
        {
            if (flowerbed[i] == 1)
            {
                i += 2;
            }
            
            else if (flowerbed[i] == 0 && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                n--;
                i += 2;
            }
            
            else
            {
                i++;
            }
        }

        return n <= 0;
    }
}
