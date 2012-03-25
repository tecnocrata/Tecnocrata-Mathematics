using System;
using System.Collections.Generic;
using System.Text;

namespace Tx.Math
{
    public class ComplexNumber
    {
        private float real;
        private float imaginary;

        public ComplexNumber()
            : this(0, 0)  // constructor
        {
        }

        public ComplexNumber(int r, int i)  // constructor
        {
            real = r;
            imaginary = i;
        }

        public ComplexNumber(float r, float i)  // constructor
        {
            real = r;
            imaginary = i;
        }

        public float Real
        {
            get { return real; }
            set { real = value; }
        }

        public float Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        // Sobreescribe ToString() para mostrar el numero complejo en formato tradicional:
        public override string ToString()
        {
            return (System.String.Format("{0} + {1}i", real, imaginary));
        }

        // Sobrecarga el operador '+':
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real + b.real, a.imaginary + b.imaginary);
        }

        // Sobrecarga el operador '+':
        public static ComplexNumber operator +(ComplexNumber a, int b)
        {
            return new ComplexNumber(a.real +b, a.imaginary);
        }

        // Sobrecarga el operador '+':
        public static ComplexNumber operator +(int a, ComplexNumber b)
        {
            return new ComplexNumber(b.real + a, b.imaginary);
        }
        // Sobrecarga el operador '-':
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real - b.real, a.imaginary - b.imaginary);
        }

        // Sobrecarga el operador '*':
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real * b.real, a.imaginary * b.imaginary);
        }

        // Sobrecarga el operador '/':
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real / b.real, a.imaginary / b.imaginary);
        }
    }


}
