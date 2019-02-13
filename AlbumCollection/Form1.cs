using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumCollection
{
    public partial class Form1 : Form
    {
        List<string> AlbumOriginal = new List<string>();
        List<string> AlbumSorted = new List<string>();
        string pending;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            pending = AlbumInput.Text;
            AlbumOriginal.Add(pending);
            AlbumSorted.Add(pending);

            ShowAlbum();

            WrongLabel.Visible = false;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            pending = AlbumInput.Text;
            if (AlbumOriginal.Contains(pending) == true)
            {
                AlbumOriginal.Remove(pending);
                AlbumSorted.Remove(pending);

                ShowAlbum();
            }
            else if (AlbumOriginal.Contains(pending) == false)
            {
                WrongLabel.Text = "album " + pending + " not found in collection";
                WrongLabel.Visible = true;
            }
        }

        private void ShowAlbum()
        {
            OrigLabel.Text = "Original List \n ************";
            SortedLabel.Text = "Sorted List \n **********";

            AlbumSorted.Sort();

            for (int i = 0; i < AlbumOriginal.Count(); i++)
            {
                OrigLabel.Text += "\n" + AlbumOriginal[i];
                SortedLabel.Text += "\n" + AlbumSorted[i];
            }
 
        }
    }
}
