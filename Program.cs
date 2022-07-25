string[] MainTask(string[] inputArray)
{
    int CountCorrectElements(string[] arr)
    {
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3) result++;
        }
        return result;
    }

}