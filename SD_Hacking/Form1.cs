using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_Hacking
{
    public partial class Form1 : Form
    {
        // Number of slots
        readonly int SLOTS = 0;

        // Number of tries
        int tries = 0;

        // Game completed flag
        bool isCompleted = false;

        // List containing digits
        List<char> number = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        // List containing digits picked out
        List<char> l = new List<char>();

        public Form1(int SLOTS)
        {
            InitializeComponent();
            this.SLOTS = SLOTS;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Size of text calculated from number of slots
            int size = 64 / SLOTS * 4;

            // Set font size for text box
            rtbLog.Font = new Font("Microsoft Sans Serif", size);
            tbInput.Font = new Font("Microsoft Sans Serif", size);

            // Start a new game with given difficulty
            NewGame();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            // If the game is still continuing (not ended)
            if (!isCompleted)
            {
                int i = 0; //Iterator to loop through list
                int c = 0; // Counter
                if (tbInput.Text == string.Empty)
                {
                    MessageBox.Show("Please enter " + SLOTS + " unique digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!tbInput.Text.isUnique())
                {
                    MessageBox.Show("Digits are not unique!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (char ch in tbInput.Text)
                {
                    // If number is in corrected order
                    if (ch == l[i++])
                    {
                        rtbLog.AppendText(ch + "  ", Color.Green);
                        // Mark this box is corrected
                        c++;
                    }
                    // If number is not in corrected order
                    else if (l.isAvailable(ch))
                        rtbLog.AppendText(ch + "  ", Color.Gold);
                    // Number is not available
                    else rtbLog.AppendText(ch + "  ", Color.OrangeRed);
                }
                rtbLog.AppendText(Environment.NewLine);
                // Update the Tip textbox
                tbTip.Text = "Number of tries: " + ++tries;
                // Game is completed
                if (c == SLOTS)
                {
                    tbTip.Text = "Congrats! You took " + tries + " tries";
                    isCompleted = true;
                    btSubmit.Text = "REPLAY";
                }
            }
            else NewGame();
        }
        private void NewGame()
        {
            // Setting up new game
            isCompleted = false;
            tries = 0;

            // Shuffle the list
            Random rng = new Random();
            number = number.OrderBy(a => rng.Next()).ToList();

            // Assign first digits to new list
            l.Clear();
            for (int i = 0; i < SLOTS; i++) l.Add(number[i]);

            // Show tips
            tbTip.Text = "Enter " + SLOTS + " unique digits";
            tbTip.MaxLength = SLOTS;
            btSubmit.Text = "SUBMIT";

            // Clear Log box
            rtbLog.Clear();
            rtbLog.Invalidate();

            // Clear textbox
            tbInput.Clear();
            tbInput.MaxLength = SLOTS;
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btSubmit_Click(sender, e);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    public static class Extensions
    {
        // Append text to rtb with color
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
        // Check if Text is available from a List
        public static bool isAvailable(this List<char> l, char text)
        {
            if (l.Contains(text)) return true; else return false;
        }
        // Check if this string is unique (no duplicated character)
        public static bool isUnique(this string str)
        {
            // Sort the string
            char[] characters = str.ToCharArray();
            Array.Sort(characters);
            for (int i = 0; i < characters.Length - 1; i++)
                if (characters[i] != characters[i + 1]) continue; else return false;
            return true;
        }
    }
}
