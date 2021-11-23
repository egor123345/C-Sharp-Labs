using System;
using System.Collections;
using System.Linq;
using System.Numerics;
using System.Text;


namespace MathVectorLib
{
    /// <inheritdoc cref="IMathVector"/>
    public class MathVector : IMathVector, ICloneable
    {
        public MathVector(params double[] coords)
        {
            coordinates = (double[])coords.Clone();
        }
        double[] coordinates;

        public object Clone()
        {
            return (object)new MathVector(this.coordinates);
        }
        public IEnumerator GetEnumerator()
        {
            return coordinates.GetEnumerator();
        }
        public int dimensions { get { return coordinates.Length; } } 
        public double this[int i]
        {
            get
            {
                return coordinates[i];
            }
            set
            {
                coordinates[i] = value;
            }
        }

        public double length
        {
            get
            {
                
                double sum = 0;
                foreach (var coord in coordinates)
                {
                    sum += Math.Pow(coord, 2);
                }
                return Math.Sqrt(sum);
            }
        }

        public IMathVector sum_number(double number)
        {
            MathVector new_math_vector = (MathVector)this.Clone();
            for (int i = 0; i < new_math_vector.dimensions; i++)
            {
                new_math_vector[i] += number;
            }
            return new_math_vector;
        }

        public IMathVector multiply_number(double number)
        {
            MathVector new_math_vector = (MathVector)this.Clone();
            for (int i = 0; i < new_math_vector.dimensions; i++)
            {
                new_math_vector[i] *= number;
            }
            return new_math_vector;
        }

        public IMathVector sum(IMathVector vector)
        {
            if (vector.dimensions != this.dimensions)
            {
                throw new InvalidOperationException();
            }
            MathVector new_math_vector = (MathVector)this.Clone();
            for (int i = 0; i < new_math_vector.dimensions; i++)
            {
                new_math_vector[i] += vector[i];
            }
            return new_math_vector;

        }

        public IMathVector multiply(IMathVector vector)
        {
            if (vector.dimensions != this.dimensions)
            {
                throw new InvalidOperationException();
            }
            MathVector new_math_vector = (MathVector)this.Clone();
            for (int i = 0; i < new_math_vector.dimensions; i++)
            {
                new_math_vector[i] *= vector[i];
            }
            return new_math_vector;
        }

        public double? scalar_multiply(IMathVector vector)
        {
            if (vector.dimensions != this.dimensions)
            {
                throw new InvalidOperationException();
            }

            double? scalar_mult = 0;
            for (int i = 0; i < this.dimensions; i++)
            {
                scalar_mult += this[i] * vector[i];
            }
            return scalar_mult;
        }

        public double? calc_distance(IMathVector vector)
        {
            if (vector.dimensions != this.dimensions)
            {
                throw new InvalidOperationException();
            }

            double dist = 0;
            for (int i = 0; i < this.dimensions; i++)
            {
                dist += Math.Pow(this[i] - vector[i], 2);
            }
            return Math.Sqrt(dist);
        }

        public static IMathVector operator +(MathVector vector, double number)
        {
            return vector.sum_number(number);
        }
        public static IMathVector operator +(MathVector vector1, IMathVector vector2)
        {
            return vector1.sum(vector2);
        }

        public static IMathVector operator -(MathVector vector, double number)
        {
            return vector.sum_number(number * -1);
        }

        public static IMathVector operator -(MathVector vector1, IMathVector vector2)
        {
            IMathVector neg_vector = vector2.multiply_number(-1);
            return vector1.sum(neg_vector);
        }

        public static IMathVector operator *(MathVector vector, double number)
        {
            return vector.multiply_number(number);
        }
        public static IMathVector operator *(MathVector vector1, IMathVector vector2)
        {
            return vector1.multiply(vector2);
        }


        public static IMathVector operator /(MathVector vector, double number)
        {
                if (number == 0)
                {
                    throw new DivideByZeroException();
                }
                return vector.multiply_number(1 / number);
        }

        public static IMathVector operator /(MathVector vector1, IMathVector vector2)
        {
            IMathVector rev_vector = (MathVector)((MathVector)vector2).Clone();
 
            for (int i = 0; i < vector2.dimensions; i++)
            {
                 if (vector2[i] == 0)
                 {
                      throw new DivideByZeroException();
                 }
                 rev_vector[i] = 1 / vector2[i];
            }
            return vector1.multiply(rev_vector);    
        }

        public static double? operator %(MathVector vector1, IMathVector vector2)
        {
            return vector1.scalar_multiply(vector2);
        }

        public override bool Equals(object obj)
        {
           IMathVector vec2 = (IMathVector)obj;
  
           for (int i = 0; i < this.dimensions; i++)
           {
                if (this[i] != vec2[i])
                {
                    return false;
                }
           }
            return true;
        }
    }
}
