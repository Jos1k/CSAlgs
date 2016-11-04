namespace Sorting.Algorithms
{
    public class MergeSort
    {
        public static int[] Sort(int[] inputData){

            int[] sortedArray = (int[]) inputData.Clone();

            return MergeSortRecursive(sortedArray, 0, sortedArray.Length - 1);
        }

        private static int[] MergeSortRecursive(
            int[] inputData, 
            int leftRange, 
            int rightRange
        ){
            if (leftRange < rightRange)
            {
                int divideElementIndex = (leftRange + rightRange) / 2;
                MergeSortRecursive(inputData, leftRange, divideElementIndex);
                MergeSortRecursive(inputData, divideElementIndex + 1, rightRange);
                SortAndMergeArrays(inputData, leftRange, divideElementIndex, rightRange);
            }
            return inputData;
        }

        private static void SortAndMergeArrays(
            int[] inputData, 
            int leftRange, 
            int divideElementIndex, 
            int rightRange
        ){
            int[] tempArray = new int[rightRange - leftRange + 1];
            int tempIndex = 0;
            int rightRangeStart = divideElementIndex + 1;

            while (leftRange <= divideElementIndex && rightRangeStart <= rightRange)
            {
                if (inputData[leftRange] < inputData[rightRangeStart])
                {
                    tempArray[tempIndex++] = inputData[leftRange++];
                }
                else
                {
                    tempArray[tempIndex++] = inputData[rightRangeStart++];
                }
            }
            while (leftRange <= divideElementIndex)
            {
                tempArray[tempIndex++] = inputData[leftRange++];
            }
            while (rightRangeStart <= rightRange)
            {
                tempArray[tempIndex++] = inputData[rightRangeStart++];
            }
            for (int i = tempArray.Length-1; i >= 0; i--)
            {
                inputData[rightRange--] = tempArray[i];
            }
        }
    }
}
