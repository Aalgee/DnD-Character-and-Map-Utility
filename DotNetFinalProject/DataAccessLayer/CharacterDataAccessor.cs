/*
    FILE: CharacterDataAccessor.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This file is the data accessor for the Character objects in my final project. It allows the
        program to access current objects from a csv and text files. It also allows the program to save newly
        entered Character types, and to edit current Character types.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using System.IO;

namespace DataAccessLayer
{
    public class CharacterDataAccessor
    {
        // This method is used to access the characters from file and instantiate them as objects of type character
        // within the program
        public static List<Character> RetrieveCharacterList()
        {
            List<Character> characterList = new List<Character>();
            char[] serperator = { ',' }; // Defines the seperator that the csv will be split by.
            try
            {
                StreamReader fileReader = new StreamReader(AppData.DataPath + @"\" + AppData.CharacterListFileName);
                while (fileReader.EndOfStream == false) // reads until the end of the file
                {
                    string line = fileReader.ReadLine();
                    string[] parts; // this is where the different parts of the csv line are temporarily stored
                    if (line.Length > 16)
                    {
                        parts = line.Split(serperator); // splits up the csv by its commas into its respective parts
                        if (parts.Count() == 7)
                        {
                            // this reads through the various parts of the charcterList.csv file and uses
                            // them to create a new objects of type Character. It will continue to do so
                            // until it reaches the end of the file.
                            Character newCharacter = new Character();
                            newCharacter.Name = parts[0];
                            newCharacter.Size = parts[1];
                            newCharacter.Type = parts[2];
                            newCharacter.Allignment = parts[3];
                            newCharacter.Affiliation = parts[4];
                            newCharacter.StatBlockFileName = parts[5];
                            newCharacter.ImageFileName = parts[6];

                            

                            characterList.Add(newCharacter); // All the parts are used to create a new Character object
                        }
                    }
                }
                fileReader.Close();
            }
            catch(Exception) // if there is an exception it is thrown or bubbled up towards the presentation layer
            {
                throw;
            }
            return characterList;
        } // End RetrieveCharacterList()

        // This method reads from a csv file to instantiate a new instance of a StatBlock type object.
        public static CharacterStatBlock RetrieveCharacterStatBlock(Character character)
        {
            CharacterStatBlock newCharacterStatBlock = new CharacterStatBlock();

            try
            {
                // This reads from a csv file and uses it to create a new StatBlock object
                StreamReader fileReader = new StreamReader(AppData.DataPath + @"\" + character.StatBlockFileName);
                newCharacterStatBlock.CharacterName = fileReader.ReadLine();
                newCharacterStatBlock.StatBlockText = fileReader.ReadToEnd();
                fileReader.Close();
            }
            catch(Exception) // if an exception occurs this will throw it up towards the presentation layer
            {
                throw;
            }
            return newCharacterStatBlock;
        } // End RetrieveCharacterStatBlock()

        // This method takes an updated Character object and CharacterStatBlock object and uses it to overwrite the current
        // files, effectively updating them.
        public static bool UpdateCharacter(int characterIndex, CharacterStatBlock characterStatBlock, List<Character> characterList)
        {
            try
            {
                // This overwrites the currently held StatBlock text file of the chosen character with the updated one.
                StreamWriter fileWriter = new StreamWriter(AppData.DataPath + @"\" + characterList[characterIndex].StatBlockFileName);
                fileWriter.WriteLine(characterStatBlock.CharacterName);
                fileWriter.WriteLine(characterStatBlock.StatBlockText);
                fileWriter.Close();

                // This overwrites the currentlyheld CharacterList.csv file with updated object information. Everytime
                // this update is done the entire csv is overwritten
                StreamWriter fileWriter2 = new StreamWriter(AppData.DataPath + @"\" + AppData.CharacterListFileName);
                foreach (Character character in characterList)
                {
                    fileWriter2.WriteLine(character.Name + "," +
                                        character.Size + "," +
                                        character.Type + "," +
                                        character.Allignment + "," +
                                        character.Affiliation + "," +
                                        character.StatBlockFileName + "," +
                                        character.ImageFileName);
                }
                fileWriter2.Close();
            }
            catch (Exception) // If there is an exception the method returns false.
            {
                return false;
            }
            return true; // If the method runs successfully it returns true.
        } // End UpdateCharacter

        // This method uses a Character object to save information to the charcterList.csv file. It also 
        // uses some text entered by the user to create a new charcter stat block file.
        public static bool AddCharacter(Character character, CharacterStatBlock characterStatBlock)
        {
            try
            {
                // This adds a new stat block text file to a user chosen filename.
                StreamWriter fileWriter = new StreamWriter(AppData.DataPath + @"\" + character.StatBlockFileName);
                fileWriter.WriteLine(characterStatBlock.CharacterName);
                fileWriter.Write(characterStatBlock.StatBlockText);
                fileWriter.Close();

                // This adds a new character to the CharacterList.csv file.
                StreamWriter fileWriter2 = new StreamWriter(AppData.DataPath + @"\" + AppData.CharacterListFileName, true);
                fileWriter2.WriteLine(character.Name + "," +
                                        character.Size + "," +
                                        character.Type + "," +
                                        character.Allignment + "," +
                                        character.Affiliation + "," +
                                        character.StatBlockFileName + "," +
                                        character.ImageFileName);
                fileWriter2.Close();
            }
            catch (Exception) // If there is an exception the method returns false.
            {
                return false;
            }
            return true; // If the method runs successfully it returns true.
        } // End AddCharacter()
    }
}
