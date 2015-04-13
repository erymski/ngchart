# Data encoding in NGChart #

Google Chart API supports three encoding types:
  * simple
  * text
  * extended.

More technical details on encoding you can find at the [API documentation page](http://code.google.com/apis/chart/#chart_data).

NGChart supports all encoding types since v.0.5.0.0.

To simplify developer's life NGChart will try to automatically choose the proper encoding.
You need to create an instance of ChartData class, and pass your dataset to the constructor.

Internally it uses the following logic:

  * if dataset consists of floats or doubles - it uses Text Encoding,
  * if dataset consists of ints and all values are less than 61 - it uses Simple encoding,
  * otherwise it uses Extended encoding.