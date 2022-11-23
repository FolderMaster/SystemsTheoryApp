using System.Drawing;

namespace ClassificationApp.Models.Scenes
{
    public interface ICamera
    {
        IScene Scene { get; }

        Image Shot { get; }
    }
}