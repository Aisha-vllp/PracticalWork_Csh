using System.IO;
using System.Dynamic;

public enum StringSearchOption
{
    StartsWith,
    Contains,
    EndsWith
}

class ReadOnlyFile : DynamicObject
{
    private string p_filePath;

    public ReadOnlyFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new Exception("File path does not exist.");
        }
        p_filePath = filePath;
    }

    public List<string> GetPropertyValue(string propertyName,
        StringSearchOption searchOption = StringSearchOption.StartsWith,
        bool trimSpaces = true)
    {
        StreamReader sr = null;
        List<string> results = new List<string>();
        string line = "";
        string testLine = "";
        try
        {
            sr = new StreamReader(p_filePath);
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                testLine = line.ToUpper();
                if (trimSpaces) { testLine = testLine.Trim(); }
                switch (searchOption)
                {
                    case StringSearchOption.StartsWith:
                        if (testLine.StartsWith(propertyName.ToUpper())) { results.Add(line); }
                        break;
                    case StringSearchOption.Contains:
                        if (testLine.Contains(propertyName.ToUpper())) { results.Add(line); }
                        break;
                    case StringSearchOption.EndsWith:
                        if (testLine.EndsWith(propertyName.ToUpper())) { results.Add(line); }
                        break;
                }
            }
        }
        catch
        {
            results = null;
        }
        finally
        {
            if (sr != null) { sr.Close(); }
        }
        return results;
    }

    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
        result = GetPropertyValue(binder.Name);
        return result != null;
    }

    public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
    {
        StringSearchOption searchOption = StringSearchOption.StartsWith;
        bool trimSpaces = true;

        if (args.Length > 0)
        {
            searchOption = (StringSearchOption)args[0];
        }
        if (args.Length > 1)
        {
            trimSpaces = (bool)args[1];
        }
        result = GetPropertyValue(binder.Name, searchOption, trimSpaces);
        return result != null;
    }
}