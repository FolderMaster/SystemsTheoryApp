using System.Drawing;

namespace ClassificationApp.Models.Scenes
{
    public class CameraDisplaySettings
    {
        /// <summary>
        /// Возращает и задаёт размер точек.
        /// </summary>
        public int PointSize { get; set; } = 10;

        /// <summary>
        /// Возращает и задаёт шрифт.
        /// </summary>
        public Font Font { get; set; } = new Font(FontFamily.GenericMonospace, 12);

        /// <summary>
        /// Возращает и задаёт ручка для точек.
        /// </summary>
        public Pen PointPen { get; set; } = new Pen(Color.Black);

        /// <summary>
        /// Возращает и задаёт ручка для легенды.
        /// </summary>
        public Pen LegendPen { get; set; } = new Pen(Color.Black);

        /// <summary>
        /// Возращает и задаёт заливка для шрифта.
        /// </summary>
        public Brush FontBrush { get; set; } = new SolidBrush(Color.Black);

        /// <summary>
        /// Возращает и задаёт заливка для неопределённых стран.
        /// </summary>
        public Brush NoneBrush { get; set; } = new SolidBrush(Color.Yellow);

        /// <summary>
        /// Возращает и задаёт заливка для развитых стран.
        /// </summary>
        public Brush DevelopedBrush { get; set; } = new SolidBrush(Color.Red);

        /// <summary>
        /// Возращает и задаёт заливка для развивающихся стран.
        /// </summary>
        public Brush DevelopingBrush { get; set; } = new SolidBrush(Color.Blue);

        /// <summary>
        /// Возращает и задаёт заливка по умолчанию.
        /// </summary>
        public Brush DefaultBrush { get; set; } = new SolidBrush(Color.Gray);

        /// <summary>
        /// Создаёт экземлпяр класса <see cref="CameraDisplaySettings"/> по умолчанию.
        /// </summary>
        public CameraDisplaySettings()
        {
        }

        /// <summary>
        /// Создаёт экземлпяр класса <see cref="CameraDisplaySettings"/>.
        /// </summary>
        /// <param name="pointSize">Размер точек.</param>
        /// <param name="font">Шрифт.</param>
        /// <param name="pointPen">Ручка для точек.</param>
        /// <param name="legendPen">Ручка для легенды.</param>
        /// <param name="fontBrush">Заливка для шрифта.</param>
        /// <param name="noneBrush">Заливка для неопределённых стран.</param>
        /// <param name="developedBrush">Заливка для развитых стран.</param>
        /// <param name="developingBrush">Заливка для развивающихся стран.</param>
        /// <param name="defaultBrush">Заливка по умолчанию.</param>
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