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
    /// <summary>
    /// Interaction logic for MemoryViewer.xaml
    /// </summary>
    public partial class MemoryViewer : Window
    {
        List<Button> memoryNums = new List<Button>();
        List<Button> memorySubs = new List<Button>();
        List<Button> memoryAdds = new List<Button>();
        List<Button> memoryClears = new List<Button>();
        List<Grid> grids = new List<Grid>();
        StackPanel stackPanel = new StackPanel();
        public MemoryViewer(List<double> memory, string OutputText)
        {
            InitializeComponent();

            Style firstButtonStyle = (Style)FindResource("MyFirstButtonStyle");
            Style secondButtonStyle = (Style)FindResource("MySecondButtonStyle");

            ToolTip mcT = new ToolTip();
            mcT.Content = "Removes this memory";
            ToolTip msT = new ToolTip();
            msT.Content = "Subtracts this memory number with the number in output";
            ToolTip maT = new ToolTip();
            maT.Content = "Adds this memory number with the number in output";
            ToolTip mT = new ToolTip();
            mT.Content = "Puts this memory number into output";

            int dFontSize = 20;

            for (int i = 0; i < memory.Count; i++)
            {
                Grid grid = new Grid();
                grid.Height = 50;

                ColumnDefinition column1 = new ColumnDefinition();
                ColumnDefinition column2 = new ColumnDefinition();
                ColumnDefinition column3 = new ColumnDefinition();
                ColumnDefinition column4 = new ColumnDefinition();

                column1.Width = new GridLength(1, GridUnitType.Star);
                column2.Width = new GridLength(1, GridUnitType.Star);
                column3.Width = new GridLength(1, GridUnitType.Star);
                column4.Width = new GridLength(2.5, GridUnitType.Star);

                grid.ColumnDefinitions.Add(column1);
                grid.ColumnDefinitions.Add(column2);
                grid.ColumnDefinitions.Add(column3);
                grid.ColumnDefinitions.Add(column4);

                Button memorySub = new Button();
                Button memoryAdd = new Button();
                Button memoryClear = new Button();
                Button memoryNum = new Button();

                memoryClear.Content = "MC";
                memoryClear.Click += MemoryClear;
                memoryClear.FontSize = dFontSize;
                memoryClear.HorizontalContentAlignment = HorizontalAlignment.Center;
                memoryClear.VerticalContentAlignment = VerticalAlignment.Center;
                memoryClear.ToolTip = mcT;

                memorySub.Content = "M-";
                memorySub.Click += MemorySub;
                memorySub.FontSize = dFontSize;
                memorySub.HorizontalContentAlignment = HorizontalAlignment.Center;
                memorySub.VerticalContentAlignment = VerticalAlignment.Center;
                memorySub.ToolTip = msT;

                memoryAdd.Content = "M+";
                memoryAdd.Click += MemoryAdd;
                memoryAdd.FontSize = dFontSize;
                memoryAdd.HorizontalContentAlignment = HorizontalAlignment.Center;
                memoryAdd.VerticalContentAlignment = VerticalAlignment.Center;
                memoryAdd.ToolTip = maT;

                memoryNum.Content = memory[i].ToString();
                memoryNum.Click += MemoryNum;
                memoryNum.FontSize = 30;
                memoryNum.HorizontalContentAlignment = HorizontalAlignment.Right;
                memoryNum.VerticalContentAlignment = VerticalAlignment.Center;
                memoryNum.ToolTip = mT;

                if (int.IsEvenInteger(i))
                {
                    memoryClear.Style = firstButtonStyle;
                    memorySub.Style = firstButtonStyle;
                    memoryAdd.Style = firstButtonStyle;
                    memoryNum.Style = firstButtonStyle;
                }
                else
                {
                    memoryClear.Style = secondButtonStyle;
                    memorySub.Style = secondButtonStyle;
                    memoryAdd.Style = secondButtonStyle;
                    memoryNum.Style = secondButtonStyle;
                }

                Grid.SetColumn(memoryClear, 0);
                Grid.SetColumn(memorySub, 1);
                Grid.SetColumn(memoryAdd, 2);
                Grid.SetColumn(memoryNum, 3);

                memoryClear.Tag = i;
                memorySub.Tag = i;
                memoryAdd.Tag = i;
                memoryNum.Tag = i;

                grid.Children.Add(memoryClear);
                grid.Children.Add(memorySub);
                grid.Children.Add(memoryAdd);
                grid.Children.Add(memoryNum);

                stackPanel.Children.Add(grid);
                memoryClears.Add(memoryClear);
                memorySubs.Add(memorySub);
                memoryAdds.Add(memoryAdd);
                memoryNums.Add(memoryNum);
                grids.Add(grid);
            }
            Content = stackPanel;

            memoryUpdated = memory;
            outputUpdated = OutputText;
        }

        public List<double> memoryUpdated { get; private set; }
        public string outputUpdated { get; private set; }

        public void MemoryClear(object sender, EventArgs e)
        {
            int i = (int)(sender as Button).Tag;
            memoryUpdated.Remove(memoryUpdated[i]);
            stackPanel.Children.Remove(grids[i]);
        }
        public void MemorySub(object sender, EventArgs e)
        {
            int i = (int)(sender as Button).Tag;
            memoryNums[i].Content = Convert.ToString(Convert.ToDouble(memoryNums[i].Content) - Convert.ToDouble(outputUpdated));
            memoryUpdated[i] = Convert.ToDouble(memoryNums[i].Content);
        }
        public void MemoryAdd(object sender, EventArgs e)
        {
            int i = (int)(sender as Button).Tag;
            memoryNums[i].Content = Convert.ToString(Convert.ToDouble(memoryNums[i].Content) + Convert.ToDouble(outputUpdated));
            memoryUpdated[i] = Convert.ToDouble(memoryNums[i].Content);
        }
        public void MemoryNum(object sender, EventArgs e)
        {
            int i = (int)(sender as Button).Tag;
            outputUpdated = memoryNums[i].Content.ToString();
            Close();
        }
    }
}
