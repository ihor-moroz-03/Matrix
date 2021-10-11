using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix : IEnumerable<double>
    {
        double[,] _coefs;

        public Matrix(double[,] coefs)
        {
            _coefs = coefs;
        }

        public Matrix() : this(new[,] { { 0.0 } })
        {
        }

        public double this[int i, int j]
        {
            get => _coefs[i, j];
            set => _coefs[i, j] = value;
        }

        public IEnumerator<double> GetEnumerator()
        {
            for (int i = _coefs.GetLength(0) - 1; i > -1; --i)
                for (int j = _coefs.GetLength(1) - 1; j > -1; --j)
                    yield return _coefs[i, j];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
