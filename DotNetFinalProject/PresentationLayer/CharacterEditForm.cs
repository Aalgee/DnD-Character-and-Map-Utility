/*
    FILE: CharacterEditForm.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This class is used to present the user with the Charcter edit form. This from is used not
        only for editing characters, but also for creating new chatacters.
*/

using LogicLayer;
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

namespace PresentationLayer
{
    public partial class CharacterEditForm : Form
    {
        bool editMode;
        string picFilename = "";
        string dataPath = Application.StartupPath + @"\characterData";

        // Here we can hold a new CharacterManager reference or one that has been passed
        // to this class
        CharacterManager _characterManager;
        int _characterIndex;

        // this constructor is for adding new characters
        public CharacterEditForm()
        {
            
            editMode = false;
            _characterManager = new CharacterManager();

            InitializeComponent();
        }

        // This constructor is used when editing existing characters.
        public CharacterEditForm(int characterIndex, CharacterManager characterManager)
        {
            editMode = true;
            _characterManager = characterManager;
            _characterIndex = characterIndex;

            InitializeComponent();
        }

        // When we are in edit mode we have to populate many of the controls in the form because
        // we must show the information from a character that has already been created. If we are
        // not in edit mode then none of these controls have to be populated because we are creating
        // character from scratch
        private void CharacterEditForm_Load(object sender, EventArgs e)
        {
            
            if (editMode == true)
            {
                this.txtCharacterName.Text = _characterManager.CharacterList[_characterIndex].Name;
                this.txtCharacterSize.Text = _characterManager.CharacterList[_characterIndex].Size;
                this.txtCharacterType.Text = _characterManager.CharacterList[_characterIndex].Type;
                this.txtCharacterAllignment.Text = _characterManager.CharacterList[_characterIndex].Allignment;
                this.txtCharacterAffiliation.Text = _characterManager.CharacterList[_characterIndex].Affiliation;

                // Here we display and image, but we must specify a file name within which to save it
                picFilename = _characterManager.CharacterList[_characterIndex].ImageFileName;
                picCharacter.Image = Image.FromFile(dataPath + @"\" + picFilename);

                // We use the character stat block file name to cell up the character stat block
                this.txtStatBlockFilename.Text = _characterManager.CharacterList[_characterIndex].StatBlockFileName;

                CharacterStatBlock characterStatBlock = _characterManager.FetchCharacterStatBlock(_characterIndex);

                this.txtStatBlock.Text = characterStatBlock.StatBlockText;

                this.txtStatBlockFilename.Enabled = false;

                this.Text = "Character Editor";

            }
            else
            {
                this.Text = "Add a Charecter";
            }
        }

        
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Multiselect = false;

            this.openFileDialog1.Filter = "Png files (*.png)|*.png";

            this.openFileDialog1.InitialDirectory = dataPath;
            this.openFileDialog1.ShowDialog(this);

            if (openFileDialog1.FileName != null && openFileDialog1.FileName != "")
            {
                picCharacter.Image = Image.FromFile(this.openFileDialog1.FileName);
                picFilename = this.openFileDialog1.SafeFileName;
            }
        }

        // Here we gather all the data from the various text boxes and use it to
        // create a new instantiation of the Character class
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Here we do some checks to make sure the user has not left any fields blank.
            if (txtCharacterName.Text == "")
            {
                MessageBox.Show("You need to enter a character name.");
                txtCharacterName.Focus();
                return;
            }

            if(txtCharacterSize.Text == "")
            {
                MessageBox.Show("You need to enter a character size.");
                txtCharacterSize.Focus();
                return;
            }
            if(txtCharacterType.Text == "")
            {
                MessageBox.Show("You need to enter a character type.");
                txtCharacterType.Focus();
                return;
            }
            if(txtCharacterAllignment.Text == "")
            {
                MessageBox.Show("You need to enter a character allignment.");
                txtCharacterAllignment.Focus();
                return;
            }
            if(txtCharacterAffiliation.Text == "")
            {
                MessageBox.Show("You need to enter a character affiliation.");
                txtCharacterAffiliation.Focus();
                return;
            }
            if(picCharacter.Image == null)
            {
                MessageBox.Show("You need to choose a character image.");
                btnChooseImage.Focus();
                return;
            }
            if(txtStatBlock.Text == "")
            {
                MessageBox.Show("You need to enter the stat block text.");
                txtStatBlock.Focus();
                return;
            }
            if(txtStatBlockFilename.Text == "")
            {
                MessageBox.Show("You need to enter a stat block filename.");
                txtStatBlockFilename.Focus();
                return;
            }
            if((txtStatBlockFilename.Text).ToLower().EndsWith(".txt") == false)
            {
                MessageBox.Show("Your filename must end with a  '.txt'");
                txtStatBlockFilename.Focus();
                return;
            }
            if(txtStatBlockFilename.Text.Length < 5)
            {
                MessageBox.Show("Invalid file name.");
                txtStatBlockFilename.Focus();
                return;
            }
            if(System.IO.File.Exists( dataPath + @"\" + txtStatBlockFilename.Text ) && editMode == false)
            {
                MessageBox.Show("File already exists.");
                txtStatBlockFilename.Focus();
                return;
            }

            // When all the data has been entered we can use it to create objects to be saved 
            var character = new Character();
            character.Name = txtCharacterName.Text;
            character.Size = txtCharacterSize.Text;
            character.Type = txtCharacterType.Text;
            character.Allignment = txtCharacterAllignment.Text;
            character.Affiliation = txtCharacterAffiliation.Text;
            character.ImageFileName = picFilename;
            character.StatBlockFileName = txtStatBlockFilename.Text;

            var characterStatBlock = new CharacterStatBlock();
            characterStatBlock.CharacterName = txtCharacterName.Text;
            characterStatBlock.StatBlockText = txtStatBlock.Text;

            if (editMode == true) // saves over existing records
            {
                _characterManager.EditCharacter(character, characterStatBlock, _characterIndex);
                this.Close();
            }

            else // adds new records
            {
                int characterCount = _characterManager.CharacterList.Count;
                var newList = _characterManager.AddCharacter(character, characterStatBlock);
                
                if (newList.Count > characterCount)
                {
                    MessageBox.Show("New character added.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Add failed");
                    this.Close();
                }
            }
        } // End of btnSave_Click

        // This gives the user a way to quit without saving.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Abandon Edits!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
