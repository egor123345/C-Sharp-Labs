using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MathVectorLib;


namespace FischerIrises
{
    public partial class Form1 : Form
    {
        public Form1(BaseReader reader)
        {
            InitializeComponent();
            this.reader = reader;
        }

        public BaseReader reader;
        /// <summary>
        /// Clears charts from form.
        /// </summary>
        private void clear_charts(object sender, EventArgs e)
        {
            chart_sepal_length.Series.Clear();
            chart_sepal_width.Series.Clear();
            chart_petal_length.Series.Clear();
            chart_petal_width.Series.Clear();
            pie_chart.Series.Clear();
        }
        /// <summary>
        /// Reads data from file, processes them and presents them as diagrams.
        /// </summary>
        private void but_execute_Click(object sender, EventArgs e)
        {
            clear_charts(sender, e);
            Dictionary<string, List<IMathVector>> irises = reader.read_data(file_path.Text);
            string[] headers = reader.headers;
            if (irises == null)
            {
                MessageBox.Show("error", "cant open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] iris_species = new string[irises.Count];
            List<IMathVector> average_iris_t = vector_opers.calc_average_vect(irises, iris_species);
            
            System.Windows.Forms.DataVisualization.Charting.Chart[] charts = new System.Windows.Forms.DataVisualization.Charting.Chart[]
            {
                chart_sepal_length,
                chart_sepal_width,
                chart_petal_length,
                chart_petal_width,
            };
            chart_drawer drawer = null;
            for (int i = 0; i < average_iris_t.First().dimensions; i++)
            {
                
                drawer = new chart_drawer(charts[i], headers[i], iris_species);
                drawer.draw_bar_by_param(average_iris_t, i);
            }

            List<Pairwise_distance> dist_pairwise = vector_opers.calc_dist_pairwise(average_iris_t, iris_species);
            drawer = new chart_drawer(pie_chart, "Pairwise Euclidean distance", iris_species);
            drawer.draw_pie_by_dist(dist_pairwise);   

        }
        /// <summary>
        /// Opens file dialog and set selected file path into the line "path".
        /// </summary>
        private void browse_but_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            file_path.Text = openFileDialog1.FileName;
        }
    }
}
