# .NET class library to work with [Google Chart API](http://code.google.com/apis/chart/) #

.NET wrapper to simplify charts generation.

## Quick sample ##
Code for URL generation will looks like:

```
LineChart chart = new LineChart(
   new ChartSize(200, 125), 
   new ChartData(new int[] { 0, 1, 25, 26, 51, 52, 61, 1 })
   );

return chart.ToString();
```

and it generates an url like this:

http://chart.apis.google.com/chart?cht=lc&chs=200x125&chd=s:ABZaz09B

[More samples](NGChartSamples.md)

## Changes ##

**Jul 20, 2008**
  * _v0.6.0.0 is available to [download](http://ngchart.googlecode.com/files/ngchart-0.6.0.0.zip)_
  * Added support for [QR codes](http://code.google.com/apis/chart/#qrcodes) (two-dimensional barcode).

**Sun, Mar 02, 2008**
  * Automatically choose between Simple and Extended encoding
  * Line charts are separate type now (_old way of line charts creating is marked as obsolete now_)
  * Line styles are added

**Sat, Dec 15, 2007**
  * Extended encoding added.
  * Initial logic to choose encoder depending on dataset site (simple or extended)

**Thu, Dec 13, 2007**
  * Text encoding added

**Mon, Dec 10, 2007**
  * _v0.4.0.0 is available to [download](http://ngchart.googlecode.com/files/ngchart-0.4.0.0.zip)_
  * Bar charts are separate types now (_old way of bar chart creation marked as obsolete now_)
  * Added control over bar thickness and bars spacing.
  * [Samples page](NGChartSamples.md) updated

**Sun, Dec 09, 2007**
  * _v0.3.0.0 is available to [download](http://ngchart.googlecode.com/files/ngchart-0.3.0.0.zip)_
  * Bar charts added
  * Pie charts added
  * Pie chart labels added
  * Chart title support with (font color and font size)
  * Chart legend support

**Sat, Dec 08, 2007**
  * Color support added