using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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

namespace AsyncTestUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private CancellationTokenSource _cts = new CancellationTokenSource();
        
        private string[] _url = new string[]
        {
            "http://yandex.ru",
            "http://google.ru",
            "http://google.ru",
            "http://google.ru",
            "http://google.ru",
            "http://google.ru",
            "http://vk.com",
            "http://msdn.com",
            "http://msdn.com",
            "http://msdn.com",
            "http://msdn.com",
            "http://msdn.com",
            //"http://microsoft.com",
        };
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private string LoadAllData()
        {
            StringBuilder sb = new StringBuilder();
            var time = Stopwatch.StartNew();
            
            // sync var 1
            foreach (var url in _url)
            {
                var result = LoadData(url);
                sb.AppendLine($"{url}: {result}");
            }
            
            time.Stop();
            sb.AppendLine($"TOTAL time: {time.ElapsedMilliseconds}ms");
            return sb.ToString();
        }
        private string LoadAllDataParallel()
        {
            StringBuilder sb = new StringBuilder();
            object sync = new object();
            var time = Stopwatch.StartNew();

            Parallel.ForEach(_url, url =>
            {
                var result = LoadData(url);
                lock (sync)
                {
                    sb.AppendLine($"{url}: {result}");
                }
                
                Task.Delay(TimeSpan.FromSeconds(0.5));
            });
            
            time.Stop();
            sb.AppendLine($"TOTAL time: {time.ElapsedMilliseconds}ms");
            return sb.ToString();
        }
        
        private async Task<string> LoadAllDataByTasks()
        { 
            //return LoadAllDataParallel();
            StringBuilder sb = new StringBuilder();
            var time = Stopwatch.StartNew();
            
            foreach (var url in _url)
            {
                if (_cts.IsCancellationRequested)
                {
                    sb.AppendLine("Была запрошена отмена операции.");
                    break;
                }
                
                var result = await LoadDataAsync(url); 
                sb.AppendLine($"{url}: {result}");
            }
            
            time.Stop();
            
            sb.AppendLine($"TOTAL time: {time.ElapsedMilliseconds}ms");
            return sb.ToString();

        }

        private string LoadData(string url)
        {
            var time = Stopwatch.StartNew();
            var webClient = new WebClient();
            try
            {
                var result = webClient.DownloadString(url);
                time.Stop();
                return $"SIZE:{result.Length}. TIME:{time.ElapsedMilliseconds}ms";
            }
            catch (WebException e)
            {
                return $"Error load {url}. {e.Message}";
            }
        }

        private async Task<string> LoadDataAsync(string url)
        {
            var time = Stopwatch.StartNew();
            var webClient = new WebClient();
            try
            {
                var result = await webClient.DownloadStringTaskAsync(url);
                time.Stop();
                return $"SIZE:{result.Length}. TIME:{time.ElapsedMilliseconds}ms";
            }
            catch (WebException e)
            {
                return $"Error load {url}. {e.Message}";
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            StatusLogTextBlock.Text = LoadAllData();
        }
        
        private void Parallel_OnClick(object sender, RoutedEventArgs e)
        {
            StatusLogTextBlock.Text = LoadAllDataParallel();
        }
        
        private async void Tasks_OnClick(object sender, RoutedEventArgs e)
        {
            _cts = new CancellationTokenSource();
            
            TaskButton.IsEnabled = false;
            CancelButton.IsEnabled = true;
            
            StatusLogTextBlock.Text = await LoadAllDataByTasks();
            
            TaskButton.IsEnabled = true;
            CancelButton.IsEnabled = false;

        }
        
        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            _cts.Cancel();
        }
        
    }
}