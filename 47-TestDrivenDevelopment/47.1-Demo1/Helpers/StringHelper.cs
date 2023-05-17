namespace Helpers;

public class StringHelper
{
    public static string RemoveUnnecessarySpaces(string s)
    {
        s = s.Trim();

        string newS = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ' && s[i + 1] == ' ')
                continue;

            newS += s[i];
        }

        return newS;
    }
}
