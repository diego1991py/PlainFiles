using System.Globalization;
using System.Text;
using CsvHelper;

namespace Core;

public class CsvHelperExample
{
    // C#
    public void Write(string path, IEnumerable<Person> people)
    {
        var dir = Path.GetDirectoryName(path);
        if (!string.IsNullOrEmpty(dir))
            Directory.CreateDirectory(dir);

        using var sw = new StreamWriter(path, false, Encoding.UTF8);
        using var cw = new CsvWriter(sw, CultureInfo.InvariantCulture);
        cw.WriteRecords(people);
    }

    // C#
    public IEnumerable<Person> Read(string path)
    {
        if (!File.Exists(path))
            throw new FileNotFoundException($"CSV file not found: {path}", path);

        using var sr = new StreamReader(path);
        using var cr = new CsvReader(sr, CultureInfo.InvariantCulture);
        return cr.GetRecords<Person>().ToList();
    }
}