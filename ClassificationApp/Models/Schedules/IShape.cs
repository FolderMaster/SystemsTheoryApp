namespace ClassificationApp.Models.Schedules
{
    public interface IShape
    {
        object Tag { get; set; }

        IShape Display(ISchedule schedule);

        double GetMax(ISchedule schedule, int axisIndex);

        double GetMin(ISchedule schedule, int axisIndex);
    }
}