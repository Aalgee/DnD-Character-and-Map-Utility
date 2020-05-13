/*
    FILE: CharacterListManager.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This class is used to manage the list of characters that is seen when using the map utility, since it
        needs to use a different list of characters than the Character viewer and editor utility I just put it
        into it's own manager
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataObjects;

namespace LogicLayer
{
    public class CharacterListManager
    {
        List<Character> _characters = new List<Character>();

        // We instantiate the _characterManager because we need to use the characters from it's list
        CharacterManager _characterManager = new CharacterManager(); 
        static int _characterCount = 0; // this is used when assigning a unique number to our characters in the map utility
        public static int CharacterCount { get{ return _characterCount ;} set{ _characterCount = value; } }

        
        public CharacterListManager()
        {
            _characters = new List<Character>();
        }

        public List<Character> Characters
        {
            get { return _characters; }
        }

       

    }
}
