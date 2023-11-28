using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class LoadAndWrite
{
    public static string Card(string question)
    {
        Console.WriteLine(question);
        string filename = Console.ReadLine();
        return $"{filename}.json";
    }

    public static void SaveEntriesToFile(List<Entry> entries)
    {
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string fileName = Card("What is the file name");
        string jsonString = JsonSerializer.Serialize(entries, options);
        File.WriteAllText(fileName, jsonString);
    }

    public static List<Entry> ReadEntriesFromFile()
    {
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string fileName = Card("What is the file name?");
        string jsonString = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<List<Entry>>(jsonString, options);
    }
}