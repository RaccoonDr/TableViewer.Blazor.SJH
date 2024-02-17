﻿namespace TableViewerTest;

public class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Dictionary<string, object>? Attributes { get; set; }
}

public record PersonRecord(int Id, string? Name, Dictionary<string, object>? Attributes);
