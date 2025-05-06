using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ListBoxManipulationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputTextBox.Text))
            {
                mainListBox.Items.Add(inputTextBox.Text);
                inputTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an item to add.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (mainListBox.SelectedIndex != -1)
            {
                mainListBox.Items.RemoveAt(mainListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (mainListBox.Items.Count > 0)
            {
                List<string> items = mainListBox.Items.Cast<string>().ToList();
                items.Sort();
                mainListBox.Items.Clear();
                mainListBox.Items.AddRange(items.ToArray());
            }
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            if (mainListBox.Items.Count > 0)
            {
                List<string> items = mainListBox.Items.Cast<string>().ToList();
                items.Reverse();
                mainListBox.Items.Clear();
                mainListBox.Items.AddRange(items.ToArray());
            }
        }
    }
} 