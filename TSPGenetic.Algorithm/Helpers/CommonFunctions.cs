namespace TSPGenetic.Algorithm.Helpers
{
    public static class CommonFunctions
    {
        public static void SwapIfNotInOrder(ref int left, ref int right)
        {
            if (left > right)
            {
                var temp = left;
                left = right;
                right = temp;
            }
        }
    }
}
