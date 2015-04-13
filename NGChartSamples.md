# NG Chart usage samples #

In addition, you can use [unit tests](http://ngchart.googlecode.com/svn/trunk/NGChartTests/) as a guide.

## Line charts ##
[View example of line chart with chart title](http://chart.apis.google.com/chart?chls=3,7,1&cht=lc&chs=200x125&chd=s:ABZaz09B&chco=1E90FF&chtt=Line+chart|simple+one&chts=808000,10)

Code to generate the chart (_LineChart type intoduced in v0.5_):
```
LineChart chart = new LineChart(new ChartSize(200, 125),
                        new ChartData(new int[] { 0, 1, 25, 26, 51, 52, 61, 1 }));
chart.Colors = new ChartColors(Color.DodgerBlue);
chart.Title = new ChartTitle("Line chart\nsimple one", Color.Olive, 10);
chart.LineStyles = new LineStyles(new LineStyle(3, 7, 1));
```

## Pie charts ##
### 2D pie chart ###
[View example of 2D Pie chart](http://chart.apis.google.com/chart?cht=p&chs=300x200&chd=s:ZcM)

Code to generate the chart:
```
PieChart chart = new PieChart(PieChartType.Pie2D, 
             new ChartSize(300, 200),
             new ChartData(new int[] { 25, 28, 12 })
             );
```
### 3D pie chart ###

[View example of 3D Pie chart](http://chart.apis.google.com/chart?chl=DodgerBlue|Orchid|DarkSalmon&cht=p3&chs=400x150&chd=s:Zc1&chco=1E90FFFF,DA70D6FF,E9967AFF)

Code to generate the chart:
```
PieChart chart = new PieChart(PieChartType.Pie3D,
             new ChartSize(400, 150),
             new ChartData(new int[] { 25, 28, 53 })
             );

// set colors
Color[] colors = new Color[] { Color.DodgerBlue, Color.Orchid, Color.DarkSalmon };
chart.Colors = new ChartColors(colors);

// generate labels from color names
string[] colorNames = Array.ConvertAll<Color, string>(colors,
                            delegate(Color color)
                            {
                                return color.ToKnownColor().ToString();
                            });
```

## Bar charts ##
### Vertical grouped bar chart with legend ###
[View example of bar chart](http://chart.apis.google.com/chart?cht=bvg&chs=420x125&chd=s:UBZaz,HM85E&chco=1E90FF,9ACD32&chdl=Winter|Summer)

Code to generate the chart:
```
BarChart chart = new BarChart(BarsType.Grouped, BarsDirection.Vertical,
                         new ChartSize(420, 125),
                         new ChartData(new int[][]
                                           {
                                               new int[] { 20, 1, 25, 26, 51 }, 
                                               new int[] { 7, 12, 60, 57, 4 }
                                        })
                         );
chart.Colors = new ChartColors(new Color[] { Color.DodgerBlue, Color.YellowGreen });
chart.Legend = new ChartLegend(new string[] {"Winter", "Summer"});
```

### Horizontal stacked bar chart with legend and custom bar sizes ###
[View example of bar chart](http://chart.apis.google.com/chart?chbh=18,1&cht=bhs&chs=350x140&chd=s:UBZaz,HM85E&chco=1E90FF,9ACD32&chdl=Winter|Summer)

Code to generate the chart:
```
BarChart chart = new BarChart(BarsType.Stacked, BarsDirection.Horizontal,
                         new ChartSize(350, 140),
                         new ChartData(new int[][]
                                           {
                                               new int[] { 20, 1, 25, 26, 51 }, 
                                               new int[] { 7, 12, 60, 57, 4 }
                                        })
                         );
chart.Colors = new ChartColors(new Color[] { Color.DodgerBlue, Color.YellowGreen });
chart.Legend = new ChartLegend(new string[] { "Winter", "Summer" });
chart.BarChartSize = new BarChartSize(18, 1);
```

### QR codes ###
[View QR codes example](http://chart.apis.google.com/chart?chl=Hello%20world&cht=qr&chs=150x150)

Code to generate the QR codes:
```
QRCodes chart = new QRCodes(new ChartSize(150, 150), "Hello world");
```