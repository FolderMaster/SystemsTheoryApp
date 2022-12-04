using System.Drawing;

namespace ClassificationApp.Models.Scenes
{
    public class CameraDisplaySettings
    {
        public int PointSize { get; set; } = 10;

        public Font Font { get; set; } = new Font(FontFamily.GenericMonospace, 12);

        public Pen PointPen { get; set; } = new Pen(Color.Black);

        public Pen LegendPen { get; set; } = new Pen(Color.Black);

        public Brush FontBrush { get; set; } = new SolidBrush(Color.Black);

        public Brush NoneBrush { get; set; } = new SolidBrush(Color.Yellow);

        public Brush DevelopedBrush { get; set; } = new SolidBrush(Color.Red);

        public Brush DevelopingBrush { get; set; } = new SolidBrush(Color.Blue);

        public Brush DefaultBrush { get; set; } = new SolidBrush(Color.Gray);

        public CameraDisplaySettings()
        {
        }

        public CameraDisplaySettings(int pointSize, Font font, Pen pointPen, Pen legendPen, Brush 
            fontBrush, Brush noneBrush, Brush developedBrush, Brush developingBrush, Brush 
            defaultBrush)
        {
            PointSize = pointSize;
            Font = font;
            PointPen = pointPen;
            LegendPen = legendPen;
            FontBrush = fontBrush;
            NoneBrush = noneBrush;
            DevelopedBrush = developedBrush;
            DevelopingBrush = developingBrush;
            DefaultBrush = defaultBrush;
        }
    }
}
