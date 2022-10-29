using System.Drawing;

namespace ClassificationApp.Models.Schedules
{
    public interface ICamera
    {
        IScene Scene { get; }

        Image Shot { get; }
    }
}