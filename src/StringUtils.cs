namespace BitBox
{
    public static class StringUtils
    {
        public static string? Reverse(string value)
        {
            int arrayLen = value.Length;
            char[] reversedString = new char[arrayLen];
            
            for (int i = 0; i < arrayLen; i++)
            {
                reversedString[i] = value[arrayLen - 1 - i];
            }
            
            return new string(reversedString);
        }
    }
}