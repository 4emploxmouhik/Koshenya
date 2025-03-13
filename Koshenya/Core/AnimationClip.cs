using System;
using System.Collections.Generic;

namespace Koshenya.Core
{
    internal class AnimationClip
    {
        public AnimationClip(string name, Animation defaultAnimation)
        {
            Name = name;
            Default = defaultAnimation;
            PlaybackQueue = new List<Item>();
        }

        public string Name { get; }
        public Animation Default { get; }
        public List<Item> PlaybackQueue { get; }

        public void Add(Animation animation, long launchTime)
        {
            PlaybackQueue.Add(new Item(animation, launchTime, launchTime / Default.FrameLength));
            Sort();
        }

        public void Add(Animation[] animations, long launchTime)
        {
            PlaybackQueue.Add(new Item(animations[0], launchTime, launchTime / Default.FrameLength));

            for (int i = 1; i < animations.Length; i++)
            {
                PlaybackQueue.Add(new Item(
                    animation: animations[i],
                    launchTime: PlaybackQueue[PlaybackQueue.Count - 1].EndTime,
                    launchFrame: PlaybackQueue[PlaybackQueue.Count - 1].EndFrame));
            }

            Sort();
        }

        private void Sort()
        {
            PlaybackQueue.Sort((x, y) =>
            {
                if (x.LaunchTime == y.LaunchTime) return 0;
                else if (x.LaunchTime < y.LaunchTime) return -1;
                else return 1;
            });

            for (int i = 0; i < PlaybackQueue.Count - 1; i++)
            {
                // Solving the problem of animation overlapping
                if (PlaybackQueue[i + 1].LaunchTime < PlaybackQueue[i].EndTime)
                {
                    PlaybackQueue[i + 1].LaunchTime = PlaybackQueue[i].EndTime;
                }

                PlaybackQueue[i + 1].LaunchFrame = PlaybackQueue[i].EndFrame;
                PlaybackQueue[i + 1].LaunchFrame += (long)Math.Ceiling((double)(
                    // Calculate frames of default animation between animations of playback queue
                    (PlaybackQueue[i + 1].LaunchTime - PlaybackQueue[i].EndTime) / Default.FrameLength
                ));
            }
        }

        public class Item
        {
            public Item(Animation animation, long launchTime, long launchFrame)
            {
                Animation = animation;
                LaunchTime = launchTime;
                LaunchFrame = launchFrame;
            }

            public Animation Animation { get; }
            public long LaunchFrame { get; set; }
            public long LaunchTime { get; set; }
            public long EndFrame => LaunchFrame + Animation.Frames.Length;
            public long EndTime => LaunchTime + Animation.Length;
        }
    }
}
