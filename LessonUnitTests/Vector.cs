using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonUnitTests
{
    public class Vector
    {
        private readonly double _x; // private поля
        private readonly double _y;
        private readonly double _z;

        public double X => _x;  // публичные свойства
        public double Y => _y;
        public double Z => _z;


        public Vector(double X, double Y, double Z) // Конструктор при создании вектора
        {
            _x = X;
            _y = Y;
            _z = Z;
        }
        // Длина вектора
        /// <summary>
        /// Возвращает длину вектора
        /// </summary>
        /// <returns></returns>
        public double Length()
        {
            return Math.Sqrt(
                _x * _x +
                _y * _y +
                _z * _z);
        }

        // Скалярное произведение с другим вектором
        /// <summary>
        /// Скалярное произведение с другим вектором
        /// </summary>
        /// <param name="vectorB"></param>
        /// <returns></returns>
        public double ScalarProduct(Vector vectorB)
        {
            return (_x * vectorB._x) + (_y * vectorB._y) + (_z * vectorB._z); // возвращает число - скаляр
        }

        //
        /// <summary>
        /// Mетод, вычисляющий векторное произведение с другим вектором
        /// </summary>
        /// <param name="vectorB"></param>
        /// <returns></returns>
        public Vector СrossProduct(Vector vectorB)  // Возвращает новый век тор
        {
            double newVecX, newVecY, newVecZ;
            newVecX = (_y * vectorB._z - _z * vectorB._y);
            newVecY = (_z * vectorB._x - _x * vectorB._z);
            newVecZ = (_x * vectorB._y - _y * vectorB._x);

            return new Vector(newVecX, newVecY, newVecZ);
        }

        // Косинус между двумя векторами
        /// <summary>
        /// Косинус между двумя векторами
        /// </summary>
        /// <param name="vectorB"></param>
        /// <returns></returns>
        public double CosineOfVector(Vector vectorB)
        {
            double lenVectorA = Length();
            double lenVectorB = vectorB.Length();
            double scalarProduct = ScalarProduct(vectorB);

            return (scalarProduct) / (lenVectorA * lenVectorB);
        }

        // Сумма двух векторов
        /// <summary>
        /// Сумма двух векторов, возвращает новый вектор
        /// </summary>
        /// <param name="vectorB"></param>
        /// <returns></returns>
        public Vector SumVector(Vector vectorB)
        {
            double newX, newY, newZ;

            newX = _x + vectorB._x;
            newY = _y + vectorB._y;
            newZ = _z + vectorB._z;

            Vector sumVector = new(newX, newY, newZ);

            return sumVector;
        }

        /// <summary>
        /// Разность двух векторов, возвращает новый вектор
        /// </summary>
        /// <param name="vectorB"></param>
        /// <returns></returns>
        public Vector MinusVector(Vector vectorB)
        {
            double newX, newY, newZ;
            newX = _x - vectorB._x;
            newY = _y - vectorB._y;
            newZ = _z - vectorB._z;
            Vector minusVector = new(newX, newY, newZ);
            return minusVector;
        }
    }
}
