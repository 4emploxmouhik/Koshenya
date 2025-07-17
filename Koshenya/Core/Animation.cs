using Koshenya.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Koshenya.Core
{
    internal class Animation : IEquatable<Animation>
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
            string[] framesFiles = GetFrameFileNames(path);
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

        private static string[] GetFrameFileNames(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            int[] framesNums = new int[files.Length];

            // Check files names. It's must be like {i}.png, where i - number
            for (int i = 0, k; i < files.Length; i++)
            {
                if (files[i].Extension != ".png")
                    throw new BadFrameFileNameException(directory.FullName, "Frame file must be end with - .png");

                string nameWithoutExtension = files[i].Name.Substring(0, files[i].Name.IndexOf('.'));

                if (!int.TryParse(nameWithoutExtension, out k))
                    throw new BadFrameFileNameException(directory.FullName, "Frame file name isn't a number");

                framesNums[i] = k;
            }

            // Sort frame file names in ascending order
            Array.Sort(framesNums);

            string[] framesFiles = new string[files.Length];

            for (int i = 0; i < files.Length; i++)
                framesFiles[i] = Path.Combine(files[i].DirectoryName, $"{framesNums[i]}{files[i].Extension}");

            return framesFiles;
        }

        public override bool Equals(object obj)
        {
            return obj is Animation animation &&
                   Name == animation.Name;
        }

        public bool Equals(Animation other)
        {
            return !(other is null) &&
                   Name == other.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = 1655590953;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + FrameRate.GetHashCode();
            hashCode = hashCode * -1521134295 + Length.GetHashCode();
            hashCode = hashCode * -1521134295 + FrameLength.GetHashCode();
            return hashCode;
        }
    }
}
