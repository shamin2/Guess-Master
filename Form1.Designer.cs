namespace NumberGuessingGame
{
    partial class Form1
    {
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.Label labelAttempts;
        private System.Windows.Forms.ProgressBar progressBarAttempts;
        private System.Windows.Forms.Button buttonNewGame;

        private void InitializeComponent()
        {
            this.labelInstructions = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.labelAttempts = new System.Windows.Forms.Label();
            this.progressBarAttempts = new System.Windows.Forms.ProgressBar();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelInstructions
            this.labelInstructions.Location = new System.Drawing.Point(30, 20);
            this.labelInstructions.Size = new System.Drawing.Size(200, 30);
            this.labelInstructions.Text = "Guess a number between 1 and 100";
            this.labelInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // textBoxGuess
            this.textBoxGuess.Location = new System.Drawing.Point(30, 60);
            this.textBoxGuess.Size = new System.Drawing.Size(200, 30);

            // buttonGuess
            this.buttonGuess.Location = new System.Drawing.Point(30, 90);
            this.buttonGuess.Size = new System.Drawing.Size(200, 30);
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);

            // labelFeedback
            this.labelFeedback.Location = new System.Drawing.Point(30, 120);
            this.labelFeedback.Size = new System.Drawing.Size(200, 30);
            this.labelFeedback.Text = "Enter a guess and press 'Guess'";
            this.labelFeedback.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.labelFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelAttempts
            this.labelAttempts.Location = new System.Drawing.Point(30, 200);
            this.labelAttempts.Size = new System.Drawing.Size(200, 30);
            this.labelAttempts.Text = "Attempts: 0";
            this.labelAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // progressBarAttempts
            this.progressBarAttempts.Location = new System.Drawing.Point(30, 160);
            this.progressBarAttempts.Size = new System.Drawing.Size(200, 30);
            this.progressBarAttempts.Minimum = 0;
            this.progressBarAttempts.Maximum = 10;

            // buttonNewGame
            this.buttonNewGame.Location = new System.Drawing.Point(30, 240);
            this.buttonNewGame.Size = new System.Drawing.Size(200, 30);
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(260, 300);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.labelAttempts);
            this.Controls.Add(this.progressBarAttempts);
            this.Controls.Add(this.buttonNewGame);
            this.Text = "Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
