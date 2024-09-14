using System;
using System.Windows;
using System.Windows.Controls;

namespace TextBoxVisibility
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Event Handlers

        //Triggered when the number of players changes
        private void NumberOfPlayersChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            TextBox? numberOfPlayersTextBox = sender as TextBox;

            // Parse the input from the textbox
            if (int.TryParse(numberOfPlayersTextBox?.Text, out int number) && number >= 2 && number <= 4)
            {
                // Collapse all Playeres initially
                TopPlayer.Visibility = Visibility.Collapsed;
                BottomPlayer.Visibility = Visibility.Collapsed;
                LeftPlayer.Visibility = Visibility.Collapsed;
                RightPlayer.Visibility = Visibility.Collapsed;

                // Update visibility based on the number entered
                switch (number)
                {
                    case 2:
                        TopPlayer.Visibility = Visibility.Visible;
                        BottomPlayer.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        TopPlayer.Visibility = Visibility.Visible;
                        BottomPlayer.Visibility = Visibility.Visible;
                        LeftPlayer.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        TopPlayer.Visibility = Visibility.Visible;
                        BottomPlayer.Visibility = Visibility.Visible;
                        LeftPlayer.Visibility = Visibility.Visible;
                        RightPlayer.Visibility = Visibility.Visible;
                        break;
                }
            }
            else
            {
                // If the input is invalid, collapse all the textboxes
                TopPlayer.Visibility = Visibility.Collapsed;
                BottomPlayer.Visibility = Visibility.Collapsed;
                LeftPlayer.Visibility = Visibility.Collapsed;
                RightPlayer.Visibility = Visibility.Collapsed;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {

        }

        #endregion Event Handlers
    }
}
