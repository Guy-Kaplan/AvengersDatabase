using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AvengersForm
{
    public partial class Form1 : Form
    {
        // Made by Guy Kaplan

        // List of all characters
        private static readonly List<string> charactersList = new List<string>
            {
                "Captain America", "Falcon", "Iron Man", "Black Widow",
                "Hawkeye", "Hulk", "Scarlet Witch", "War Machine",
                "Ant-Man", "Wasp", "Winter Soldier", "Spider-Man",
                "Doctor Strange", "Black Panther", "Captain Marvel",
            };
        private static readonly Random Random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays the chosen character's full name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharactersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayFullName();
        }

        /// <summary>
        /// Selects a random character and displays its full name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomButton_Click(object sender, EventArgs e)
        {
            CharactersComboBox.Text = GetRndCharacterName();
            DisplayFullName();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            foreach (var character in charactersList)
            {
                sb.AppendLine($"{character} = {GetRealNameOfGivenCharacter(character)}");
            }
            MessageBox.Show(sb.ToString(), "All characters and real names");
        }

        /// <summary>
        /// Resets both text fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            CharactersComboBox.Text = FullNameTextBox.Text = string.Empty;
            CharactersComboBox.ResetText();
            CharactersComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                "Exit the program", MessageBoxButtons.YesNoCancel)
                == DialogResult.Yes)
            {
                Close(); // exit the program
            }
        }

        /// <summary>
        /// Gets a random character name
        /// </summary>
        /// <returns>A random character name</returns>
        private string GetRndCharacterName()
        {
            return charactersList[Random.Next(charactersList.Count)];
        }

        /// <summary>
        /// Displays the chosen character's real name
        /// </summary>
        private void DisplayFullName()
        {
            FullNameTextBox.Text = GetRealNameOfGivenCharacter(CharactersComboBox.Text);
        }

        /// <summary>
        /// Gets the rael name of the given character
        /// </summary>
        /// <param name="nickname">The given character</param>
        /// <returns>The the rael name of the given character</returns>
        private string GetRealNameOfGivenCharacter(string nickname)
        {
            switch (nickname)
            {
                case "Captain America":
                    return "Steve Rogers";
                case "Falcon":
                    return "Sam Wilson";
                case "Iron Man":
                    return "Tony Stark";
                case "Black Widow":
                    return "Natasha Romanoff";
                case "Hawkeye":
                    return "Clint Barton";
                case "Hulk":
                    return "Dr. Bruce Banner";
                case "Scarlet Witch":
                    return "Wanda Maximoff";
                case "War Machine":
                    return "Rupert 'Rhodey' Rhodes";
                case "Ant-Man":
                    return "Scott Lang";
                case "Wasp":
                    return "Hope Van Dyne";
                case "Winter Soldier":
                    return "James 'Bucky' Barnes";
                case "Spider-Man":
                    return "Peter Parker";
                case "Doctor Strange":
                    return "Stephen Vincent Strange";
                case "Black Panther":
                    return "T'Challa";
                case "Captain Marvel":
                    return "Carol Danvers";
                default:
                    return string.Empty;
            }
        }
    }
}
