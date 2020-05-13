/*
    FILE: MapManager.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This class is used to manage the maps that can be used in the map form.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataAccessLayer;


namespace LogicLayer
{
    public class MapManager
    {
        List<Map> _mapList;

        public MapManager()
        {
            try
            {
                _mapList = MapDataAccessor.RetrieveMapList();
            }
            catch(Exception)
            {
                throw;
            }
        }

        // this is a list of the map objects that can be selected from the map
        // selection list.
        public List<Map> MapList
        {
            get { return _mapList; }
        }

    }
}
