Console.Clear();
string[] str = new string[] {"hello", "2", "world", ":-)"};
string[] result = new string[str.Length];

void Arraytransform(string[]str, string[]result);
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
    }
    result[count] = str[i];
    count++;
}
}