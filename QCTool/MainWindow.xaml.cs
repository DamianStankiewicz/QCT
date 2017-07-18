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

namespace QCTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    //public class CustomWatermarkedDatePicker : DatePicker
    //{
    //    public override void OnApplyTemplate()
    //    {
    //        base.OnApplyTemplate();

    //        DatePickerTextBox box = base.GetTemplateChild("PART_TextBox") as DatePickerTextBox;
    //        box.ApplyTemplate();

    //        ContentControl watermark = box.Template.FindName("PART_Watermark", box) as ContentControl;
    //        watermark.Content = "";
    //    }
    //}

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btStartMeasuring_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sadasd");
        }

        private void btMeasure_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("asdasd");
        }

        private void dpCalendarStart_CalendarClosed(object sender, RoutedEventArgs e)
        {
            tbStartDate.Text = dpCalendarStart.Text;
        }

        private void dpCalendarEnd_CalendarClosed(object sender, RoutedEventArgs e)
        {
            tbEndDate.Text = dpCalendarEnd.Text;
        }
    }
}
