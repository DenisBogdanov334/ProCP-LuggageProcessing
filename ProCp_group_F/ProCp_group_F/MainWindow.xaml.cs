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
using System.IO;

namespace ProCp_group_F
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Grid grid;
        grid_cross cross = new grid_cross();
        grid_lineh lineh = new grid_lineh();
        grid_linev linev = new grid_linev();
        grid_cdr cdr = new grid_cdr();
        grid_cdl cdl = new grid_cdl();
        grid_cur cur = new grid_cur();
        grid_cul cul = new grid_cul();
        grid_td td = new grid_td();
        grid_tu tu = new grid_tu();
        grid_tl tl = new grid_tl();
        grid_tr tr = new grid_tr();
        grid_blank blank = new grid_blank();

        int[,] map = new int[10, 10];
        grid_element[,] matrix_elements = new grid_element[10,10];

        public MainWindow()
        {
            InitializeComponent();
            InitializeGridElements();


        }
        private void InitializeGridElements()
        {
            this.grid = maingrid;
            string line;

            using (StreamReader reader = new StreamReader("./maps/map1.txt"))
            {
                int i = 0;
                while ((line = reader.ReadLine()) != null)
                {

                    for (int j = 0; j < 10; j++)
                    {
                        map[i, j] = Convert.ToInt32(line[j].ToString());
                    }
                    i++;
                }
            }
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
                    Rectangle rect = new Rectangle();
                    switch (map[x,y])
                    {
                        case 0:
                            {
                                matrix_elements[x, y] = new grid_blank();
                               rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(blank.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;
                        case 1:
                            {
                                matrix_elements[x, y] = new grid_cross();
                                rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(cross.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;
                        case 2:
                            {
                                matrix_elements[x, y] = new grid_lineh();
                                rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(lineh.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;
                        case 3:
                            {
                                matrix_elements[x, y] = new grid_linev();
                                rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(linev.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;
                        case 4:
                            {
                                matrix_elements[x, y] = new grid_cdr();
                                rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(cdr.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;
                        case 5:
                            {
                                matrix_elements[x, y] = new grid_cdl();
                                rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(cdl.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;
                        case 6:
                            {
                                matrix_elements[x, y] = new grid_cur();
                                rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(cur.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;
                        case 7:
                            {
                                matrix_elements[x, y] = new grid_cul();
                                rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(cul.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;
                        case 8:
                            {
                                matrix_elements[x, y] = new grid_td();
                                rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(td.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;
                        case 9:
                            {
                                matrix_elements[x, y] = new grid_tu();
                                rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(tu.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;
                        case 10:
                            {
                                matrix_elements[x, y] = new grid_tl();
                                rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(tl.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;
                        case 11:
                            {
                                matrix_elements[x, y] = new grid_tr();
                                rect = new Rectangle
                                {
                                    Fill = new ImageBrush
                                    {
                                        ImageSource = new BitmapImage(new Uri(tr.imagePath(), UriKind.Relative))
                                    }
                                };
                            }
                            break;

                        default:
                            break;
                    }
                    
                

                    Grid.SetRow(rect, x);
                    Grid.SetColumn(rect, y);
                    grid.Children.Add(rect);
                    
                }
            }
            
        }

        private async void PresetPath()
        {
            int x, y, px=-1, py=-1;
            string line;
            using (StreamReader reader = new StreamReader("./maps/path.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    Rectangle rect = new Rectangle();
                    if (px!= -1 && py != -1)
                    {
                        y = Convert.ToInt32(line[0].ToString());
                        x = Convert.ToInt32(line[1].ToString());

                        matrix_elements[x, y].Filled = true;
                        matrix_elements[px, py].Filled = false;

                        rect = new Rectangle
                        {
                            Fill = new ImageBrush
                            {
                                ImageSource = new BitmapImage(new Uri(matrix_elements[px, py].imagePath(), UriKind.Relative))
                            }
                        };
                        Grid.SetRow(rect, px);
                        Grid.SetColumn(rect, py);
                        grid.Children.Add(rect);

                        px = x;
                        py = y;
                    }
                    else
                    {
                        y = Convert.ToInt32(line[0].ToString());
                        x = Convert.ToInt32(line[1].ToString());
                        
                        px = x;
                        py = y;

                        matrix_elements[x, y].Filled = true;

                    }
                    rect = new Rectangle
                    {
                        Fill = new ImageBrush
                        {
                            ImageSource = new BitmapImage(new Uri(matrix_elements[x,y].imagePath(), UriKind.Relative))
                        }
                    };
                    Grid.SetRow(rect, x);
                    Grid.SetColumn(rect, y);
                    grid.Children.Add(rect);
                    await Task.Delay(150);
                }
            }
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
                                ImageSource = new BitmapImage(new Uri(cross.imagePath(), UriKind.Relative))
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
                                ImageSource = new BitmapImage(new Uri(cross.imagePath(), UriKind.Relative))
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PresetPath();
        }
    }
}
