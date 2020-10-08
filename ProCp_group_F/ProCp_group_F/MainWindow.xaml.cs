using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ProCp_group_F
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Grid grid;
        
        public MainWindow()
        {
            InitializeComponent();
            this.grid = maingrid;
            InitializeGridElements();
        }
        private void InitializeGridElements()
        {
            // Gets the height and width of the rectangle by finding the proportion using the grid width and height
            RowDefinitionCollection rowDefinitions = grid.RowDefinitions;
            ColumnDefinitionCollection columnDefinitions = grid.ColumnDefinitions;

            for (int x = 0; x < 10; x++)
            {
                // Define rows
                RowDefinition rowDefinition = new RowDefinition
                {
                    Height = new GridLength(1, GridUnitType.Star)
                };
                rowDefinitions.Add(rowDefinition);
            }
            for (int y = 0; y < 10; y++)
            {
                // Define columns
                ColumnDefinition columnDefinition = new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                };
                columnDefinitions.Add(columnDefinition);
            }

            // Populates the 2D grid rectangles array
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    // Create rectangle to be added
                    Rectangle rect = new Rectangle
                    {
                        Fill = new ImageBrush {
                            ImageSource = new BitmapImage(new Uri(@"./images/grid_default.jpg", UriKind.Relative))
                }
                    };
                

                    Grid.SetRow(rect, x);
                    Grid.SetColumn(rect, y);
                    grid.Children.Add(rect);
                    
                }
            }
            Rectangle rect1 = new Rectangle
            {
                Fill = new ImageBrush
                {
                    ImageSource = new BitmapImage(new Uri(@"./images/grid_default_filled.jpg", UriKind.Relative))
                }
            };
            Grid.SetRow(rect1, 0);
            Grid.SetColumn(rect1, 0);
            grid.Children.Add(rect1);

        }

        private void UpdateGridElements(int xc, int yc)
        {
            // Populates the 2D grid rectangles array
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Rectangle rect;
                    if (x == xc && y == yc)
                    {
                        rect = new Rectangle
                        {
                            Fill = new ImageBrush
                            {
                                ImageSource = new BitmapImage(new Uri(@"./images/grid_default_filled.jpg", UriKind.Relative))
                            }
                        };
                    }
                    else
                    {
                        // Create rectangle to be added
                        rect = new Rectangle
                        {
                            Fill = new ImageBrush
                            {
                                ImageSource = new BitmapImage(new Uri(@"./images/grid_default.jpg", UriKind.Relative))
                            }
                        };
                    }


                    Grid.SetRow(rect, x);
                    Grid.SetColumn(rect, y);
                    grid.Children.Add(rect);

                }
            }
            grid.UpdateLayout();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i%2 == 0)
                    {
                        UpdateGridElements(i, j);
                    }
                    else
                    {
                        UpdateGridElements(i, 9 - j);
                    }
                    await Task.Delay(150);
                }
            }
        }
    }
}
