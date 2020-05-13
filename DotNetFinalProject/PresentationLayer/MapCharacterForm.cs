using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataObjects;
using LogicLayer;

namespace PresentationLayer
{
    public partial class MapCharacterForm : Form
    {
        CharacterManager _characterManager = new CharacterManager();
        List<Character> _characters = new List<Character>();
        MapManager _mapManager;
        //private static int _characterCount = 0;
        int _mapIndex;
       
        
        private CharacterListManager _characterListManager;
        //public static int CharacterCount { get { return _characterCount; } set {_characterCount = value; } }

        public MapCharacterForm(CharacterListManager characterListManager, MapManager mapManager, int mapIndex)
        {
            InitializeComponent();
            _characterListManager = characterListManager;
            _mapManager = mapManager;
            _mapIndex = mapIndex;
            //_characterIndex = characterIndex;
            //_mapForm = mapForm; // also shouldn't need this... I hope
        }

        // this function populates the character map list with a list of avialable characters that 
        // can be transferred and used on the map form.
        public void PopulateList() 
        {
            for (int i = 0; i < _characterManager.CharacterList.Count; i++)
            {
                this.lstCharacterSelect.Items.Add(_characterManager.CharacterList[i].Name);
                this.lstCharacterSelect.Items[this.lstCharacterSelect.Items.Count - 1].
                    SubItems.Add(_characterManager.CharacterList[i].Affiliation);
            }
        }

        // this form load thing has one job and that is to populate the listview with the various characters 
        // retrieved from file. Thus it gives the user a list of character choices with which to use in the 
        // Map form.
        private void MapCharacterForm_Load(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            // if the user doesnt higlight a choice before clicking the add character button the form will
            // a dialog box that prompts the user to make a selection
            if (this.lstCharacterSelect.SelectedIndices.Count > 0)
            {
                CharacterListManager.CharacterCount += 1;

                _characterListManager.Characters.Add // Adds selected character to list view in the map form
                    (_characterManager.CharacterList[this.lstCharacterSelect.SelectedIndices[0]]);

                // adds a unique number to the beginning of the character name for distinction while using 
                // map form
                _characterListManager.Characters[_characterListManager.Characters.Count - 1].Name
                    = CharacterListManager.CharacterCount + "_" +
                    _characterListManager.Characters[_characterListManager.Characters.Count - 1].Name;

                // adds a unique Id number property to the character created that coincides with the number
                // added to the beginning of the character name in the previous step
                _characterListManager.Characters[_characterListManager.Characters.Count - 1].IdNumber =
                    CharacterListManager.CharacterCount.ToString();
                PlaceNewCharacter();
                this.Close();
            }
            else
            { // dialog box that prompts the user to make a selection in the event that none was made
                MessageBox.Show("Please make a selection.");
            }


        }

        //public void CreateNewMapCharacter(CharacterListManager _characterListManager, int selectedIndex)
        //{
        //    CharacterListManager.CharacterCount += 1;

        //    _characterListManager.Characters.Add // Adds selected character to list view in the map form
        //        (_characterManager.CharacterList[this.lstCharacterSelect.SelectedIndices[0]]);

        //    // adds a unique number to the beginning of the character name for distinction while using 
        //    // map form
        //    _characterListManager.Characters[_characterListManager.Characters.Count - 1].Name
        //        = CharacterListManager.CharacterCount + "_" +
        //        _characterListManager.Characters[_characterListManager.Characters.Count - 1].Name;

        //    // adds a unique Id number property to the character created that coincides with the number
        //    // added to the beginning of the character name in the previous step
        //    _characterListManager.Characters[_characterListManager.Characters.Count - 1].IdNumber =
        //        CharacterListManager.CharacterCount.ToString();
        //}

        // this is a standard back button event that lets the user back out of the form without having
        // to make a selection. Essentially just the x corner button placed conveniently right in from 
        // of the user, the escape button can also be used to produce the same effect.
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // This method will take the character that the user has chosen and place it on the map in a place
        // where there are currently no other characters.
        public void PlaceNewCharacter()
        {
            bool hasBeenPlaced = false;
            for (int row = 0; row < 23; row++)
            {
                for (int col = 0; col < 27; col++)
                {
                    if (_mapManager.MapList[_mapIndex].MapGrid[row, col] == null && hasBeenPlaced == false)
                    {

                        _mapManager.MapList[_mapIndex].MapGrid[row, col]
                            = _characterListManager.Characters[_characterListManager.Characters.Count - 1].IdNumber;


                        _characterListManager.Characters[_characterListManager.Characters.Count - 1].MapRowLocation = row;
                        _characterListManager.Characters[_characterListManager.Characters.Count - 1].MapColumnLocation = col;
                        hasBeenPlaced = true;

                    }
                }
            }
        }
    }
}
