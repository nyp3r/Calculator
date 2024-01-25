using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Nyp3rCalculator
{
    public partial class Settings : Window
    {
        public Brush? settingsColor { get; private set; }
        public Brush? operatorColor { get; private set; }
        public Brush? numberColor { get; private set; }
        public Brush? equalsColor { get; private set; }
        public Brush? memoryColor { get; private set; }
        public Brush? textColor { get; private set; }
        public Settings()
        {
            InitializeComponent();

            settingsBtn.Content = Key.F12;
            clearEntryBtn.Content = Key.Delete;
            clearBtn.Content = Key.Delete;
            backBtn.Content = Key.Back;
            fractionBtn.Content = Key.F1;
            powerBtn.Content = Key.F2;
            squareRootBtn.Content = Key.F3;
            divideBtn.Content = Key.Divide;
            sevenBtn.Content = Key.NumPad7;
            eightBtn.Content = Key.NumPad8;
            nineBtn.Content = Key.NumPad9;
            multiplyBtn.Content = Key.Multiply;
            fourBtn.Content = Key.NumPad4;
            fiveBtn.Content = Key.NumPad5;
            sixBtn.Content = Key.NumPad6;
            subtractBtn.Content = Key.Subtract;
            oneBtn.Content = Key.NumPad1;
            twoBtn.Content = Key.NumPad2;
            threeBtn.Content = Key.NumPad3;
            addBtn.Content = Key.Add;
            posNegBtn.Content = Key.Up + " or " + Key.Down;
            zeroBtn.Content = Key.NumPad0;
            decimalBtn.Content = Key.Decimal;
            equalsBtn.Content = Key.Enter;
        }

        public void BeachBtn(object sender, EventArgs e)
        {
            Color settingsHexaColor = (Color)ColorConverter.ConvertFromString("#B3B15D");
            Color operatorHexaColor = (Color)ColorConverter.ConvertFromString("#F4F27E");
            Color numberHexaColor = (Color)ColorConverter.ConvertFromString("#FFF5C2");
            Color textHexaColor = (Color)ColorConverter.ConvertFromString("#3081D0");
            Color memoryHexaColor = (Color)ColorConverter.ConvertFromString("#6DB9EF");
            Color equalsHexaColor = (Color)ColorConverter.ConvertFromString("#44D033");

            settingsColor = new SolidColorBrush(settingsHexaColor);
            operatorColor = new SolidColorBrush(operatorHexaColor);
            numberColor = new SolidColorBrush(numberHexaColor);
            textColor = new SolidColorBrush(textHexaColor);
            memoryColor = new SolidColorBrush(memoryHexaColor);
            equalsColor = new SolidColorBrush(equalsHexaColor);
            this.Close();
        }

        public void DarkBlueBtn(object sender, EventArgs e)
        {
            Color settingsHexaColor = (Color)ColorConverter.ConvertFromString("#164863");
            Color operatorHexaColor = (Color)ColorConverter.ConvertFromString("#427D9D");
            Color numberHexaColor = (Color)ColorConverter.ConvertFromString("#9BBEC8");
            Color textHexaColor = (Color)ColorConverter.ConvertFromString("#DDF2FD");
            Color memoryHexaColor = (Color)ColorConverter.ConvertFromString("#DDF2FD");
            Color equalsHexaColor = (Color)ColorConverter.ConvertFromString("#FAEED1");

            settingsColor = new SolidColorBrush(settingsHexaColor);
            operatorColor = new SolidColorBrush(operatorHexaColor);
            numberColor = new SolidColorBrush(numberHexaColor);
            textColor = new SolidColorBrush(textHexaColor);
            memoryColor = new SolidColorBrush(memoryHexaColor);
            this.Close();
            equalsColor = new SolidColorBrush(equalsHexaColor);
        }

        public void DesertBtn(object sender, EventArgs e)
        {
            Color settingsHexaColor = (Color)ColorConverter.ConvertFromString("#968970");
            Color operatorHexaColor = (Color)ColorConverter.ConvertFromString("#BBAB8C");
            Color numberHexaColor = (Color)ColorConverter.ConvertFromString("#DED0B6");
            Color textHexaColor = (Color)ColorConverter.ConvertFromString("#FAEED1");
            Color memoryHexaColor = (Color)ColorConverter.ConvertFromString("#FDF7E4");
            Color equalsHexaColor = (Color)ColorConverter.ConvertFromString("#248CC3");

            settingsColor = new SolidColorBrush(settingsHexaColor);
            operatorColor = new SolidColorBrush(operatorHexaColor);
            numberColor = new SolidColorBrush(numberHexaColor);
            textColor = new SolidColorBrush(textHexaColor);
            memoryColor = new SolidColorBrush(memoryHexaColor);
            equalsColor = new SolidColorBrush(equalsHexaColor);
            this.Close();
        }

        public void GreenBtn(object sender, EventArgs e)
        {
            Color settingsHexaColor = (Color)ColorConverter.ConvertFromString("#49614B");
            Color operatorHexaColor = (Color)ColorConverter.ConvertFromString("#618264");
            Color numberHexaColor = (Color)ColorConverter.ConvertFromString("#79AC78");
            Color textHexaColor = (Color)ColorConverter.ConvertFromString("#B0D9B1");
            Color memoryHexaColor = (Color)ColorConverter.ConvertFromString("#D0E7D2");
            Color equalsHexaColor = (Color)ColorConverter.ConvertFromString("#248CC3");

            settingsColor = new SolidColorBrush(settingsHexaColor);
            operatorColor = new SolidColorBrush(operatorHexaColor);
            numberColor = new SolidColorBrush(numberHexaColor);
            textColor = new SolidColorBrush(textHexaColor);
            memoryColor = new SolidColorBrush(memoryHexaColor);
            equalsColor = new SolidColorBrush(equalsHexaColor);
            this.Close();
        }

        public void HalloweenNightBtn(object sender, EventArgs e)
        {
            Color settingsHexaColor = (Color)ColorConverter.ConvertFromString("#05131B");
            Color operatorHexaColor = (Color)ColorConverter.ConvertFromString("#092635");
            Color numberHexaColor = (Color)ColorConverter.ConvertFromString("#1B4242");
            Color textHexaColor = (Color)ColorConverter.ConvertFromString("#5C8374");
            Color memoryHexaColor = (Color)ColorConverter.ConvertFromString("#9EC8B9");
            Color equalsHexaColor = (Color)ColorConverter.ConvertFromString("#248CC3");

            settingsColor = new SolidColorBrush(settingsHexaColor);
            operatorColor = new SolidColorBrush(operatorHexaColor);
            numberColor = new SolidColorBrush(numberHexaColor);
            textColor = new SolidColorBrush(textHexaColor);
            memoryColor = new SolidColorBrush(memoryHexaColor);
            equalsColor = new SolidColorBrush(equalsHexaColor);
            this.Close();
        }

        public void LightBlueBtn(object sender, EventArgs e)
        {
            Color settingsHexaColor = (Color)ColorConverter.ConvertFromString("#A9FCFF");
            Color operatorHexaColor = (Color)ColorConverter.ConvertFromString("#52D3D8");
            Color numberHexaColor = (Color)ColorConverter.ConvertFromString("#3887BE");
            Color textHexaColor = (Color)ColorConverter.ConvertFromString("#38419D");
            Color memoryHexaColor = (Color)ColorConverter.ConvertFromString("#200E3A");
            Color equalsHexaColor = (Color)ColorConverter.ConvertFromString("#44D033");

            settingsColor = new SolidColorBrush(settingsHexaColor);
            operatorColor = new SolidColorBrush(operatorHexaColor);
            numberColor = new SolidColorBrush(numberHexaColor);
            textColor = new SolidColorBrush(textHexaColor);
            memoryColor = new SolidColorBrush(memoryHexaColor);
            equalsColor = new SolidColorBrush(equalsHexaColor);
            this.Close();
        }

        public void NatureBtn(object sender, EventArgs e)
        {
            Color settingsHexaColor = (Color)ColorConverter.ConvertFromString("#3D4735");
            Color operatorHexaColor = (Color)ColorConverter.ConvertFromString("#5F6F52");
            Color numberHexaColor = (Color)ColorConverter.ConvertFromString("#A9B388");
            Color textHexaColor = (Color)ColorConverter.ConvertFromString("#FEFAE0");
            Color memoryHexaColor = (Color)ColorConverter.ConvertFromString("#B99470");
            Color equalsHexaColor = (Color)ColorConverter.ConvertFromString("#248CC3");

            settingsColor = new SolidColorBrush(settingsHexaColor);
            operatorColor = new SolidColorBrush(operatorHexaColor);
            numberColor = new SolidColorBrush(numberHexaColor);
            textColor = new SolidColorBrush(textHexaColor);
            memoryColor = new SolidColorBrush(memoryHexaColor);
            equalsColor = new SolidColorBrush(equalsHexaColor);
            this.Close();
        }

        public void NightBtn(object sender, EventArgs e)
        {
            Color settingsHexaColor = (Color)ColorConverter.ConvertFromString("#080A12");
            Color operatorHexaColor = (Color)ColorConverter.ConvertFromString("#161A30");
            Color numberHexaColor = (Color)ColorConverter.ConvertFromString("#31304D");
            Color textHexaColor = (Color)ColorConverter.ConvertFromString("#B6BBC4");
            Color memoryHexaColor = (Color)ColorConverter.ConvertFromString("#F0ECE5");
            Color equalsHexaColor = (Color)ColorConverter.ConvertFromString("#248CC3");

            settingsColor = new SolidColorBrush(settingsHexaColor);
            operatorColor = new SolidColorBrush(operatorHexaColor);
            numberColor = new SolidColorBrush(numberHexaColor);
            textColor = new SolidColorBrush(textHexaColor);
            memoryColor = new SolidColorBrush(memoryHexaColor);
            equalsColor = new SolidColorBrush(equalsHexaColor);
            this.Close();
        }

        public void PinkPrincessBtn(object sender, EventArgs e)
        {
            Color settingsHexaColor = (Color)ColorConverter.ConvertFromString("#FFEBF6");
            Color operatorHexaColor = (Color)ColorConverter.ConvertFromString("#FED9ED");
            Color numberHexaColor = (Color)ColorConverter.ConvertFromString("#E7BCDE");
            Color textHexaColor = (Color)ColorConverter.ConvertFromString("#BB9CC0");
            Color memoryHexaColor = (Color)ColorConverter.ConvertFromString("#67729D");
            Color equalsHexaColor = (Color)ColorConverter.ConvertFromString("#248CC3");

            settingsColor = new SolidColorBrush(settingsHexaColor);
            operatorColor = new SolidColorBrush(operatorHexaColor);
            numberColor = new SolidColorBrush(numberHexaColor);
            textColor = new SolidColorBrush(textHexaColor);
            memoryColor = new SolidColorBrush(memoryHexaColor);
            equalsColor = new SolidColorBrush(equalsHexaColor);
            this.Close();
        }

        public void PurplePrincessBtn(object sender, EventArgs e)
        {
            Color settingsHexaColor = (Color)ColorConverter.ConvertFromString("#251742");
            Color operatorHexaColor = (Color)ColorConverter.ConvertFromString("#392467");
            Color numberHexaColor = (Color)ColorConverter.ConvertFromString("#5D3587");
            Color textHexaColor = (Color)ColorConverter.ConvertFromString("#A367B1");
            Color memoryHexaColor = (Color)ColorConverter.ConvertFromString("#FFD1E3");
            Color equalsHexaColor = (Color)ColorConverter.ConvertFromString("#248CC3");

            settingsColor = new SolidColorBrush(settingsHexaColor);
            operatorColor = new SolidColorBrush(operatorHexaColor);
            numberColor = new SolidColorBrush(numberHexaColor);
            textColor = new SolidColorBrush(textHexaColor);
            memoryColor = new SolidColorBrush(memoryHexaColor);
            equalsColor = new SolidColorBrush(equalsHexaColor);
            this.Close();
        }

        public void RedBtn(object sender, EventArgs e)
        {
            Color settingsHexaColor = (Color)ColorConverter.ConvertFromString("#550707");
            Color operatorHexaColor = (Color)ColorConverter.ConvertFromString("#7D0A0A");
            Color numberHexaColor = (Color)ColorConverter.ConvertFromString("#BF3131");
            Color textHexaColor = (Color)ColorConverter.ConvertFromString("#EAD196");
            Color memoryHexaColor = (Color)ColorConverter.ConvertFromString("#F3EDC8");
            Color equalsHexaColor = (Color)ColorConverter.ConvertFromString("#248CC3");

            settingsColor = new SolidColorBrush(settingsHexaColor);
            operatorColor = new SolidColorBrush(operatorHexaColor);
            numberColor = new SolidColorBrush(numberHexaColor);
            textColor = new SolidColorBrush(textHexaColor);
            memoryColor = new SolidColorBrush(memoryHexaColor);
            equalsColor = new SolidColorBrush(equalsHexaColor);
            this.Close();
        }
    }
}
