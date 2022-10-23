using System.Drawing;

namespace ClassificationApp.Models.Schedules
{
    public interface ICamera
    {
        Image Shot { get; }
    }
}