/*
    FILE: CharacterStatBlockForm.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This form displays the map part of the map utility. It can be used to move "characters" represented
        by numbers on a map that has a one of various dungeon image backgrounds.
*/

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
    public partial class MapForm : Form
    {
        // when instantiating this class we have to pass a MapManager object and a CharacterListManager object to
        // it, this is where they are stored for later use
        private MapManager _mapManager;
        private int _mapIndex;
        private CharacterManager _characterManager;
        private CharacterListManager _characterListManager;

        // This constructor loads the mapManager, characterListManager, and the map index into their respective
        // instance variables
        public MapForm(MapManager mapManager, int mapIndex, CharacterListManager characterListManager)
        {
            
            InitializeComponent();
            _mapIndex = mapIndex;
            _mapManager = mapManager;
            _characterListManager = characterListManager;
            try
            {
                this.lstMap.BackgroundImage = Image.FromFile(AppData.MapDataPath + @"\" + _mapManager.MapList[mapIndex].ImageFilename);
            }
            catch(Exception)
            {
                // message shown if the map chosen is not in the appropriate file
                MessageBox.Show("Could not find the map you selected");
                
                this.Close();
                
            }
            //_characterListManager.addCharacters(0);
            PopulateList();

        }

        public MapForm(CharacterManager characterManager, int addCharacterIndex)
        {
            InitializeComponent();
            _characterManager = characterManager;

        }

        // When the form is loaded a new empty character List manageger object is instantiated
        private void MapForm_Load(object sender, EventArgs e)
        {
            CharacterListManager _characterListManager = new CharacterListManager();
            PopulateMap();
            
            
        }

        // This uses the mapmanager to fill the displayed map with the various "characters". It is used throughout
        // the class as a means to update the map anytime a character is moved.
        private void PopulateMap()
        {
            this.lstMap.Items.Clear();
            for (int i = 0; i < 23; i++)

            {
                this.lstMap.Items.Add(_mapManager.MapList[_mapIndex].MapGrid[i, 0]);
                for (int j = 1; j < 27; j++)
                {
                    this.lstMap.Items[this.lstMap.Items.Count - 1].SubItems.Add(_mapManager.MapList[_mapIndex].MapGrid[i, j]);
                    
                }
            }
        }

        // This method is used to populate the character list used for the map form. Here we use
        // the CharacterListManager type to manage the underlying character list.
        public void PopulateList()
        {
            this.lstCharacters.Items.Clear();
            for (int i = 0; i < _characterListManager.Characters.Count; i++)
            {
                try
                {
                    this.lstCharacters.Items.Add(_characterListManager.Characters[i].Name);
                }
                catch (Exception)
                {
                    this.lstCharacters.Items.Add("defeated Character");
                    
                }
            }
        }

        // This takes the user to the add character form where they can choose a character to add to the map.
        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            var mapCharacterForm = new MapCharacterForm(_characterListManager, _mapManager, _mapIndex);
            mapCharacterForm.ShowDialog();
            mapCharacterForm.Close();
            PopulateList();
            //PlaceNewCharacter();
            PopulateMap();
        }

        // Here we update a characters position on the map, since the characters keep track of theirs own
        // position on the map it is simply a matter of matching the character's position with the map column
        // and row.
        public void UpdateCharacterPosition(int selectedIndex)
        {

            int characterRow = _characterListManager.Characters[selectedIndex].MapRowLocation;
            int characterColumn = _characterListManager.Characters[selectedIndex].MapColumnLocation;
            string characterName = _characterListManager.Characters[selectedIndex].IdNumber.ToString();
            _mapManager.MapList[_mapIndex].MapGrid[characterRow, characterColumn] = characterName;
            
            PopulateMap();
        }

        // This will let us move the highlighted character downward on the map.
        private void btnDown_Click(object sender, EventArgs e)
        {
            
            if (this.lstCharacters.SelectedIndices.Count > 0)
            {
                try
                {
                    
                    int selectedIndex = this.lstCharacters.SelectedIndices[0];
                    int characterRow = _characterListManager.Characters[selectedIndex].MapRowLocation;
                    int characterColumn = _characterListManager.Characters[selectedIndex].MapColumnLocation;

                    if (_mapManager.MapList[_mapIndex].MapGrid[characterRow + 1, characterColumn] != null)
                    {
                        MessageBox.Show("You can't run over other characters");
                    }
                    else
                    {

                        _characterListManager.Characters[selectedIndex].MapRowLocation += 1;
                        _mapManager.MapList[_mapIndex].MapGrid[characterRow, characterColumn] = null;
                        UpdateCharacterPosition(selectedIndex);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("You cant go down off the map.");
                }                               
            }
            else
            {
                MessageBox.Show("Pleaee highlight a Character to move.");
            }
        }

        // This will let us move the highlighted character upward on the map.
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (this.lstCharacters.SelectedIndices.Count > 0)
            {
                try
                {
                    int selectedIndex = this.lstCharacters.SelectedIndices[0];
                    int characterRow = _characterListManager.Characters[selectedIndex].MapRowLocation;
                    int characterColumn = _characterListManager.Characters[selectedIndex].MapColumnLocation;

                    if (_mapManager.MapList[_mapIndex].MapGrid[characterRow - 1, characterColumn] != null)
                    {
                        MessageBox.Show("You can't run over other characters");
                    }
                    else
                    {

                        _characterListManager.Characters[selectedIndex].MapRowLocation -= 1;
                        _mapManager.MapList[_mapIndex].MapGrid[characterRow, characterColumn] = null;
                        UpdateCharacterPosition(selectedIndex);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("You cant go up off the map.");
                }
            }
            else
            {
                MessageBox.Show("Pleaee highlight a Character to move.");
            }
        }

        // This will let us move the highlighted character right on the map.
        private void btnRight_Click(object sender, EventArgs e)
        {
            
            if (this.lstCharacters.SelectedIndices.Count > 0)
            {
                try
                {
                    int selectedIndex = this.lstCharacters.SelectedIndices[0];
                    int characterRow = _characterListManager.Characters[selectedIndex].MapRowLocation;
                    int characterColumn = _characterListManager.Characters[selectedIndex].MapColumnLocation;

                    if (_mapManager.MapList[_mapIndex].MapGrid[characterRow, characterColumn + 1] != null)
                    {
                        MessageBox.Show("You can't run over other characters");
                    }
                    else
                    {

                        _characterListManager.Characters[selectedIndex].MapColumnLocation += 1;
                        _mapManager.MapList[_mapIndex].MapGrid[characterRow, characterColumn] = null;
                        UpdateCharacterPosition(selectedIndex);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("You cant go off the map.");
                }
            }
            else
            {
                MessageBox.Show("Pleaee highlight a Character to move.");
            }
        }

        // This will let us move the highlighted character left on the map.
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (this.lstCharacters.SelectedIndices.Count > 0)
            {
                try
                {
                    int selectedIndex = this.lstCharacters.SelectedIndices[0];
                    int characterRow = _characterListManager.Characters[selectedIndex].MapRowLocation;
                    int characterColumn = _characterListManager.Characters[selectedIndex].MapColumnLocation;

                    if (_mapManager.MapList[_mapIndex].MapGrid[characterRow, characterColumn - 1] != null)
                    {
                        MessageBox.Show("You can't run over other characters");
                    }
                    else
                    {

                        _characterListManager.Characters[selectedIndex].MapColumnLocation -= 1;
                        _mapManager.MapList[_mapIndex].MapGrid[characterRow, characterColumn] = null;
                        UpdateCharacterPosition(selectedIndex);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("You cant go off the map.");
                }
            }
            else
            {
                MessageBox.Show("Pleaee highlight a Character to move.");
            }
        }

        // This lets us delete a charcter from the list as well as the map.
        private void btnDeleteCharacter_Click(object sender, EventArgs e)
        {
            if (this.lstCharacters.SelectedIndices.Count > 0)
            {
                int selectedIndex = this.lstCharacters.SelectedIndices[0];
                int characterRow = _characterListManager.Characters[selectedIndex].MapRowLocation;
                int characterColumn = _characterListManager.Characters[selectedIndex].MapColumnLocation;
                _mapManager.MapList[_mapIndex].MapGrid[characterRow, characterColumn] = null;
                _characterListManager.Characters.RemoveAt(selectedIndex);
                //_characterListManager.Characters[selectedIndex].MapRowLocation;
                PopulateList();
                PopulateMap();
            }
            else
            {
                MessageBox.Show("Please highlight a character to delete.");
            }
        }

        // This lets us go back to the main form
        private void btnBack_Click(object sender, EventArgs e)
        {
            CharacterListManager.CharacterCount = 0;
            this.Close();
        }
    }
}
