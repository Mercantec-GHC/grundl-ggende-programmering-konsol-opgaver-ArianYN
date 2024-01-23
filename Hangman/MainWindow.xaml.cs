using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hangman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Variables used throughout the program
        string secretWord = "";
        char[] secretWordSplit;
        char[] secretWordHidden;
        bool isValidLetter = true;
        int numberOfTries = 0;


        string guessedLetterString = "";
        char guessedLetterToChar = '-';

        Dictionary<int, string> hangmanImages = new Dictionary<int, string>()
{
    { 1, "/HangmanImages/hang_1.png" },
    { 2, "/HangmanImages/hang_2.png" },
    { 3, "/HangmanImages/hang_3.png" },
    { 4, "/HangmanImages/hang_4.png" },
    { 5, "/HangmanImages/hang_5.png" },
    { 6, "/HangmanImages/hang_6.png" },
    { 7, "/HangmanImages/hang_7.png" },
    { 8, "/HangmanImages/hang_8.png" },
    { 9, "/HangmanImages/hang_9.png" },
    { 10, "/HangmanImages/hang_10.png" },
    { 11, "/HangmanImages/hang_11.png" },
    { 12, "/HangmanImages/hang_12.png" }
};

        public MainWindow()
        {
            InitializeComponent();
        }

        // Initiates the game once the word to guess has been typed
        private void SecretWordButton_Click(object sender, RoutedEventArgs e)
        {
            secretWord = secretWordInput.Text.Trim().ToLower();
            secretWordInput.Clear();
            correctLettersList.Items.Clear();
            wrongLettersList.Items.Clear();
            numberOfTries = 0;
            triesNumber.Text = numberOfTries.ToString();

            secretWordSplit = secretWord.ToCharArray();
            secretWordHidden = secretWord.ToCharArray();

            for (int i = 0; i < secretWordHidden.Length; i++)
            {
                secretWordHidden[i] = '?';
            }
            if (secretWordHidden != null)
            {
                string secretWordHiddenString = new string(secretWordHidden);
                DisplayHiddenMessage(secretWordHiddenString);
            }
        }

        // Used for displaying the hidden message at the start and after guessing individual letters
        private void DisplayHiddenMessage(string displayWord)
        {
            secretWordDisplay.Text = displayWord;
        }

        // Method for when guessing a letter
        private void GuessButton_Click(object sender, RoutedEventArgs e)
        {
            guessedLetterString = guessBox.Text.Trim().ToLower();

            try
            {
                guessedLetterToChar = char.Parse(guessedLetterString);
                isValidLetter = char.IsLetter(guessedLetterToChar);
            }
            catch
            {
                MessageBox.Show("Invalid input. Only input 1 letter.", "Input Error");
            }

            if (isValidLetter)
            {
                guessBox.Clear();
                PopulateUsedLetters();
            }
            else
            {
                MessageBox.Show("Input a valid letter please.", "Input Error");
            }
        }

        // Checks whether or not the guessed letter is correct and adds letter to corresponding list
        private void PopulateUsedLetters()
        {
            if (secretWordSplit.Contains(guessedLetterToChar) && !correctLettersList.Items.Contains(guessedLetterToChar))
            {
                correctLettersList.Items.Add(guessedLetterToChar);
                ChangeCorrectLetters();
            }
            else if (!correctLettersList.Items.Contains(guessedLetterToChar) && !wrongLettersList.Items.Contains(guessedLetterToChar))
            {
                wrongLettersList.Items.Add(guessedLetterToChar);
                IncrementNumberOfTries();
            }
        }

        // This handles the changing of the correctly guessed letters from '?' to the actual letter
        private void ChangeCorrectLetters()
        {
            int secretWordLength = secretWordHidden.Length;

            for (int i = 0; i < secretWordLength; i++)
            {
                if (secretWordSplit[i] == guessedLetterToChar)
                {
                    secretWordHidden[i] = guessedLetterToChar;
                    string secretWordGuessing = new string(secretWordHidden);
                    DisplayHiddenMessage(secretWordGuessing);
                }
            }
        }

        // Handles when you try to guess the entire word
        private void GuessWordButton_Click(object sender, RoutedEventArgs e)
        {
            if (guessWordBox != null && guessWordBox.Text.ToLower().Trim() == secretWord)
            {
                secretWordDisplay.Text = secretWord;
                MessageBox.Show("Congratulations! You guessed the correct word!", "Congratulations", MessageBoxButton.OK);
                guessWordBox.Clear();
            }
            else
            {
                guessWordBox.Clear();
                IncrementNumberOfTries();
            }
        }

        // Increments number of tries and hangs the hangman :(
        private void IncrementNumberOfTries()
        {
            numberOfTries++;
            triesNumber.Text = numberOfTries.ToString();

            if (hangmanImages.ContainsKey(numberOfTries))
            {
                hangmanImage.Source = new BitmapImage(new Uri(hangmanImages[numberOfTries], UriKind.Relative));
            }

            if (numberOfTries >= 12)
            {
                MessageBox.Show($"Hangman has been hung. You lost. The word was {secretWord}", "Game Over", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Button for restarting the game
        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure that you want to reset the game?", "Reset Game", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                secretWordInput.Clear();
                correctLettersList.Items.Clear();
                wrongLettersList.Items.Clear();
                numberOfTries = 0;
                triesNumber.Text = numberOfTries.ToString();
                secretWord = "";
                secretWordDisplay.Text = "Secret Word";
                hangmanImage.Source = new BitmapImage(new Uri(hangmanImages[1], UriKind.Relative));

            }
            else if (result == MessageBoxResult.No)
            {
                return;
            }
        }
    }
}