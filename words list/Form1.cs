using System;
using System.Windows.Forms;

namespace words_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;

            if (!string.IsNullOrEmpty(input))

            {

                wordsListBox.Items.Add(input); // Add the text to the ListBox

                inputTextBox.Clear(); // Clear the input TextBox after adding the text to the wordslistbox

            }
        }
        //this method updates the selected text in the wordsListbox  with the text entered in the inputTextBox

        private void changeButton_Click(object sender, EventArgs e)
        {
            int index = wordsListBox.SelectedIndex;
            wordsListBox.Items[index] = inputTextBox.Text;
            wordsListBox.ClearSelected();
            inputTextBox.Clear();
        }
        //this method cuecks if theres a selected text then sets the text of the inputTextBox to the selected text in the wordsListBox 
        private void wordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (wordsListBox.SelectedItem != null)
            {
                inputTextBox.Text = wordsListBox.SelectedItem.ToString();
            }
            
        }
        //method removes the selected text in the wordsListBox
        //if there's no text selected it removes the text in the inputTextBox
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (wordsListBox.SelectedItem != null || inputTextBox != null)

            {

                wordsListBox.Items.Remove(wordsListBox.SelectedItem); // Remove the selected text from the ListBox
                inputTextBox.Clear(); // Clear the input TextBox if theres anythin in it 

            }
            wordsListBox.ClearSelected();
            inputTextBox.Clear();

        }
        

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //method Remove all texts from the ListBox  
        private void clearButton_Click(object sender, EventArgs e)
        {
            if (wordsListBox.Items.Count > 0)

            {

                wordsListBox.Items.Clear();

            }
            
        }
    }
}
