Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_3DStackedAreaChart
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
            ' Create a new chart.
            Dim stackedArea3DChart As New ChartControl()

            ' Create two series of the StackedArea3D view type.
            Dim series1 As New Series("Series 1", ViewType.StackedArea3D)
            Dim series2 As New Series("Series 2", ViewType.StackedArea3D)

            ' Populate both series with points.
            series1.Points.Add(New SeriesPoint("A", 80))
            series1.Points.Add(New SeriesPoint("B", 20))
            series1.Points.Add(New SeriesPoint("C", 50))
            series1.Points.Add(New SeriesPoint("D", 30))
            series2.Points.Add(New SeriesPoint("A", 40))
            series2.Points.Add(New SeriesPoint("B", 60))
            series2.Points.Add(New SeriesPoint("C", 20))
            series2.Points.Add(New SeriesPoint("D", 80))

            ' Add the series to the chart.
            stackedArea3DChart.Series.AddRange(New Series() {series1, series2})

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, StackedArea3DSeriesView).AreaWidth = 4
            CType(series2.View, StackedArea3DSeriesView).AreaWidth = 3

            ' Access the diagram's options.
            CType(stackedArea3DChart.Diagram, XYDiagram3D).ZoomPercent = 110

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "3D Stacked Area Chart"
            stackedArea3DChart.Titles.Add(chartTitle1)
            stackedArea3DChart.Legend.Visible = False

            ' Add the chart to the form.
            stackedArea3DChart.Dock = DockStyle.Fill
            Me.Controls.Add(stackedArea3DChart)
        End Sub

    End Class
End Namespace