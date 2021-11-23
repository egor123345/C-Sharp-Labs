using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathVectorLib;

namespace FischerIrises
{
    /// <summary>
    /// Contains types of  vectors and Euclidean distance between them.
    /// </summary>
    public struct Pairwise_distance
    {
        /// <summary>
        /// Euclidean distance between vectors.
        /// </summary>
        public double? dist;

        /// <summary>
        /// String with types of  2 irises.
        /// </summary>
        public string pairwise;
    }
    /// <summary>
    /// Class with methods for working with math vectors.
    /// </summary>
    static class vector_opers
    {
        /// <summary>
        /// Calculates average value for each vector coordinates.
        /// </summary>
        /// <param name="vectors">Array of source vectors.</param>
        /// <returns>New math vector with average value for each vector coordinates by source vectors.</returns>
        static public IMathVector calc_average(IMathVector[] vectors)
        {
            double[] average_par = new double[vectors[0].dimensions];

            for (int i = 0; i < vectors[i].dimensions; i++)
            {
              double s = 0;
              for (int j = 0; j < vectors.Length; j++)
              {
                    s += vectors[j][i];  
              }
                average_par[i] = s / vectors.Length;
            }
            return new MathVector(average_par);
        }
        /// <summary>
        ///  Calculates average vector for each irises type.
        /// </summary>
        /// <param name="irises">Key is irises type, Value is list of irises.</param>
        /// <param name="species">Irises types.</param>
        /// <returns>List of average vectors for each irises type.</returns>
        static public List<IMathVector> calc_average_vect(Dictionary<string, List<IMathVector>> irises, string[] species)
        {
            List<IMathVector> average_iris_t = new List<IMathVector>();

            int iter = 0;
            foreach (var pair in irises)
            {
                species[iter] = pair.Key;
                average_iris_t.Add(vector_opers.calc_average(irises[pair.Key].ToArray()));
                iter++;
            }
            return average_iris_t;
        }

        /// <summary>
        /// Calculates pairwise Euclidean distance from source vectors.
        /// </summary>
        /// <param name="vectors">Vectors for calculating.</param>
        /// <param name="species">Irises types.</param>
        /// <returns>List with pairwise distance.</returns>
        static public List<Pairwise_distance> calc_dist_pairwise(List<IMathVector> vectors, string[] species)
        {
            List<Pairwise_distance> pairwise_dist = new List<Pairwise_distance>();

            for (int i = 0; i < vectors.Count; i++)
            {
                for (int j = i + 1; j < vectors.Count; j++)
                {
                    Pairwise_distance pairwise_distance;
                    pairwise_distance.dist = vectors[i].calc_distance(vectors[j]);
                    pairwise_distance.pairwise = species[i] + '-' + species[j];
                    pairwise_dist.Add(pairwise_distance); 
                }
            }
            return pairwise_dist;
        }
    }
}
