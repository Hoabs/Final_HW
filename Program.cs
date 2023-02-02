string[] ModifyStringArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] res = new string[count];
    count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            res[count] = array[i];
            count++;
        }
    }

    return res;

}

