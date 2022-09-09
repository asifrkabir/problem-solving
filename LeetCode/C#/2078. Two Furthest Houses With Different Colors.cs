public class Solution
{
    public int MaxDistance(int[] colors)
    {
        if (colors.Length == 2)
        {
            return 1;
        }
        else
        {
            var dist1 = 0;
            var dist2 = 0;

            for (var i = colors.Length - 1; i > 0; i--)
            {
                if (colors[0] != colors[i])
                {
                    dist1 = i;
                    break;
                }
            }

            for (var i = 0; i < colors.Length - 2; i++)
            {
                if (colors[i] != colors[colors.Length - 1])
                {
                    dist2 = colors.Length - i - 1;
                    break;
                }
            }

            return Math.Max(dist1, dist2);
        }
    }
}