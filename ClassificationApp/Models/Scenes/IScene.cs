using System.Collections.Generic;

namespace ClassificationApp.Models.Scenes
{
    public interface IScene
    {
        IGraph Graph { get; set; }

        List<IShape> Shapes { get; set; }

        ICamera Camera { get; set; }
    }
}