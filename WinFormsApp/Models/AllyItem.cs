﻿namespace WinFormsApp.Models
{
    public class AllyItem
    {
        public AllyItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}