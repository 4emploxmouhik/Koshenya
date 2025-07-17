using System.Collections.Generic;
using System.Xml.Serialization;

namespace Koshenya.Core.States.Parameters
{
    public abstract class StateParameters 
    {
        public abstract CharacterStateType StateType { get; }
    }
    
    [XmlType(TypeName = "IdleState")]
    public sealed class IdleStateParameters : StateParameters
    {
        public IdleStateParameters()
        {
            Animations = new List<string>();
            AnimationsTimes = new List<long>();
        }

        public List<string> Animations;
        public List<long> AnimationsTimes;
        public string DefaultAnimation;
        public int TimeBeforeSleep;

        public override CharacterStateType StateType => CharacterStateType.Idle;
    }

    [XmlType(TypeName = "MovementState")]
    public sealed class MovementStateParameters : StateParameters
    {
        public string[] RunningAnimations;
        public string[] WalkingAnimations;
        public int RunSpeed;
        public int WalkSpeed;
        public int Reaction;
        public bool IsWalking;

        public override CharacterStateType StateType => CharacterStateType.Move;
    }

    [XmlType(TypeName = "PunchState")]
    public sealed class PunchStateParameters : StateParameters
    {
        public string DefaultReactionAnimation;
        public string DefaultReactionSound;
        public string AggressiveReactionAnimation;
        public string AggressiveReactionSound;
        public int PunchesToAggressive;

        public override CharacterStateType StateType => CharacterStateType.Punch;
    }

    [XmlType(TypeName = "SleepState")]
    public sealed class SleepStateParameters : StateParameters
    {
        public SleepStateParameters()
        {
            FallAsleepAnimations = new List<string>();
            AwakenAnimations = new List<string>();
        }

        public List<string> FallAsleepAnimations;
        public string SleepAnimation;
        public string SleepSound;
        public List<string> AwakenAnimations;
        public int SleepingTime;

        public override CharacterStateType StateType => CharacterStateType.Sleeping;
    }

    [XmlType(TypeName = "DragState")]
    public sealed class DragStateParameters : StateParameters
    {
        public string DragAnimation;
        public string DragAnimationWhenSleeping;

        public override CharacterStateType StateType => CharacterStateType.Drag;
    }
}
