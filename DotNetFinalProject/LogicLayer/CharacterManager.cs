/*
    FILE: CharacterManager.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This file is used to hold the CharacterManager class. This class has many methods
        pertaining to the managment of our data objects and how the rest of the program 
        uses them.
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
    public class CharacterManager
    {
        // This list will hold all of our characters in a convenient place from which we can
        // extract them from at a later date
        List<Character> _characterList;

        public CharacterManager()
        {
            try
            {
                _characterList = CharacterDataAccessor.RetrieveCharacterList();
            }
            catch(Exception)
            {
                throw;
            }
        } // End CharacterManager

        public List<Character> CharacterList
        {
            get { return _characterList; }
        }

        // This method will return a stat block that correlates to the character index given
        public CharacterStatBlock FetchCharacterStatBlock(int CharacterIndex)
        {
            try
            {
                return CharacterDataAccessor.RetrieveCharacterStatBlock(_characterList[CharacterIndex]);
               
            }
            catch (Exception)
            {
                throw new ApplicationException("Stat Block wasn't found.");
            }
        } // End of FetchCharacterStatBlock()


        // This method will take a character and a stat block to replace on that is already in the character list
        // at the index that is entered.
        public List<Character> EditCharacter(Character character, CharacterStatBlock characterStatBlock, int characterIndex)
        {
            try
            {
                _characterList[characterIndex] = character;
                if (CharacterDataAccessor.UpdateCharacter(characterIndex, characterStatBlock, _characterList))
                {
                    _characterList = CharacterDataAccessor.RetrieveCharacterList();
                    return _characterList;
                }
                return _characterList;
            }
            catch (Exception)
            {
                throw;
            }
        } // End EditCharacter()


        // This method takes a character that will be added to the characterlist.csv file and a statblock that will
        // saved to a a seperate file.
        public List<Character> AddCharacter(Character character, CharacterStatBlock characterStatBlock)
        {
            try
            {
                if (CharacterDataAccessor.AddCharacter(character, characterStatBlock))
                {
                    _characterList = CharacterDataAccessor.RetrieveCharacterList();
                }
                return _characterList;
            }
            catch (Exception)
            {
                throw;
            }
        } // End AddCharacter()
    }
}
