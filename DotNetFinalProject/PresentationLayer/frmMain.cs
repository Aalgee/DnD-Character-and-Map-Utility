/*
    FILE: frmMain.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This form is the staring point for the program. It will let the user either choose a character
        to look at, choose a character to edit, choose to create a new character or got to the map utility.
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

    public partial class frmMain : Form
    {
        // Here the CharacterManager is instantiated
        private CharacterManager _characterManager = new CharacterManager();
        public frmMain()
        {
            InitializeComponent();
        }

        private void CharacterListForm_Load(object sender, EventArgs e)
        {
            // when the form loads this populated the list with available characters
            populateList();
        }

        // This method populates the listview with all of the available characters
        private void populateList()
        {
            lstCharacter.Items.Clear();
            for (int i = 0; i < _characterManager.CharacterList.Count; i++)
            {
                this.lstCharacter.Items.Add(_characterManager.CharacterList[i].Name);
                this.lstCharacter.Items[this.lstCharacter.Items.Count - 1].SubItems.Add(_characterManager.CharacterList[i].Size);
                this.lstCharacter.Items[this.lstCharacter.Items.Count - 1].SubItems.Add(_characterManager.CharacterList[i].Type);
                this.lstCharacter.Items[this.lstCharacter.Items.Count - 1].SubItems.Add(_characterManager.CharacterList[i].Allignment);
                this.lstCharacter.Items[this.lstCharacter.Items.Count - 1].SubItems.Add(_characterManager.CharacterList[i].Affiliation);
            }
        }

        // This craetes a form that displays the character statblocks
        private void btnStatBlock_Click(object sender, EventArgs e)
        {
            if(this.lstCharacter.SelectedIndices.Count > 0)
            {
                var statBlockForm = new CharacterStatBlockForm(_characterManager, lstCharacter.SelectedIndices[0]);
                statBlockForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pleaee make a selection.");
            }
        }

        // This creates a Character edit form using the constructor that adds
        // new Characters
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new CharacterEditForm();
            addForm.ShowDialog();
            _characterManager = new CharacterManager();
            populateList();
        }

        // This creates a Character edit form using the constructor that edits
        // existing Characters
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.lstCharacter.SelectedIndices.Count > 0)
            {
                var editForm = new CharacterEditForm(lstCharacter.SelectedIndices[0], _characterManager);
                editForm.ShowDialog();
                _characterManager = new CharacterManager();
                populateList();
            }
            else
            {
                MessageBox.Show("Please make a selection.");
            }
        }

        // This method allows the user to select a character by double clicking one on
        // the character list
        private void lstCharacter_DoubleClick(object sender, EventArgs e)
        {
            var statBlockForm = new CharacterStatBlockForm(_characterManager, lstCharacter.SelectedIndices[0]);
            statBlockForm.ShowDialog();
        }

        // This creates ands loads a new instance of the MapListForm class. It is used to select a map 
        // that will be used with the map utility functiuonality of the program.
        private void btnNewMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mapListForm = new MapListForm();
            mapListForm.ShowDialog();
            this.Show();
        }

        // This exits out of the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
