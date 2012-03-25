using System;
using System.Collections.Generic;
using System.Text;

namespace Tx.Math
{
    public class Set
    {
        const int MAX_NUMS = 20;
        int[] numeros; 
        private int _longitud;
        public int Length
        {
            get { return _longitud; }
            set
            {
                value = numeros.Length - 1;
                _longitud = value;
            }
        }
        public Set()
        {
            numeros = new int[MAX_NUMS];
            ClearSet();
        }

        public int Element(int n)
        {
            return (numeros[n - 1]);
        }
        public void ClearSet()
        {
            for (int i = 0; i < MAX_NUMS; i++) numeros[i] = 0;
        }

        public int NumberofElements()
        {
            int largo = 0;
            foreach (int n in numeros)
            {
                if (n == 0) break;
                largo++;
            }
            return (largo);
        }

        public bool Contains(int a)
        {
            foreach (int n in numeros)
                if (n == a) return (true);
            return (false);
        }
        public void Add(int a)
        {
            int posicion;
            posicion = NumberofElements();
            if (!Contains(a) && posicion < numeros.Length) numeros[posicion] = a;
        }


        public Set Union(Set c2)
        {
            Set c = new Set();
            for (int i = 0; i < this.NumberofElements(); i++)
                c.Add(this.Element(i + 1));
            for (int i = 0; i < c2.NumberofElements(); i++)
                if (!c.Contains(c2.Element(i + 1)))
                    c.Add(c2.Element(i + 1));

            return (c);
        }

        public Set Intersection(Set c2)
        {
            Set c = new Set();
            for (int i = 0; i < this.NumberofElements(); i++)
                if (c2.Contains(this.Element(i + 1)))
                    c.Add(this.Element(i + 1));

            return (c);
        }
        public Set Substract(Set c2)
        {
            Set c3 = new Set(); Set c = new Set();
            c3 = this.Intersection(c2);
            for (int i = 0; i < this.NumberofElements(); i++)
                if (c3.Contains(this.Element(i + 1)) == false)
                    c.Add(this.Element(i + 1));

            return (c);
        }
        public static Set operator +(Set c1, Set c2)
        {
            return c1.Union(c2);
        }
        public static Set operator -(Set c1, Set c2)
        {
            return c1.Substract(c2);
        }
        public static Set operator ^(Set c1, Set c2)
        {
            return c1.Intersection(c2);
        }
    }
}
