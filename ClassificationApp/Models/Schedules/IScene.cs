using System.Collections.Generic;

namespace ClassificationApp.Models.Schedules
{
    public interface IScene
    {
        ISchedule Schedule { get; set; }

        List<IShape> Shapes { get; set; }

        ICamera Camera { get; set; }
    }
}