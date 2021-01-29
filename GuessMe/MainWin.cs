using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessMe
{
    public partial class MainWin : Form
    {


        /// <summary>
        /// Computer decided number
        /// </summary>
        private int number;

        /// <summary>
        /// Current computer guess in the screen
        /// </summary>
        private int computerGuess_current = 50;

        /// <summary>
        /// Previous computer guess
        /// </summary>
        private int computerGuess_previous = 0;

        /// <summary>
        /// Chances the player remains
        /// </summary>
        private int remainingChances = 6;

        /// <summary>
        /// Detects if the game is over
        /// </summary>
        private bool gameOver = false;



        #region MECHANISMS

        // Constructor
        public MainWin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check two players status and returns true if game is over
        /// </summary>
        /// <returns></returns>
        private bool IsGameOver( int playerInput )
        {

            // Check if this is a draw
            if ( playerInput == number && computerGuess_current == number )
            {
                ShowMessage( "Draw !" , Color.Orange );
                return true;
            }

            // Check if player wins
            else if ( playerInput == number )
            {
                ShowMessage( "You Won" , Color.LightGreen );
                return true;
            }

            // Check if computer wins
            else if ( computerGuess_current == number )
            {
                ShowMessage( "Computer wins!" , Color.Red );
                return true;
            }

            // Check if both loses
            else if ( remainingChances == 0 )
            {
                ShowMessage( "Both Lose" , Color.Red );
                return true;
            }

            return false;

        }

        /// <summary>
        /// Check is player guess is above or bellow the number
        /// </summary>
        private void CheckPlayerGuessRange( int playerInput )
        {

            // Check player input range
            if ( playerInput > number )
            {
                CMessage_LBL.Text = "Try Again! You guessed too high";
            }
            else
            {
                CMessage_LBL.Text = "Try Again! You guessed too small";
            }

        }

        /// <summary>
        /// Check player guess range and make next guess
        /// </summary>
        private void CheckComputerGuessRange()
        {

            // Store current computer guess
            int temp = computerGuess_current;

            // Check computer input range
            if ( computerGuess_current > number )
            {

                // Make it just half if this the first gap
                if ( computerGuess_previous == 0 )
                {
                    computerGuess_current /= 2;
                }
                // Reduce half of gap between previous and current guesses from current guess
                else
                {
                    computerGuess_current -=
                        (int) Math.Ceiling( Math.Abs( computerGuess_previous - computerGuess_current ) / 2.0 );
                }

            }
            else
            {

                // Go one down if this is the first round
                if ( computerGuess_previous == 0 )
                {
                    computerGuess_current += computerGuess_current / 2;
                }
                // Add half of gap between previous and current guesses to current guess
                else
                {
                    computerGuess_current +=
                        (int) Math.Ceiling( Math.Abs( computerGuess_previous - computerGuess_current ) / 2.0 );
                }

            }

            // Switch previous guess
            computerGuess_previous = temp;
            // Show current guess
            CComputerGuess_TXT.Text = computerGuess_current.ToString();

        }

        /// <summary>
        /// Show a message to user in given color
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="msgColor">Text color</param>
        private void ShowMessage(string msg, Color msgColor )
        {
            CMessage_LBL.ForeColor = msgColor;
            CMessage_LBL.Text = msg;
        }

        #endregion



        #region EVENTS

        // Me - Load
        private void MainWin_Load( object sender , EventArgs e )
        {

            // Get a rnd number between 1 and 100
            number = new Random().Next( 1 , 101 ) % 100;

        }

        // Player Input - KeyUp
        private void CPlayerInput_TXT_KeyUp( object sender , KeyEventArgs e )
        {

            // Continue if the pressed key is enter and game is not over
            if ( e.KeyCode == Keys.Enter && !gameOver )
            {

                // Get input
                int playerInput = int.Parse( CPlayerInput_TXT.Text );

                // Decrement chances
                remainingChances--;
                // Update remaining count label
                CRemainingGuesses_LBL.Text = remainingChances.ToString();

                // Check if game is over
                gameOver = IsGameOver( playerInput );

                // Check player input range and change computer guess
                if ( !gameOver )
                {

                    // Check player guess range
                    CheckPlayerGuessRange( playerInput );

                    // Check player guess range and make next move
                    CheckComputerGuessRange();

                }

            }

        }

        // Restart Game - Click
        private void CRestartGame_BTN_Click( object sender , EventArgs e )
        {
            Application.Restart();
        }
        
        #endregion

        
    }
}
