namespace ClassificationApp.Models.Scenes
{
    public interface IShape
    {
        object Tag { get; set; }

        IShape Display(IGraph graph);

        double GetMax(IGraph graph, int axisIndex);

        double GetMin(IGraph graph, int axisIndex);
    }
}