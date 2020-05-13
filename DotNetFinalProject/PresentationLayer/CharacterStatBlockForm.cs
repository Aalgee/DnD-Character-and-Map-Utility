/*
    FILE: CharacterStatBlockForm.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This form holds the character stat block for my final procject 
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
using LogicLayer;
using DataObjects;

namespace PresentationLayer
{
    public partial class CharacterStatBlockForm : Form
    {
        CharacterManager _characterManager;
        int _characterIndex;
        CharacterStatBlock _characterStatBlock;
        public CharacterStatBlockForm(CharacterManager characterManager, int characterIndex)
        {

            InitializeComponent();
            _characterManager = characterManager;
            _characterIndex = characterIndex;
        }

        // when this form is loaded the stat block of the character that was chosen is displayed
        private void CharacterStatBlockForm_Load(object sender, EventArgs e)
        {
            DisplayStatBlock();
        }

        // This method displays the stat block of a character that is either chosen from the previous
        // screen or that comes up by clicking the next button
        private void DisplayStatBlock()
        {
            try
            {
                _characterStatBlock = _characterManager.FetchCharacterStatBlock(_characterIndex);
                this.lblTitle.Text = _characterStatBlock.CharacterName;
                this.txtStatBlock.Text = _characterStatBlock.StatBlockText;
                this.picCharacterImage.Image = Image.FromFile(AppData.DataPath + @"\" + _characterManager.CharacterList[_characterIndex].ImageFileName);
                this.btnNext.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This method will display the next character in the list
        private void btnNext_Click(object sender, EventArgs e)
        {
            _characterIndex++;
            if (_characterIndex > _characterManager.CharacterList.Count - 1)
            {
                _characterIndex = 0;
            }
            DisplayStatBlock();
        }

        // here we close the form
        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
