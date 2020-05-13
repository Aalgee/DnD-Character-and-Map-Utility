/*
    FILE: AppData.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This file is used to hold data paths that my program uses to access its object information from file.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class AppData
    {
        public static string DataPath { get; set; }
        public static string MapDataPath { get; set; } 
        public static string CharacterListFileName = "characterList.csv";
        public static string MapListFileName = "mapList.csv";
    }
}
