using System.Collections.Generic;

namespace ClassificationApp.Models.Scenes
{
    public interface IGraph
    {
        List<Axis> Axises { get; }

        List<IShape> Shapes { get; set; }

        List<IShape> Displays { get; }

        ICamera DefaultCamera { get; }

        double DefaultValue { get; set; }

        double GetMin(int axisesIndex);

        double GetMax(int axisesIndex);

        void DefaultDisplay();
    }
}