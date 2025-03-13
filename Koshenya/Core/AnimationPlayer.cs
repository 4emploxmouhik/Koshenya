using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Koshenya.Core
{
    internal class AnimationPlayer
    {
        private readonly ICharacterBox _box;
        private readonly Timer _timer;

        private Animation _animation;
        private int _frameIndx = 0;

        private AnimationClip _clip;
        private long _clipFrameIndx = 0;
        private int _clipAnimIndx = 0;
        private bool _isClipPlayed;

        public AnimationPlayer(ICharacterBox box)
        {
            _box = box;
            _timer = new Timer();
            _timer.Tick += OnTick;
        }

        public event EventHandler<Animation> AnimationStarted;
        public event EventHandler<Animation> AnimationEnded;
        public event EventHandler<AnimationClip> ClipStarted;
        public event EventHandler<AnimationClip> ClipEnded;

        public void Play(Animation animation)
        {
            _isClipPlayed = false;
            _clip = null;
            _clipFrameIndx = 0;
            _clipAnimIndx = 0;
            _animation = animation;
            _frameIndx = 0;
        }

        public void Play(AnimationClip clip)
        {
            _isClipPlayed = true;
            _clip = clip;
            _clipFrameIndx = 0;
            _clipAnimIndx = 0;
            _animation = clip.Default;
            _frameIndx = 0;
        }

        public void Start() => _timer.Start();
        public void Stop() => _timer.Stop();

        protected void OnAnimationStarted()
        {
            AnimationStarted?.Invoke(this, _animation);
        }
        protected void OnAnimationEnded()
        {
            AnimationEnded?.Invoke(this, _animation);
        }
        protected void OnClipStarted()
        {
            ClipStarted?.Invoke(this, _clip);
        }
        protected void OnClipEnded()
        {
            ClipEnded?.Invoke(this, _clip);
        }

        private void OnTick(object sender, EventArgs e)
        {
            if (_animation == null) return;

            if (_isClipPlayed)
            {
                _animation = GetClipAnimation();
                _clipFrameIndx++;
            }

            if (_frameIndx == _animation.Frames.Length)
            {
                OnAnimationEnded();
                _frameIndx = 0;
            }

            if (_frameIndx == 0)
                OnAnimationStarted();

            _timer.Interval = _animation.FrameLength;
            _box.Frame = _animation.Frames[_frameIndx++];
        }

        private Animation GetClipAnimation()
        {
            if (_clipFrameIndx == _clip.PlaybackQueue[_clipAnimIndx].EndFrame)
            {
                OnAnimationEnded();
                _clipAnimIndx++;
                _frameIndx = 0;

                if (_clipAnimIndx == _clip.PlaybackQueue.Count)
                {
                    OnClipEnded();
                    _clipAnimIndx = 0;
                    _clipFrameIndx = 0;
                }
            }
            if (_clipFrameIndx >= _clip.PlaybackQueue[_clipAnimIndx].LaunchFrame)
            {
                if (_clipFrameIndx == _clip.PlaybackQueue[_clipAnimIndx].LaunchFrame)
                {
                    if (_clipFrameIndx == 0)
                        OnClipStarted();

                    _frameIndx = 0;
                }

                return _clip.PlaybackQueue[_clipAnimIndx].Animation;
            }

            return _clip.Default;
        }
    }
}
