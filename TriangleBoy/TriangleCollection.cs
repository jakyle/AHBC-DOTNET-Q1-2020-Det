using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleBoy
{
    class TriangleCollection
    {
        private List<Triangle> _triangles;

        public TriangleCollection(List<Triangle> triangles)
        {
            _triangles = triangles;
        }

        public double GetAverageArea()
        {
            double averageArea = 0;
            foreach (var triangle in _triangles)
            {
                averageArea += triangle.GetArea();
            }

            return averageArea;
        }

        public double GetAveragePerimeter()
        {
            double averagePerimeter = 0;
            foreach (var triangle in _triangles)
            {
                averagePerimeter += triangle.GetPerimiter();
            }

            return averagePerimeter;
        }
    }
}
