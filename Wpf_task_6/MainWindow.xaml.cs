using System;
using System.Windows;

namespace Wpf_task_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        class WeatherControl
        {
            public static readonly DependencyProperty TemperatureProperty = //свойство зависимости
                DependencyProperty.Register(
                    nameof(Temperature),
                    typeof(string),
                    typeof(MainWindow),
                    new PropertyMetadata(""));
            private int temperature;
            private string windDirection;
            private int windSpeed;
            private int rainfall;
            public int Temperature  //температура
            {
                get
                {
                    return this.temperature;
                }
                set
                {
                    if (value < -50)
                        temperature = -50;
                    else if (value > 50)
                        temperature = 50;
                    else
                        this.temperature = value;
                }
            }
            public string WindDirection { get; set; }   //направление ветра
            public int WindSpeed { get; set; }  //скорость ветра
            private enum Rainfall : int { солнечно, облачно, дождь, снег }  //осадки
            public WeatherControl(int temperature, string windDirection, int windSpeed, int rainfall)
            {
                this.temperature = temperature;
                this.windDirection = windDirection;
                this.windSpeed = windSpeed;
                this.rainfall = rainfall;
            }
            public string Print()
            {
                return string.Format("Температура - {0}, направление ветра - (1), скорость ветра - {2}, {3}", temperature, windDirection, windSpeed, rainfall);
            }
        }
    }
}