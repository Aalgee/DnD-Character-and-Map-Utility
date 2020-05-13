/*
    FILE: MapDataAccessor.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This file is the data accessor for the Map objects in my final project. It allows the
        program to access current Map objects from a csv file.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace DataAccessLayer
{
    public class MapDataAccessor
    {
        //This method retrieves a list of available maps for use from a csv file and returns it to the calling code. 
        public static List<Map> RetrieveMapList()
        {
            List<Map> mapList = new List<Map>(); // Creates a new empty list of maps.
            char[] serperator = { ',' }; 
            try
            {
                StreamReader fileReader = new StreamReader(AppData.MapDataPath + @"\" + AppData.MapListFileName);
                while (fileReader.EndOfStream == false)
                {
                    string line = fileReader.ReadLine();
                    string[] parts;
                    if (line.Length > 16)
                    {
                        parts = line.Split(serperator);
                        if (parts.Count() == 2)
                        {
                            Map newMap = new Map();
                            newMap.MapName = parts[0]; // adds a name to the newMap object
                            newMap.ImageFilename = parts[1]; // adds an image filename to the newMap object                                                                                                       
                            mapList.Add(newMap); // adds the newMap object to the mapList list
                        }
                    }
                }
                fileReader.Close(); 
            }
            catch (Exception)
            {
                throw; // throws any exception up to the code that called this method
            }

            return mapList;
        }
    }
}
