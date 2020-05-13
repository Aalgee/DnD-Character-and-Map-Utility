/*
    FILE: MapListForm.cs
    DATE: 2019-04-21
    AUTHOR: Austin Gee
    DESCRIPTION:
        This forms is where the user will select which characters to add to their map.
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
    public partial class MapListForm : Form
    {
        private MapManager _mapManager = new MapManager();
        
        public MapListForm()
        {
            InitializeComponent();
            
        }

        private void MapListForm_Load(object sender, EventArgs e)
        {
            populateList();
        }

        // this populates the list with all the available maps
        private void populateList()
        {
            lstMaps.Items.Clear();
            
            
            for (int i = 0; i < _mapManager.MapList.Count; i++)
            {
                
                this.lstMaps.Items.Add(_mapManager.MapList[i].MapName);
                
            }
        }

        // This button will take the highlighted map and use it to load a new map form.
        private void btnChooseMap_Click(object sender, EventArgs e)
        {
            
            if (this.lstMaps.SelectedIndices.Count > 0)
            {
                this.Hide();
                CharacterListManager characterListManager = new CharacterListManager();
                var mapForm = new MapForm(_mapManager, lstMaps.SelectedIndices[0], characterListManager);
                try
                {
                    mapForm.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {

                }

            }
            else
            {
                MessageBox.Show("Please make a selection.");
            }
        }

        // This lets the user go back to the main form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
