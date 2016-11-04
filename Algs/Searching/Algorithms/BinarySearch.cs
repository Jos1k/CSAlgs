namespace Searching.Algorithms
{
    public class BinarySearch
    {
        public static int Find(int[] data, int key)
        {
            return BinarySearchRecursive(data, key, 0, data.Length-1);
        }

        private static int BinarySearchRecursive(int[] data, int key, int left, int right)
        {
            if (right >= left)
            {
                
                int mid = left + (right - left)/2;
                if (data[mid] == key)
                {
                    return mid;
                }
                if (key > data[mid] )
                {
                    return BinarySearchRecursive(data, key, mid + 1, right);
                }
                if (key < data[mid])
                {
                    return BinarySearchRecursive(data, key, left, mid - 1 );
                }
            }

            return -1;
        }
    }
}
