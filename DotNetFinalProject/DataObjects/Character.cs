/*
    FILE: Character.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This is where the character type lives. It holds the various properties that make up
        every character.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Character
    {
        public int MapRowLocation { get; set; }
        public int MapColumnLocation { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        
        public string Type { get; set; }
        public string Allignment { get; set; }
        public string Affiliation { get; set; }
        public string StatBlockFileName { get; set; }
        public string ImageFileName { get; set; }
        public String IdNumber { get; set; }
    }
}