using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media.Media3D;

namespace Axes
{


    public static class MeshExtensions
    {
        public static void ApplyTransformation(this MeshGeometry3D mesh, Transform3D transformation)
        {
            Point3D[] points = mesh.Positions.ToArray();
            transformation.Transform(points);
            mesh.Positions = new Point3DCollection(points);
        }
    }
}
