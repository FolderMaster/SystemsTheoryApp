using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassificationApp.Models.Scenes;
using ClassificationApp.Services.Classification;

namespace ClassificationApp.Services.Factories
{
    public static class SceneFactory
    {
        public static Scene3D CreateScene3DByClassifier(IClassifier classifier)
        {
            Scene3D result = new Scene3D();
            result.Graph = new Graph3D(new List<Axis>() { new Axis(new LinearScale()),
                new Axis(new LinearScale()), new Axis(new LinearScale()) });
            result.Camera = new Camera3D(result);
            if(classifier is NeighborClassifier neighborClassifier)
            {
                result.Graph.Shapes.AddRange(neighborClassifier.EduccationPoints);
                result.Graph.Shapes.AddRange(neighborClassifier.ResultPoints);
            }
            else if (classifier is LinearClassifier linearClassifier)
            {
                result.Graph.Shapes.AddRange(linearClassifier.EduccationPoints);
                result.Graph.Shapes.AddRange(linearClassifier.ResultPoints);
                result.Graph.Shapes.Add(linearClassifier.DevelopedMiddlePoint);
                result.Graph.Shapes.Add(linearClassifier.DevelopingMiddlePoint);
                result.Graph.Shapes.Add(new LineSegment(linearClassifier.DevelopedMiddlePoint,
                    linearClassifier.DevelopingMiddlePoint));
                result.Graph.Shapes.Add(linearClassifier.PlanePoint);
                result.Graph.Shapes.Add(ShapeFactory.CreatePlaneByPoindAndVector(linearClassifier.
                    PlanePoint, linearClassifier.PlaneVector));
            }
            else
            {
                throw new ArgumentException();
            }
            result.Graph.DefaultDisplay();
            return result;
        }
    }
}