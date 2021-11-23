using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathVectorLib;

namespace FischerIrises

{ 
    /// <inheritdoc cref="BaseReader"/>
    class CSVReader : BaseReader
    {
       override public void parse_line(string line) 
        {
            string[] parsed_line = line.Split(',');
            double[] iris_params = new double[parsed_line.Length - 1];

            for (int i = 0; i < parsed_line.Length - 1; i++)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                iris_params[i] = Double.Parse(parsed_line[i]);
            }
            if (!iris_types.Any() || !iris_types.Contains(parsed_line.Last()))
            {
                iris_types.Add(parsed_line.Last());
                irises.Add(parsed_line.Last(), new List<IMathVector>());

            }  
            irises[parsed_line.Last()].Add(new MathVector(iris_params));
        }
        override public void parse_headers(string head_line)
        {
            base.headers = head_line.Split(',');
        }


    }
}
