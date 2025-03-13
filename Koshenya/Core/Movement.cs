using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Koshenya.Core
{
    internal class Movement
    {
        private readonly ICharacterBox _box;
        private readonly Timer _timer;

        private readonly int _triggerBounds;
        private Point _target;
        private int _speed;

        public Movement(ICharacterBox box)
        {
            _box = box;
            _timer = new Timer();
            _timer.Tick += Timer_Tick;
            _triggerBounds = _box.Size.Width / 4;
        }

        public event EventHandler<Directions> DirectionChanged;
        public event EventHandler<Speeds> SpeedChanged;

        public enum Directions
        {
            None, East, West, North, South, NorthEast, NorthWest, SouthEast, SouthWest
        }
        public enum Speeds
        {
            Idle, Walk, Run
        }
        public Directions Direction { get; protected set; }
        public Speeds Speed { get; protected set; }
        public int Reaction
        {
            get => _timer.Interval;
            set => _timer.Interval = value;
        }
        public int WalkSpeed { get; set; }
        public int RunSpeed { get; set; }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);

        public static string GetShortNameOfDirection(Directions direction)
        {
            switch (direction)
            {
                case Directions.East: return "e";
                case Directions.West: return "w";
                case Directions.North: return "n";
                case Directions.South: return "s";
                case Directions.NorthEast: return "ne";
                case Directions.NorthWest: return "nw";
                case Directions.SouthEast: return "se";
                case Directions.SouthWest: return "sw";
                default: return "none";
            }
        }
        public static Directions GetDirectionByShortName(string name)
        {
            switch (name)
            {
                case "e": return Directions.East;
                case "w": return Directions.West;
                case "n": return Directions.North;
                case "s": return Directions.South;
                case "ne": return Directions.NorthEast;
                case "nw": return Directions.NorthWest;
                case "se": return Directions.SouthEast;
                case "sw": return Directions.SouthWest;
                default: return Directions.None;
            }
        }

        public void Start() => _timer.Start();
        public void Stop() => _timer.Stop();

        protected virtual void OnSpeedChange(Speeds speed)
        {
            if (Speed != speed)
            {
                Speed = speed;
                SpeedChanged?.Invoke(this, speed);
            }
        }

        protected virtual void OnDirectionChange(Directions direction)
        {
            if (Direction != direction)
            {
                Direction = direction;
                DirectionChanged?.Invoke(this, direction);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GetCursorPos(out _target);
            SetSpeed();

            MovementPoint destination = GetMovementPoint();

            OnDirectionChange(destination.Direction);

            _box.Location = new Point()
            {
                X = _box.Location.X + destination.Vector.X,
                Y = _box.Location.Y + destination.Vector.Y
            };
        }

        private MovementPoint GetMovementPoint()
        {
            double xMin = _box.Location.X - _triggerBounds;
            double yMin = _box.Location.Y - _triggerBounds;
            double xMax = _box.Location.X + _triggerBounds;
            double yMax = _box.Location.Y + _triggerBounds;

            if (yMin <= _target.Y && _target.Y <= yMax)
            {
                if (xMin <= _target.X && _target.X <= xMax)
                {
                    return new MovementPoint(0, 0, Directions.None);
                }

                return _target.X < xMin ? new MovementPoint(-_speed, 0, Directions.West)
                    : new MovementPoint(_speed, 0, Directions.East);
            }
            if (_target.Y < yMin)
            {
                if (xMin <= _target.X && _target.X <= xMax)
                {
                    return new MovementPoint(0, -_speed, Directions.North);
                }
                _speed -= _speed / 3;

                return _target.X < xMin ? new MovementPoint(-_speed, -_speed, Directions.NorthWest)
                    : new MovementPoint(_speed, -_speed, Directions.NorthEast);
            }
            if (_target.Y > yMax)
            {
                if (xMin <= _target.X && _target.X <= xMax)
                {
                    return new MovementPoint(0, _speed, Directions.South);
                }
                _speed -= _speed / 3;

                return _target.X < xMin ? new MovementPoint(-_speed, _speed, Directions.SouthWest)
                    : new MovementPoint(_speed, _speed, Directions.SouthEast);
            }

            return new MovementPoint(0, 0, Directions.None);
        }

        private void SetSpeed()
        {
            double distance = Math.Sqrt(Math.Pow(_target.X - _box.Location.X, 2) + Math.Pow(_target.Y - _box.Location.Y, 2));

            if (distance < _triggerBounds)
            {
                _speed = 0;
                OnSpeedChange(Speeds.Idle);
            }
            else if (_triggerBounds < distance && distance < _triggerBounds * 10)
            {
                _speed = WalkSpeed;
                OnSpeedChange(Speeds.Walk);
            }
            else
            {
                _speed = RunSpeed;
                OnSpeedChange(Speeds.Run);
            }
        }

        private struct MovementPoint
        {
            public MovementPoint(int x, int y, Directions direction)
            {
                Vector = new Point(x, y);
                Direction = direction;
            }

            public Point Vector { get; set; }
            public Directions Direction { get; set; }
        }
    }
}
