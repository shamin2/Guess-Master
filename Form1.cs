using System;
using System.Drawing;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        private int targetNumber;
        private int attempts;
        private const int maxAttempts = 10;  // Maximum attempts allowed

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 101);  // Random number between 1 and 100
            attempts = 0;
            labelFeedback.Text = "Enter a guess and press 'Guess'";
            labelFeedback.ForeColor = Color.Black;
            progressBarAttempts.Value = 0;
            textBoxGuess.Clear();
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxGuess.Text, out int guess))
            {
                attempts++;
                progressBarAttempts.Value = Math.Min(attempts, maxAttempts);  // Update progress bar
                labelAttempts.Text = $"Attempts: {attempts}";

                // Check if the guess is correct, too low, or too high and set feedback color
                if (guess < targetNumber)
                {
                    labelFeedback.Text = "Too low! Try again.";
                    labelFeedback.ForeColor = Color.Blue;
                }
                else if (guess > targetNumber)
                {
                    labelFeedback.Text = "Too high! Try again.";
                    labelFeedback.ForeColor = Color.Red;
                }
                else
                {
                    labelFeedback.Text = $"Correct! You guessed it in {attempts} attempts.";
                    labelFeedback.ForeColor = Color.Green;
                    MessageBox.Show("Congratulations! You've guessed the number correctly!", "Victory");
                    StartNewGame();  // Start a new game automatically
                }

                // Check if maximum attempts reached
                if (attempts >= maxAttempts && guess != targetNumber)
                {
                    MessageBox.Show($"You've reached the maximum attempts. The number was {targetNumber}.", "Game Over");
                    StartNewGame();
                }
            }
            else
            {
                // Invalid input feedback
                labelFeedback.Text = "Please enter a valid number!";
                labelFeedback.ForeColor = Color.Orange;
            }

            // Clear the input box for the next guess and focus on it
            textBoxGuess.Clear();
            textBoxGuess.Focus();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
