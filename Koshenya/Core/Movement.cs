using System;
using System.Drawing;
using System.Windows.Forms;

namespace Koshenya.Core
{
    internal class Movement
    {
        private readonly IMovementBox _box;
        private readonly int _triggerBounds;
        private readonly Timer _timer;
        private readonly int _runFactor;
        private readonly Random _random;
        private readonly Rectangle _virtualSreen;

        private Point _target;
        private int _speed;
        private bool _isPatrolliing;

        public Movement(IMovementBox box)
        {
            _box = box;
            _timer = new Timer();
            _timer.Tick += Timer_Tick;
            _triggerBounds = _box.Size.Width / 4;
            _runFactor = 10;
            _random = new Random();
            _virtualSreen = new Rectangle()
            {
                X = User32Dll.GetSystemMetrics(User32Dll.SM_XVIRTUALSCREEN),
                Y = User32Dll.GetSystemMetrics(User32Dll.SM_YVIRTUALSCREEN),
                Width = User32Dll.GetSystemMetrics(User32Dll.SM_CXVIRTUALSCREEN),
                Height = User32Dll.GetSystemMetrics(User32Dll.SM_CYVIRTUALSCREEN)
            };
        }

        public event EventHandler<Directions> DirectionChanged;
        public event EventHandler<Speeds> SpeedChanged;
        public event EventHandler TargetCatched;

        public enum Directions
        {
            None = -1,
            North = 0,
            NorthWest = 1,
            West = 2,
            SouthWest = 3,
            South = 4,
            SouthEast = 5,
            East = 6,
            NorthEast = 7,
        }
        public enum Speeds
        {
            None = -1,
            Walk = 0,
            Run = 1
        }

        public Directions Direction { get; protected set; }
        public Speeds Speed { get; protected set; }
        public bool IsTagetCatched { get; protected set; }
        public int Reaction
        {
            get => _timer.Interval;
            set => _timer.Interval = value;
        }
        public int WalkSpeed { get; set; }
        public int RunSpeed { get; set; }
        public bool IsPatrolling 
        { 
            get => _isPatrolliing; 
            set 
            { 
                _isPatrolliing = value; 
                _target = _box.Location; 
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

                if (Direction == Directions.None)
                    OnTargetCatched();
                else 
                    IsTagetCatched = false;

                DirectionChanged?.Invoke(this, direction);
            }
        }

        protected virtual void OnTargetCatched()
        {
            IsTagetCatched = true;
            TargetCatched?.Invoke(this, EventArgs.Empty);
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
                    return new MovementPoint(0, 0, Directions.None);

                return _target.X < xMin ? new MovementPoint(-_speed, 0, Directions.West)
                    : new MovementPoint(_speed, 0, Directions.East);
            }
            if (_target.Y < yMin)
            {
                if (xMin <= _target.X && _target.X <= xMax)
                    return new MovementPoint(0, -_speed, Directions.North);

                _speed -= _speed / 3;

                return _target.X < xMin ? new MovementPoint(-_speed, -_speed, Directions.NorthWest)
                    : new MovementPoint(_speed, -_speed, Directions.NorthEast);
            }
            if (_target.Y > yMax)
            {
                if (xMin <= _target.X && _target.X <= xMax)
                    return new MovementPoint(0, _speed, Directions.South);

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
                OnSpeedChange(Speeds.None);
            }
            else if (_triggerBounds < distance && distance < _triggerBounds * _runFactor)
            {
                if (WalkSpeed == 0)
                {
                    _speed = RunSpeed;
                    OnSpeedChange(Speeds.Run);
                }
                else
                {
                    _speed = WalkSpeed;
                    OnSpeedChange(Speeds.Walk);
                }
            }
            else if (IsPatrolling && WalkSpeed != 0)
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

        private void SetTarget()
        {
            if (!IsPatrolling)
            {
                User32Dll.GetCursorPos(out _target);
            }
            else
            {
                Point possibleTarget = new Point()
                {
                    X = _random.Next(_virtualSreen.X, _virtualSreen.Width),
                    Y = _random.Next(_virtualSreen.Y, _virtualSreen.Height)
                };

                if (IsTagetCatched)
                    _target = possibleTarget;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SetTarget();
            SetSpeed();

            MovementPoint destination = GetMovementPoint();

            OnDirectionChange(destination.Direction);

            _box.Location = new Point()
            {
                X = _box.Location.X + destination.Vector.X,
                Y = _box.Location.Y + destination.Vector.Y
            };
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
