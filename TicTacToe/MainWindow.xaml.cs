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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string XPlayer = "X";
        private const string OPlayer = "O";
        private string currentPlayer;
        private Button[,] buttons;
        private int XPlayerScore = 0;
        private int OPlayerScore = 0;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            buttons = new Button[3, 3]
            {
                {btn00, btn01, btn02},
                {btn10, btn11, btn12},
                {btn20, btn21, btn22},
            };

            foreach (Button button in buttons) 
            {
                button.Content = string.Empty;
                button.IsEnabled = true;
                button.Background = Brushes.White;
    
            }

            currentPlayer = XPlayer;
            UpdateCurrentPlayerTxtBlock();
        }

        private void UpdateCurrentPlayerTxtBlock() 
        {
            txtblock_CurrentPlayer.Text = $"Current player: {currentPlayer}";
        }

        private void SwitchTurns() 
        {
            currentPlayer = currentPlayer == XPlayer ? OPlayer : XPlayer;
            UpdateCurrentPlayerTxtBlock();
        }

        private void GameButton_Click(object sender, RoutedEventArgs e) 
        {

        }

        
    }
}