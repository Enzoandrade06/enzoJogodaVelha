namespace JogodaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;
            btn.Text = vez;
            vez = (vez == "X") ? "O" : "X";


            if (
                (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") ||
                (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") ||
                (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") ||
                (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X") ||
                (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X") ||
                (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X") ||
                (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") ||
                (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            )
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
                return;
            }

            if (
                (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") ||
                (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") ||
                (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") ||
                (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O") ||
                (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O") ||
                (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O") ||
                (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") ||
                (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            )
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
                return;
            }
                if (TodosOsBotoesPreenchidos())
                {
                    DisplayAlert("Empate!", "Deu velha!", "OK");
                    Zerar();
                    return;
                }

            }

            bool TodosOsBotoesPreenchidos()
            {
                return new[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 }
                       .All(b => !string.IsNullOrWhiteSpace(b.Text));
            }

            void Zerar()
            {
                foreach (var btn in new[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 })
                {
                    btn.Text = "";
                    btn.IsEnabled = true;
                }

                vez = "X";
            }
        }
    }

