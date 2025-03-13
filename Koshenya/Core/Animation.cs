using System.Drawing;
using System.IO;

namespace Koshenya.Core
{
    internal class Animation
    {
        public Animation(string name, Image[] frames, int frameRate)
        {
            Name = name;
            Frames = frames;
            FrameRate = frameRate;
        }

        public string Name { get; }
        public Image[] Frames { get; }
        public int FrameRate { get; }
        public int Length => 1000 / FrameRate * Frames.Length;
        public int FrameLength => 1000 / FrameRate;

        public static Image[] Load(string path, bool isReflected = false, bool isReverse = false)
        {
            string[] framesFiles = Directory.GetFiles(path);
            Image[] frames = new Image[framesFiles.Length];

            for (int i = 0, j = isReverse ? frames.Length - 1 : 0; i < frames.Length; i++, j += isReverse ? -1 : 1)
            {
                frames[i] = new Bitmap(framesFiles[j]);

                if (isReflected)
                {
                    frames[i].RotateFlip(RotateFlipType.RotateNoneFlipX);
                }
            }

            return frames;
        }
    }
}
