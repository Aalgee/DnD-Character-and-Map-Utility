/*
    FILE: Map.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This object is just what it says its a map, with everything that goes along with that. It has
        a 23 by 27 grid for every map, a Name, and a filename for the background image that accompanies
        the map.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Map
    {
        String[,] _mapGrid = new String[23,27];
        
        public String MapName { get; set; }
        public String[,] MapGrid { get { return _mapGrid; } set { _mapGrid = MapGrid; } }
        public String ImageFilename { get; set; }
    }
}
