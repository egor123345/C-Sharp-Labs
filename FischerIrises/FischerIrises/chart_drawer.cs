using MathVectorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FischerIrises
{
    /// <summary>
    /// Class for drawing charts by data.
    /// </summary>
    class chart_drawer
    {
        
        /// <param name="chart">Type of chart for drawing.</param>
        /// <param name="title">Title for chart.</param>
        /// <param name="species">Species of data in chart.</param>
        public chart_drawer(System.Windows.Forms.DataVisualization.Charting.Chart chart, string title, string[] species)
        {
            this.chart = chart;
            this.title = title;
            this.iris_species = species;
        }
        /// <summary>
        /// Gets and Sets tittle of chart.
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// Type of chart.
        /// </summary>
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
        /// <summary>
        /// Gets and Sets irises species.
        /// </summary>
        string[] iris_species { get; set; }

        /// <summary>
        /// Configures chart series.
        /// </summary>
        public void draw_base()
        {

            chart.Series.Add(chart.Name);
            chart.Series[0].ChartType = SeriesChartType.Bar;
        }
        /// <summary>
        /// Draws bar chart.
        /// </summary>
        /// <param name="average_iris_t">List of math vectors.</param>
        /// <param name="param_num">Position of the vector coordinate to draw.</param>
        public void draw_bar_by_param(List<IMathVector> average_iris_t, int param_num)
        {
            draw_base();
            int iter = 0;
            foreach (var vector in average_iris_t)
            {
                chart.Titles[0].Text = title;

                chart.Series[0].Points.AddXY(iris_species[iter], vector[param_num]);
                iter++;
            }
        }
        /// <summary>
        /// Draws pie chart.
        /// </summary>
        /// <param name="dist_pairwise">Containts vectors types and their pairwise Euclidean distance.</param>
        public void draw_pie_by_dist(List<Pairwise_distance> dist_pairwise)
        {
            chart.Titles[0].Text = title;
            int iter = 0;
            chart.Series.Add(chart.Name);
            chart.Series[0].ChartType = SeriesChartType.Pie;

            foreach (var dist in dist_pairwise)
            {
                chart.Series[0].Points.AddXY("   " + dist.pairwise + " (" + String.Format("{0:f1}", dist.dist) + ')'
                                                                                        , dist.dist);

                iter++;
            }
        }
    }
}
