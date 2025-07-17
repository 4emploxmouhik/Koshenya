using Koshenya.Core.States;
using Koshenya.Core.States.Parameters;
using System.Linq;

namespace Koshenya.Core.Extensions
{
    internal static class CharacterExtensions
    {
        internal static void DeclareStates(this Character character, CharacterConfiguration config)
        {
            Animation[] animations = new Animation[config.Animations.Length];

            for (int i = 0; i < animations.Length; i++)
            {
                var animParam = config.Animations[i];

                animations[i] = new Animation(
                    name: animParam.Name,
                    frames: Animation.Load(animParam.Source, animParam.IsReflected, animParam.IsReverse),
                    frameRate: animParam.FrameRate
                );
            }

            character.DeclareStates.Clear();

            for (int i = 0; i < config.States.Length; i++)
            {
                switch (config.States[i].StateType)
                {
                    case CharacterStateType.Idle:
                        DeclareState(character, animations, (IdleStateParameters)config.States[i]);
                        break;
                    case CharacterStateType.Move:
                        DeclareState(character, animations, (MovementStateParameters)config.States[i]);
                        break;
                    case CharacterStateType.Punch:
                        DeclareState(character, animations, config.Sounds, (PunchStateParameters)config.States[i]);
                        break;
                    case CharacterStateType.Sleeping:
                        DeclareState(character, animations, config.Sounds, (SleepStateParameters)config.States[i]);
                        break;
                    case CharacterStateType.Drag:
                        DeclareState(character, animations, (DragStateParameters)config.States[i]);
                        break;
                }
            }
        }

        private static void DeclareState(Character character, Animation[] animations, DragStateParameters stateParams)
        {
            character.DeclareStates.Add(CharacterStateType.Drag, new DragState(
                character,
                animations.First(x => x.Name == stateParams.DragAnimation),
                animations.First(x => x.Name == stateParams.DragAnimationWhenSleeping)
            ));
        }

        private static void DeclareState(Character character, Animation[] animations, CharacterConfiguration.Sound[] sounds, SleepStateParameters stateParams)
        {
            var sleepAnim = animations.First(x => x.Name == stateParams.SleepAnimation);
            var anims = new Animation[stateParams.FallAsleepAnimations.Count];

            for (int i = 0; i < anims.Length; i++)
            {
                anims[i] = animations.First(x => x.Name == stateParams.FallAsleepAnimations[i]);
            }

            var fallAsleepClip = new AnimationClip("FallAsleep", sleepAnim);
            fallAsleepClip.Add(anims, 0);

            anims = new Animation[stateParams.AwakenAnimations.Count];

            for (int i = 0; i < anims.Length; i++)
            {
                anims[i] = animations.First(x => x.Name == stateParams.AwakenAnimations[i]);
            }

            var awakenClip = new AnimationClip("Awaken", sleepAnim);
            awakenClip.Add(anims, 0);

            character.DeclareStates.Add(CharacterStateType.FallAsleep, new FallAsleepState(character, fallAsleepClip));
            character.DeclareStates.Add(CharacterStateType.Awaken, new AwakenState(character, awakenClip));
            character.DeclareStates.Add(CharacterStateType.Sleeping, new SleepingState(
                character,
                animations.First(x => x.Name == stateParams.SleepAnimation),
                sounds.First(x => x.Name == stateParams.SleepSound).Source,
                stateParams.SleepingTime
            ));
        }

        private static void DeclareState(Character character, Animation[] animations, CharacterConfiguration.Sound[] sounds, PunchStateParameters stateParams)
        {
            character.DeclareStates.Add(CharacterStateType.Punch, new PunchState(
                character: character,
                animations: new Animation[]
                {
                    animations.First(x => x.Name == stateParams.DefaultReactionAnimation),
                    animations.First(x => x.Name == stateParams.AggressiveReactionAnimation),
                },
                sounds: new string[]
                {
                    sounds.First(x => x.Name == stateParams.DefaultReactionSound).Source,
                    sounds.First(x => x.Name == stateParams.AggressiveReactionSound).Source,
                },
                punchesToAggressive: stateParams.PunchesToAggressive)
            );
        }

        private static void DeclareState(Character character, Animation[] animations, MovementStateParameters stateParams)
        {
            var moveAnims = new Animation[2, stateParams.RunningAnimations.Length];

            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < stateParams.RunningAnimations.Length; k++)
                {
                    moveAnims[j, k] = animations.First(x => x.Name == (j == 0 ? stateParams.WalkingAnimations[k] : stateParams.RunningAnimations[k]));
                }
            }

            character.DeclareStates.Add(CharacterStateType.Move, new MovementState(character, moveAnims));
            character.Movement.WalkSpeed = stateParams.WalkSpeed;
            character.Movement.RunSpeed = stateParams.RunSpeed;
            character.Movement.Reaction = stateParams.Reaction;
        }

        private static void DeclareState(Character character, Animation[] animations, IdleStateParameters stateParams)
        {
            var clip = new AnimationClip(stateParams.DefaultAnimation, animations.First(x => x.Name == stateParams.DefaultAnimation));

            for (int j = 0; j < stateParams.Animations.Count; j++)
            {
                clip.Add(animations.First(x => x.Name == stateParams.Animations[j]), stateParams.AnimationsTimes[j]);
            }

            character.DeclareStates.Add(CharacterStateType.Idle, new IdleState(character, clip, stateParams.TimeBeforeSleep));
        }

    }
}
