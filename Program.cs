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


    int count = CountCorrectElements(inputArray);
    string[] newArray = new string[count];
    int index = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            newArray[index] = inputArray[i];
            index++;
        }
    }
    return newArray;
}


string[] startArray = {"start", "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "end"};
