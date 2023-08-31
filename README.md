# Creating a .NET MAUI Inversed Column Chart to Visualize Meta Reality Labs's Yearly Operating Loss 
The inverted column chart is a commonly used chart type for plotting comparative data values in reverse order. This sample demonstrates how to create an Inversed Column Chart that shows the Metas Reality labs yearly operating losses in .NET MAUI (SfCartesianChart).

## Step 1: Gather yearly revenue loss data
Refer to the [Meta’s Money Pit: Metaverse Bet Bleeds Billions](https://www.statista.com/chart/29236/operating-loss-of-metas-reality-labs-division/) article by Statista and extract data from it. We will utilize the .NET MAUI column chart to create the same user interface.

## Step 2: Populate the data for the inversed column chart
Create the MetaLabLossModel class to hold the year and loss data for Meta’s Reality Labs division with the Year and Loss properties.

Refer to the following code example.

**C#**
```
public class MetaLabLossModel
{
   public double Year { get; set; }
   public double Loss { get; set; }
}
```
Then, generate a collection of Reality Labs division’s operating details with the help of the MetaLabLossDetails class.

**C#**
```
public class MetaLabLossDetails
{
   public MetaLabLossDetails()
   {
      LossDetails = new List<MetaLabLossModel>()
      {
         new MetaLabLossModel {Year = 2019, Loss = -4.5},
         new MetaLabLossModel {Year = 2020, Loss = -6.6},
         new MetaLabLossModel {Year = 2021, Loss = -10.2},
         new MetaLabLossModel {Year = 2022, Loss = -13.7}
      };
   }
   public List< MetaLabLossModel > LossDetails { get; set; }
}
```
## Step 3: Configure the Syncfusion .NET MAUI Cartesian Charts control
Now, configure the Syncfusion .NET MAUI Cartesian Charts control by following this documentation.

Refer to the following code example.

**XAML**
```
<Chart:SfCartesianChart x:Name="chart">
 <Chart:SfCartesianChart.XAxes>
  <Chart:NumericalAxis>
  </Chart:NumericalAxis>
 </Chart:SfCartesianChart.XAxes>
 <Chart:SfCartesianChart.YAxes>
  <Chart:NumericalAxis>
  </Chart:NumericalAxis>
 </Chart:SfCartesianChart.YAxes>
</Chart:SfCartesianChart>
```
## Step 4: Bind data to the chart
Use Syncfusion’s ColumnSeries instance to bind the Meta Reality Labs’s operating loss data into the chart.

Refer to the following code example.

**XAML**
```
<Chart:ColumnSeries XBindingPath="Year" YBindingPath="Loss" ItemsSource="{Binding LossDetails}">
</Chart:ColumnSeries>
```

In this example, we’ve bound the LossDetails with the ItemSource property. We’ve also specified the XBindingPath and YBindingPath with the Year and Loss properties, respectively.

## Step 5: Position the chart axis
To design the inversed column chart, position the chart axis using the CrossesAt and Name properties of the chart axis.

**XAML**
```
<Chart:SfCartesianChart.XAxes>
 <Chart:NumericalAxis CrossesAt="-1" Name="primary">
 </Chart:NumericalAxis>
</Chart:SfCartesianChart.XAxes>
```

To assign the crossing axis to the chart series, use the XAxisName property.

**XAML**
```
<Chart:ColumnSeries XAxisName="primary">
</Chart:ColumnSeries>
```
## Step 6: Customize the chart appearance
Let’s enhance the appearance of the column chart by customizing the axis elements, data labels, column colors, and titles.

Refer to the following code example to add a title to the chart.

**XAML**
```
<Chart:SfCartesianChart.Title>
 <Label Text="Operating Loss of Meta's Reality Labs Division" HorizontalTextAlignment="Center" FontSize="Title" TextColor="#FF5E768E"/>
</Chart:SfCartesianChart.Title>
```

Then, configure the axis and modify the axis elements as shown in the following code example.

**XAML**
```
<Chart:SfCartesianChart.XAxes>
 <Chart:NumericalAxis Interval="1" ShowMajorGridLines="False" >
  <Chart:NumericalAxis.LabelStyle>
   <Chart:ChartAxisLabelStyle FontSize="20" Margin="-40" TextColor="Black"/>
  </Chart:NumericalAxis.LabelStyle>
  <Chart:NumericalAxis.MajorTickStyle>
   <Chart:ChartAxisTickStyle StrokeWidth="0"/>
  </Chart:NumericalAxis.MajorTickStyle>
  <Chart:NumericalAxis.AxisLineStyle>
   <Chart:ChartLineStyle Stroke="Black"/>
  </Chart:NumericalAxis.AxisLineStyle>
 </Chart:NumericalAxis>
</Chart:SfCartesianChart.XAxes>
<Chart:SfCartesianChart.YAxes>
 <Chart:NumericalAxis Maximum="0" IsVisible="False" ShowMajorGridLines="False"/>
</Chart:SfCartesianChart.YAxes>
```

Then, customize the column colors and enable data labels with the desired label formats.

**XAML**
```
<Chart:ColumnSeries XBindingPath="Year"
                    Fill="#FF0A3B7E"
                    YBindingPath="Loss"
                    ItemsSource="{Binding LossDetails}"
                    ShowDataLabels="True">
 <Chart:ColumnSeries.DataLabelSettings>
  <Chart:CartesianDataLabelSettings>
   <Chart:CartesianDataLabelSettings.LabelStyle>
    <Chart:ChartDataLabelStyle FontSize="20" LabelFormat="$0.0B"/>
   </Chart:CartesianDataLabelSettings.LabelStyle>
  </Chart:CartesianDataLabelSettings>
 </Chart:ColumnSeries.DataLabelSettings>
</Chart:ColumnSeries>
```

After executing these code examples, we will get output like in the following image.

<img width="702" alt="InversedColumnChartImage" src="https://github.com/SyncfusionExamples/Creating-a-.NET-MAUI-Inversed-Column-Chart-to-Visualize-Meta-Reality-Labs-s-Yearly-Operating-Loss/assets/105496706/be610823-02a1-4ab5-8450-8280e4931d1a">

For a step by step procedure, refer to the [Meta's Reality Lab's Yearly Operating Loss blog](https://www.syncfusion.com/blogs/post/dotnet-maui-inversed-column-chart-visualize-yearly-operating-loss-data.aspx) 
