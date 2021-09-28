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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dzkoledz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Opps 
        {
            none,
            add,
            sub,
            mul,
            div
        }
        enum Type:byte 
        {
            bin = 0,
            oct = 1,
            dec = 2,
            hex = 3
        }
        private int Data;
        private int Memory;
        private Opps Opp;
        private byte Smath;

        public MainWindow()
        {
            InitializeComponent();
            Data = 0;
            Memory = 0;
            Opp = Opps.none;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Data = 0;
            ShowData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NewNumber(1);
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NewNumber(2);
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NewNumber(3);
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NewNumber(4);
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            NewNumber(5);
            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            NewNumber(6);
            
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            NewNumber(7);
            
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            NewNumber(8);
            
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            NewNumber(9);
         
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            NewNumber(0);
            
        }
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Memory = Data;
            Data = 0;
            Opp = Opps.add;
            ShowData();
        }
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            switch (Opp) 
            {
                case Opps.add:
                    Data += Memory;
                    break;
                case Opps.sub:
                    Data = Memory - Data;
                    break;
                case Opps.mul:
                    Data = Memory * Data;
                    break;
                case Opps.div:
                    Data = Memory / Data;
                    break;

            }
            ShowData();
        }
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Memory = Data;
            Data = 0;
            Opp = Opps.sub;
            ShowData();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Memory = Data;
            Data = 0;
            Opp = Opps.mul;
            ShowData();
        }
        private void ShowData() 
        {
            switch (Smath)
            {
                case (byte)Type.bin:
                    Display.Text = Convert.ToString(Data, 2);
                    break;
                case (byte)Type.oct:
                    Display.Text = Convert.ToString(Data, 8);
                    break;
                case (byte)Type.dec:
                    Display.Text = Data.ToString();
                    break;
                case (byte)Type.hex:
                    Display.Text = Data.ToString("X");
                    break;

            }
        }
        private void NewNumber(int number)
        {
            switch (Smath)
            {
                case (byte)Type.bin:
                    Data = Data * 2 + number;
                    break;
                case (byte)Type.oct:
                    Data = Data * 8 + number;
                    break;
                case (byte)Type.dec:
                    Data = Data * 10 + number;
                    break;
                case (byte)Type.hex:
                    Data = Data * 16 + number;
                    break;

            }
            ShowData();
        }
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Memory = Data;
            Data = 0;
            Opp = Opps.div;
            ShowData();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Smath = (byte)((ComboBox)e.Source).SelectedIndex;
            switch (Smath)
            {
                case (byte)Type.bin:
                    number0.IsEnabled = true;
                    number1.IsEnabled = true;
                    number2.IsEnabled = false;
                    number3.IsEnabled = false;
                    number4.IsEnabled = false;
                    number5.IsEnabled = false;
                    number6.IsEnabled = false;
                    number7.IsEnabled = false;
                    number8.IsEnabled = false;
                    number9.IsEnabled = false;
                    numberA.IsEnabled = false;
                    numberB.IsEnabled = false;
                    numberC.IsEnabled = false;
                    numberD.IsEnabled = false;
                    numberE.IsEnabled = false;
                    numberF.IsEnabled = false;
                    break;
                case (byte)Type.oct:
                    number0.IsEnabled = true;
                    number1.IsEnabled = true;
                    number2.IsEnabled = true;
                    number3.IsEnabled = true;
                    number4.IsEnabled = true;
                    number5.IsEnabled = true;
                    number6.IsEnabled = true;
                    number7.IsEnabled = true;
                    number8.IsEnabled = false;
                    number9.IsEnabled = false;
                    numberA.IsEnabled = false;
                    numberB.IsEnabled = false;
                    numberC.IsEnabled = false;
                    numberD.IsEnabled = false;
                    numberE.IsEnabled = false;
                    numberF.IsEnabled = false;
                    break;
                case (byte)Type.dec:
                    number0.IsEnabled = true;
                    number1.IsEnabled = true;
                    number2.IsEnabled = true;
                    number3.IsEnabled = true;
                    number4.IsEnabled = true;
                    number5.IsEnabled = true;
                    number6.IsEnabled = true;
                    number7.IsEnabled = true;
                    number8.IsEnabled = true;
                    number9.IsEnabled = true;
                    numberA.IsEnabled = false;
                    numberB.IsEnabled = false;
                    numberC.IsEnabled = false;
                    numberD.IsEnabled = false;
                    numberE.IsEnabled = false;
                    numberF.IsEnabled = false;
                    break;
                case (byte)Type.hex:
                    number0.IsEnabled = true;
                    number1.IsEnabled = true;
                    number2.IsEnabled = true;
                    number3.IsEnabled = true;
                    number4.IsEnabled = true;
                    number5.IsEnabled = true;
                    number6.IsEnabled = true;
                    number7.IsEnabled = true;
                    number8.IsEnabled = true;
                    number9.IsEnabled = true;
                    numberA.IsEnabled = true;
                    numberB.IsEnabled = true;
                    numberC.IsEnabled = true;
                    numberD.IsEnabled = true;
                    numberE.IsEnabled = true;
                    numberF.IsEnabled = true;
                    break;

            }
            ShowData();

        }

        private void numberA_Click(object sender, RoutedEventArgs e)
        {
            NewNumber(10);
            
        }

        private void numberB_Click(object sender, RoutedEventArgs e)
        {
            NewNumber(11);
        }

        private void numberC_Click(object sender, RoutedEventArgs e)
        {
            NewNumber(12);
        }

        private void numberD_Click(object sender, RoutedEventArgs e)
        {
            NewNumber(13);
        }

        private void numberE_Click(object sender, RoutedEventArgs e)
        {
            NewNumber(14);
        }

        private void numberF_Click(object sender, RoutedEventArgs e)
        {
            NewNumber(15);
        }
    }
}
