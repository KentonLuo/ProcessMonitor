using System;
using System.Windows;
using System.Windows.Controls;

namespace ProcessMonitor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel objMainViewModel = null;
        public MainWindow()
        {
            InitializeComponent();
            this.objMainViewModel = new MainViewModel();
            this.DataContext = this.objMainViewModel;
            //this.objMainViewModel.Start();
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.btn_start.IsEnabled = false;
            //this.btn_stop.IsEnabled = true;
            //this.objMainViewModel.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //this.btn_start.IsEnabled = true;
            //this.btn_stop.IsEnabled = false;
            this.objMainViewModel.Stop();
        }

        private void DG_Infos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (this.DG_Infos.SelectedIndex > 0)
            //{
            //    this.btn_start.IsEnabled = true;
            //}

            //else
            //{
            //    this.btn_start.IsEnabled = false;
            //}
        }

        private void Cb_SelectAll_Checked(object sender, RoutedEventArgs e)
        {
            if (objMainViewModel != null)
            {
                objMainViewModel.SelectAll();
            }
        }

        private void Cb_SelectAll_Unchecked(object sender, RoutedEventArgs e)
        {
            if (objMainViewModel != null)
            {
                objMainViewModel.UnSelectAll();
                //this.DG_Infos.UpdateLayout();
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (objMainViewModel != null)
            {
                objMainViewModel.JudgeCheckAllState();
                //this.DG_Infos.UpdateLayout();
            }
        }

        private void Cpu_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (objMainViewModel != null)
            {
                Double.TryParse(this.Cpu_tb.Text, out double value);
                objMainViewModel.CpuLimitValue = value;
            }
        }

        private void Memory_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (objMainViewModel != null)
            {
                Double.TryParse(this.Memory_tb.Text, out double value);
                objMainViewModel.MemoryLimitValue = value;
            }
        }
    }
}
