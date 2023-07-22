using DevExpress.XtraCharts;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ModelingEventFlows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            flowIntensityErrorLabel.Visible = false;
            simulationTimeErrorLabel.Visible = false;
            eventsCountLabel.Text = "Число событий = ";

            double[] timePoints = null;

            try
            {
                // валидация данных
                double simulationTime = -1.0;
                if (double.TryParse(simulationTimeTextEdit.Text,NumberStyles.Any, 
                    CultureInfo.InvariantCulture, out double simulationTimeValue))
                    simulationTime = simulationTimeValue;

                double flowIntensity = -1.0;
                if (double.TryParse(flowIntensityTextEdit.Text, NumberStyles.Any, 
                    CultureInfo.InvariantCulture, out double flowIntensityValue))
                    flowIntensity = flowIntensityValue;

                // запуск моделирования
                var poissonEventFlow = new PoissonEventsFlow(simulationTime: simulationTime, flowIntensity: flowIntensity);
                timePoints = poissonEventFlow.RunModelingProcess();
                eventsCountLabel.Text += poissonEventFlow.EventsCount.ToString();
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "flowIntensity")
                    flowIntensityErrorLabel.Visible = true;
                if (ex.ParamName == "simulationTime")
                    simulationTimeErrorLabel.Visible = true;
            }

            BuildGraph(timePoints);
           
        }

        private void BuildGraph(double[] timePoints)
        {
            if (timePoints == null) return;

            chartControl.Series.Clear();    

            // время моделирования
            double maxValue = timePoints.Max();
            var lineSeries = new Series("Line series", ViewType.Line);
            lineSeries.Points.Add(new SeriesPoint(0,1));
            lineSeries.Points.Add(new SeriesPoint(maxValue,1));
            chartControl.Series.Add(lineSeries);

            // приходы изделий
            var pointSeries = new Series("Point series", ViewType.Point);
            foreach (var point in timePoints)
                pointSeries.Points.Add(new SeriesPoint(point, 2));
            chartControl.Series.Add(pointSeries);
        }
    }
}
