using System;
using System.Collections;
using System.Numerics;
using System.Text;


namespace MathVectorLib
{
    /// <summary>
    /// Class for working with math vector.
    /// </summary>
    public interface IMathVector : IEnumerable
    {
        /// <summary>
        /// Gets dimension of the math vector.
        /// </summary>
        int dimensions { get; }

        /// <summary>
        /// Gets and sets element of math vector by index.
        /// </summary>
        /// <param name="i">Index of the coordinate in math vector.</param>
        /// <returns>Coordinate of math vector by index.</returns>
        double this[int i] { get; set; }

        /// <summary>
        /// Gets the length of math vector.
        /// </summary>
        double length { get; }

        /// <summary>
        /// Calculates sum of math vector and number.
        /// </summary>
        /// <param name="number">Number for sum with math vector.</param>
        /// <returns>New math vector as the sum of current vector and number.</returns>
        IMathVector sum_number(double number);

        /// <summary>
        /// Calculates multiplication of math vector and number.
        /// </summary>
        /// <param name="number">Number for multiplication with math vector.</param>
        /// <returns>New math vector as the multiplication of current vector and number.</returns>
        IMathVector multiply_number(double number);

        /// <summary>
        /// Calculates sum of 2 math vectors.
        /// </summary>
        /// <param name="vector">Math vector for sum with current vector.</param>
        /// <returns>New vector as sum of 2 vectors. </returns>
        IMathVector sum(IMathVector vector);

        /// <summary>
        /// Calculates multiplication of 2 math vectors.
        /// </summary>
        /// <param name="vector">Math vector for multiplication with current vector.</param>
        /// <returns>New vector as multiplication of 2 vectors.</returns>
        IMathVector multiply(IMathVector vector);

        /// <summary>
        /// Calculates scalar multiplication of 2 math vectors.
        /// </summary>
        /// <param name="vector">Math vector for scalar multiplication with current vector.</param>
        /// <returns>Value of scalar multiplication of 2 vectors.</returns>
        double? scalar_multiply(IMathVector vector);

        /// <summary>
        /// Calculates  Euclidean distance of 2 math vectors.
        /// </summary>
        /// <param name="vector">Math vector for calculate Euclidean distance with current vector. </param>
        /// <returns>Value of Euclidean distance of 2 math vectors.</returns>
        double? calc_distance(IMathVector vector);
    }
}
