namespace BitBox;

public static class FileUtils
{
    public static bool ShareSubdirectories(string path1, string path2)
    {
        if (!Directory.Exists(path1) || !Directory.Exists(path2))
        {
            throw new DirectoryNotFoundException("One or more of the provided directories do not exist.");
        }

        var subs1 = Directory.GetDirectories(path1, "*", SearchOption.TopDirectoryOnly);
        var subs2 = Directory.GetDirectories(path2, "*", SearchOption.TopDirectoryOnly);

        Dictionary<int, string> subs1Hash = new Dictionary<int, string>();
        for (int i = 0; i < subs1.Length; i++)
        {
            subs1Hash.Add(i, subs1[i]);
        }




    }
}