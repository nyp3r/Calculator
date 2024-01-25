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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Nyp3rCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int digits = 12;
        private List<double> memory = new List<double>();

        public MainWindow()
        {
            InitializeComponent();
            Hotkeys();
            DisableMemoryButtonsFromStart();
        }

        void Hotkeys()
        {
            RoutedCommand command1 = new RoutedCommand();
            RoutedCommand command2 = new RoutedCommand();
            RoutedCommand command3 = new RoutedCommand();
            RoutedCommand command4 = new RoutedCommand();
            RoutedCommand command5 = new RoutedCommand();
            RoutedCommand command6 = new RoutedCommand();
            RoutedCommand command7 = new RoutedCommand();
            RoutedCommand command8 = new RoutedCommand();
            RoutedCommand command9 = new RoutedCommand();
            RoutedCommand command10 = new RoutedCommand();
            RoutedCommand command11 = new RoutedCommand();
            RoutedCommand command12 = new RoutedCommand();
            RoutedCommand command13 = new RoutedCommand();
            RoutedCommand command14 = new RoutedCommand();
            RoutedCommand command15 = new RoutedCommand();
            RoutedCommand command16 = new RoutedCommand();
            RoutedCommand command17 = new RoutedCommand();
            RoutedCommand command18 = new RoutedCommand();
            RoutedCommand command19 = new RoutedCommand();
            RoutedCommand command20 = new RoutedCommand();
            RoutedCommand command21 = new RoutedCommand();
            RoutedCommand command22 = new RoutedCommand();
            RoutedCommand command23 = new RoutedCommand();
            RoutedCommand command24 = new RoutedCommand();

            // Associate methods with commands
            command1.InputGestures.Add(new KeyGesture(Key.F12));
            CommandBindings.Add(new CommandBinding(command1, Settings));

            command2.InputGestures.Add(new KeyGesture(Key.Delete));
            CommandBindings.Add(new CommandBinding(command2, ClearEntry));

            command3.InputGestures.Add(new KeyGesture(Key.Escape));
            CommandBindings.Add(new CommandBinding(command3, Clear));

            command4.InputGestures.Add(new KeyGesture(Key.Back));
            CommandBindings.Add(new CommandBinding(command4, backspace));

            command5.InputGestures.Add(new KeyGesture(Key.F1));
            CommandBindings.Add(new CommandBinding(command5, Fraction));

            command6.InputGestures.Add(new KeyGesture(Key.F2));
            CommandBindings.Add(new CommandBinding(command6, SecondPower));

            command7.InputGestures.Add(new KeyGesture(Key.F3));
            CommandBindings.Add(new CommandBinding(command7, SquareRoot));

            command8.InputGestures.Add(new KeyGesture(Key.Divide));
            CommandBindings.Add(new CommandBinding(command8, divide));

            command9.InputGestures.Add(new KeyGesture(Key.Multiply));
            CommandBindings.Add(new CommandBinding(command9, multiply));

            command10.InputGestures.Add(new KeyGesture(Key.Subtract));
            CommandBindings.Add(new CommandBinding(command10, minus));

            command11.InputGestures.Add(new KeyGesture(Key.Add));
            CommandBindings.Add(new CommandBinding(command11, plus));

            command12.InputGestures.Add(new KeyGesture(Key.NumPad1));
            CommandBindings.Add(new CommandBinding(command12, one));

            command13.InputGestures.Add(new KeyGesture(Key.NumPad2));
            CommandBindings.Add(new CommandBinding(command13, two));

            command14.InputGestures.Add(new KeyGesture(Key.NumPad3));
            CommandBindings.Add(new CommandBinding(command14, three));

            command15.InputGestures.Add(new KeyGesture(Key.NumPad4));
            CommandBindings.Add(new CommandBinding(command15, four));

            command16.InputGestures.Add(new KeyGesture(Key.NumPad5));
            CommandBindings.Add(new CommandBinding(command16, five));

            command17.InputGestures.Add(new KeyGesture(Key.NumPad6));
            CommandBindings.Add(new CommandBinding(command17, six));

            command18.InputGestures.Add(new KeyGesture(Key.NumPad7));
            CommandBindings.Add(new CommandBinding(command18, seven));

            command19.InputGestures.Add(new KeyGesture(Key.NumPad8));
            CommandBindings.Add(new CommandBinding(command19, eight));

            command20.InputGestures.Add(new KeyGesture(Key.NumPad9));
            CommandBindings.Add(new CommandBinding(command20, nine));

            command21.InputGestures.Add(new KeyGesture(Key.NumPad0));
            CommandBindings.Add(new CommandBinding(command21, zero));

            command22.InputGestures.Add(new KeyGesture(Key.Up));
            command22.InputGestures.Add(new KeyGesture(Key.Down));
            CommandBindings.Add(new CommandBinding(command22, PosNegSwitch));

            command23.InputGestures.Add(new KeyGesture(Key.Decimal));
            CommandBindings.Add(new CommandBinding(command23, DecimalPoint));

            command24.InputGestures.Add(new KeyGesture(Key.Return));
            CommandBindings.Add(new CommandBinding(command24, Equalss));
        }
        private void DisableMemoryButtonsFromStart()
        {
            mBtn.IsEnabled = false;
            mcBtn.IsEnabled = false;
            mAddBtn.IsEnabled = false;
            mSubBtn.IsEnabled = false;
            mrBtn.IsEnabled = false;
        }

        public void MemorySave(object sender, EventArgs e)
        {
            memory.Insert(0, Convert.ToDouble(Output.Text));
            newNum = true;
            mcBtn.IsEnabled = true;
            mrBtn.IsEnabled = true;
            mBtn.IsEnabled = true;
            mAddBtn.IsEnabled = true;
            mSubBtn.IsEnabled = true;
        }

        public void MemorySub(object sender, EventArgs e)
        {
            memory[0] = memory[0] - Convert.ToDouble(Output.Text);
            newNum = true;
        }

        public void MemoryAdd(object sender, EventArgs e)
        {
            memory[0] = memory[0] + Convert.ToDouble(Output.Text);
            newNum = true;
        }

        public void MemoryRecall(object sender, EventArgs e)
        {
            Output.Text = memory[0].ToString();
            newNum = true;
        }

        public void MemoryClear(object sender, EventArgs e)
        {
            memory.Clear();
            newNum = true;
            mcBtn.IsEnabled = false;
            mrBtn.IsEnabled = false;
            mBtn.IsEnabled = false;
            mAddBtn.IsEnabled = false;
            mSubBtn.IsEnabled = false;
        }

        public void MemoryShow(object sender, EventArgs e)
        {
            MemoryViewer memoryViewer = new MemoryViewer(memory, Output.Text);
            memoryViewer.ShowDialog();

            memory = memoryViewer.memoryUpdated;
            Output.Text = memoryViewer.outputUpdated;
        }

        public void backspace(object sender, EventArgs e)
        {
            if (Output.Text.Length > 1)
            {
                Output.Text = Output.Text.Remove(Output.Text.Length - 1);
            }
            else
            {
                Output.Text = "0";
            }
        }

        bool addWithOutput = false;
        public void Equalss(object sender, EventArgs e)
        {
            if (calcOutput.Text.Contains(operatorChar))
            {

                if (!addWithOutput)
                {
                    calcOutput.Text += $" {Output.Text} =";
                    lastNum = Convert.ToDouble(Output.Text);
                    firstNum = Convert.ToDouble(calcOutput.Text.Substring(0, operatorIndex - 1));
                }
                else
                {
                    calcOutput.Text = $"{firstNum} + {lastNum} =";
                }
                switch (operatorChar)
                {
                    case '+':
                        Output.Text = Convert.ToString(Math.Round(firstNum + lastNum, digits));
                        break;

                    case '-':
                        Output.Text = Convert.ToString(Math.Round(firstNum - lastNum, digits));
                        break;

                    case '×':
                        Output.Text = Convert.ToString(Math.Round(firstNum * lastNum, digits));
                        break;

                    case '÷':
                        Output.Text = Convert.ToString(Math.Round(firstNum / lastNum, digits));
                        break;

                    default: break;
                }
                newCalculation = true;
                string[] calcOutputParts = calcOutput.Text.Split(' ');
                lastNum = Convert.ToDouble(calcOutputParts[2]);
                firstNum = Convert.ToDouble(Output.Text);
                addWithOutput = true;
            }
        }

        public void ClearEntry(object sender, RoutedEventArgs e)
        {
            Output.Text = "0";
            newNum = true;
        }

        public void Clear(object sender, EventArgs e)
        {
            calcOutput.Text = "";
            Output.Text = "0";
            operatorIndex = 0;
            newCalculation = true;
        }

        public void one(object sender, EventArgs e)
        {
            newNumOrCalc("1");
            addWithOutput = false;
        }

        public void two(object sender, EventArgs e)
        {
            newNumOrCalc("2");
            addWithOutput = false;
        }

        public void three(object sender, EventArgs e)
        {
            newNumOrCalc("3");
            addWithOutput = false;
        }

        public void four(object sender, EventArgs e)
        {
            newNumOrCalc("4");
            addWithOutput = false;
        }

        public void five(object sender, EventArgs e)
        {
            newNumOrCalc("5");
            addWithOutput = false;
        }

        public void six(object sender, EventArgs e)
        {
            newNumOrCalc("6");
            addWithOutput = false;
        }

        public void seven(object sender, EventArgs e)
        {
            newNumOrCalc("7");
            addWithOutput = false;
        }

        public void eight(object sender, EventArgs e)
        {
            newNumOrCalc("8");
            addWithOutput = false;
        }

        public void nine(object sender, EventArgs e)
        {
            newNumOrCalc("9");
            addWithOutput = false;
        }

        public void zero(object sender, EventArgs e)
        {
            newNumOrCalc("0");
            addWithOutput = false;
        }

        public void PosNegSwitch(object sender, EventArgs e)
        {
            if (Output.Text[0] != '-')
            {
                Output.Text = '-' + Output.Text;
            }
            else if (Output.Text[0] == '-')
            {
                Output.Text = Output.Text.Substring(1);
            }
        }

        public void DecimalPoint(object sender, EventArgs e)
        {
            newNumOrCalc(",", "0,");
            addWithOutput = false;
        }

        private void newNumOrCalc(string notNewCalc, string newCalc)
        {
            if (!newCalculation)
            {
                Output.Text += notNewCalc;
            }
            else
            {
                Output.Text = newCalc;
                calcOutput.Text = "";
                newCalculation = false;
            }

            if (newNum)
            {
                Output.Text = newCalc;
                newNum = false;
            }

            if (Output.Text == "0")
            {
                Output.Text = newCalc;
            }
        }
        private void newNumOrCalc(string newCalc)
        {
            if (!newCalculation)
            {
                Output.Text += newCalc;
            }
            else
            {
                Output.Text = newCalc;
                calcOutput.Text = "";
                newCalculation = false;
            }

            if (newNum)
            {
                Output.Text = newCalc;
                newNum = false;
            }

            if (Output.Text == "0")
            {
                Output.Text += newCalc;
            }
        }

        private double firstNum = 0;
        private char operatorChar = '+';
        private double lastNum = 0;
        private int operatorIndex = 0;

        private bool newCalculation = true;
        private bool newNum = true;

        public void plus(object sender, EventArgs e)
        {
            operatorChar = '+';
            OpAssignments();
        }

        public void minus(object sender, EventArgs e)
        {
            operatorChar = '-';
            OpAssignments();
        }

        public void multiply(object sender, EventArgs e)
        {
            operatorChar = '×';
            OpAssignments();
        }

        public void divide(object sender, EventArgs e)
        {
            operatorChar = '÷';
            OpAssignments();
        }

        private void OpAssignments()
        {
            firstNum = Convert.ToDouble(Output.Text);
            operatorIndex = Output.Text.Length + 1;
            newNum = true;
            newCalculation = false;
            calcOutput.Text = Output.Text + " " + operatorChar;

        }

        public void SquareRoot(object sender, EventArgs e)
        {
            calcOutput.Text = $"2√{Output.Text} =";
            Output.Text = Convert.ToString(Math.Round(Math.Sqrt(Convert.ToDouble(Output.Text)), digits));
        }

        public void SecondPower(object sender, EventArgs e)
        {
            calcOutput.Text = $"{Output.Text}^2 =";
            Output.Text = Convert.ToString(Math.Round(Math.Pow(Convert.ToDouble(Output.Text), 2), digits));
        }

        public void Fraction(object sender, EventArgs e)
        {
            calcOutput.Text = $"1 ÷ {Output.Text} =";
            Output.Text = Convert.ToString(Math.Round(1 / Convert.ToDouble(Output.Text), digits));
        }

        public void Settings(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();

            Hotkeys();

            if (settings.settingsColor != null)
            {
                settingsBtn.Background = settings.settingsColor;
                outputFarve.Background = settings.textColor;
                calcOutputFarve.Background = settings.textColor;

                //Operator Buttons
                clearEntryBtn.Background = settings.operatorColor;
                clearBtn.Background = settings.operatorColor;
                backspaceBtn.Background = settings.operatorColor;
                fractionBtn.Background = settings.operatorColor;
                powerBtn.Background = settings.operatorColor;
                squareRootBtn.Background = settings.operatorColor;
                divideBtn.Background = settings.operatorColor;
                multiplyBtn.Background = settings.operatorColor;
                minusBtn.Background = settings.operatorColor;
                plusBtn.Background = settings.operatorColor;
                equalsBtn.Background = settings.equalsColor;

                //Number Buttons
                sevenBtn.Background = settings.numberColor;
                eightBtn.Background = settings.numberColor;
                nineBtn.Background = settings.numberColor;
                fourBtn.Background = settings.numberColor;
                fiveBtn.Background = settings.numberColor;
                sixBtn.Background = settings.numberColor;
                oneBtn.Background = settings.numberColor;
                twoBtn.Background = settings.numberColor;
                threeBtn.Background = settings.numberColor;
                zeroBtn.Background = settings.numberColor;
                posNegBtn.Background = settings.numberColor;
                decimalBtn.Background = settings.numberColor;

                //Memory Buttons
                mcBtn.Background = settings.memoryColor;
                mrBtn.Background = settings.memoryColor;
                mAddBtn.Background = settings.memoryColor;
                mSubBtn.Background = settings.memoryColor;
                msBtn.Background = settings.memoryColor;
                mBtn.Background = settings.memoryColor;
            }
        }
    }
}