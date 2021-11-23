using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathVectorLib;


namespace FischerIrises
{
    /// <summary>
    /// Class for reading data from file and representation data as math vectors.
    /// </summary>
    public abstract class BaseReader
    {   
        /// <summary>
        /// Gets and sets path of file for reading.
        /// </summary>
        public string file_path { get; set; }
        /// <summary>
        /// Key is type of vectors, Value is list with math vectors.
        /// </summary>
        public Dictionary<string, List<IMathVector>> irises;
        
        /// <summary>
        /// Gets and sets info about math vectors coordinates.
        /// </summary>
        public string[] headers { get; set; }

        /// <summary>
        /// Gets and sets types of vectors.
        /// </summary>
        public List<string> iris_types { get; set; }

        /// <summary>
        /// Reads data from file and representation data
        /// as a dictionary with type of math vectors and math vectors.
        /// </summary>
        /// <param name="file_path">Path of reading file</param>
        /// <returns>Dictionary with type of math vectors and math vectors.</returns>
        public Dictionary<string, List<IMathVector>> read_data(string file_path)
        {
            this.file_path = file_path;
            irises = new Dictionary<string, List<IMathVector>>();
            iris_types = new List<string>();
            try
            {
                using (StreamReader freader = new StreamReader(file_path))
                {
                    if (!freader.EndOfStream)
                    {
                        parse_headers(freader.ReadLine());
                    }
                    while (!freader.EndOfStream)
                    {
                        parse_line(freader.ReadLine());

                    }
                }

                return irises;
            }

            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Parses headers and adds it to headers.
        /// </summary>
        /// <param name="str">Headers for parsing.</param>
        abstract public void parse_headers(string str);

        /// <summary>
        /// Parses line and adds it to irises
        /// </summary>
        /// <param name="str">Line for parsing.</param>
        abstract public void parse_line(string str);

    }
}
