﻿namespace Ex003;

public class Team
{
    public string Name { get; set; }

    public string Creator { get; set; }

    public List<string> Members { get; set; }

    public Team()
    {
    }

    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
        Members = new List<string>();
    }
}