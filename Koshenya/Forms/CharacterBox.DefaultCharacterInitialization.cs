using Koshenya.Core;
using Koshenya.Core.States;
using Koshenya.Properties;
using System.Drawing;

namespace Koshenya.Forms
{
    partial class CharacterBox
    {
        private void InitializeDefaultCharacter()
        {
            _character.Name = "Koshenya";
            _character.Movement.Reaction = 24;
            _character.Movement.RunSpeed = 6;

            AnimationClip clip = new AnimationClip("Idle", new Animation("Idle", new[] { Resources.aIdle }, 24));
            clip.Add(new Animation("Blink", new[] { 
                Resources.aBlink_1, 
                Resources.aBlink_2, 
                Resources.aBlink_3, 
                Resources.aBlink_4, 
                Resources.aBlink_5,
            }, 12), 3000);

            _character.DeclareStates.Add(CharacterStateType.Idle, new IdleState(_character, clip, 0));
            _character.DeclareStates.Add(CharacterStateType.Move, new MovementState(_character, new Animation[,] 
            {
                { null, null, null, null, null, null, null, null },
                {
                    new Animation(
                        "Run-North",
                        new[]
                        {
                            Resources.aRun_North_1,
                            Resources.aRun_North_2,
                            Resources.aRun_North_3,
                            Resources.aRun_North_4,
                            Resources.aRun_North_5,
                            Resources.aRun_North_6,
                            Resources.aRun_North_7,
                            Resources.aRun_North_8,
                        },
                        24),
                    new Animation(
                        "Run-NorthWest",
                        new[]
                        {
                            Resources.aRun_NorthWest_1,
                            Resources.aRun_NorthWest_2,
                            Resources.aRun_NorthWest_3,
                            Resources.aRun_NorthWest_4,
                            Resources.aRun_NorthWest_5,
                            Resources.aRun_NorthWest_6,
                            Resources.aRun_NorthWest_7,
                            Resources.aRun_NorthWest_8,
                        },
                        24),
                    new Animation(
                        "Run-West",
                        new[]
                        {
                            Resources.aRun_West_1,
                            Resources.aRun_West_2,
                            Resources.aRun_West_3,
                            Resources.aRun_West_4,
                            Resources.aRun_West_5,
                            Resources.aRun_West_6,
                            Resources.aRun_West_7,
                            Resources.aRun_West_8,
                        },
                        24),
                    new Animation(
                        "Run-SouthWest",
                        new[]
                        {
                            Resources.aRun_SouthWest_1,
                            Resources.aRun_SouthWest_2,
                            Resources.aRun_SouthWest_3,
                            Resources.aRun_SouthWest_4,
                            Resources.aRun_SouthWest_5,
                            Resources.aRun_SouthWest_6,
                            Resources.aRun_SouthWest_7,
                            Resources.aRun_SouthWest_8,
                        },
                        24),
                    new Animation(
                        "Run-South",
                        new[]
                        {
                            Resources.aRun_South_1,
                            Resources.aRun_South_2,
                            Resources.aRun_South_3,
                            Resources.aRun_South_4,
                            Resources.aRun_South_5,
                            Resources.aRun_South_6,
                            Resources.aRun_South_7,
                            Resources.aRun_South_8,
                        },
                        24),
                    new Animation(
                        "Run-SouthEast",
                        new[]
                        {
                            FlipImage(Resources.aRun_SouthWest_1),
                            FlipImage(Resources.aRun_SouthWest_2),
                            FlipImage(Resources.aRun_SouthWest_3),
                            FlipImage(Resources.aRun_SouthWest_4),
                            FlipImage(Resources.aRun_SouthWest_5),
                            FlipImage(Resources.aRun_SouthWest_6),
                            FlipImage(Resources.aRun_SouthWest_7),
                            FlipImage(Resources.aRun_SouthWest_8),
                        },
                        24),
                    new Animation(
                        "Run-East",
                        new[]
                        {
                            FlipImage(Resources.aRun_West_1),
                            FlipImage(Resources.aRun_West_2),
                            FlipImage(Resources.aRun_West_3),
                            FlipImage(Resources.aRun_West_4),
                            FlipImage(Resources.aRun_West_5),
                            FlipImage(Resources.aRun_West_6),
                            FlipImage(Resources.aRun_West_7),
                            FlipImage(Resources.aRun_West_8),
                        },
                        24),
                    new Animation(
                        "Run-NorthEast",
                        new[]
                        {
                            FlipImage(Resources.aRun_NorthWest_1),
                            FlipImage(Resources.aRun_NorthWest_2),
                            FlipImage(Resources.aRun_NorthWest_3),
                            FlipImage(Resources.aRun_NorthWest_4),
                            FlipImage(Resources.aRun_NorthWest_5),
                            FlipImage(Resources.aRun_NorthWest_6),
                            FlipImage(Resources.aRun_NorthWest_7),
                            FlipImage(Resources.aRun_NorthWest_8),
                        },
                        24),
                }
            }));
            _character.DeclareStates.Add(CharacterStateType.Punch, new PunchState(_character, 
                new[] { 
                    new Animation("Meow", new[] 
                    { 
                        Resources.aMeow_1,
                        Resources.aMeow_2,
                        Resources.aMeow_3,
                        Resources.aMeow_4,
                        Resources.aMeow_5,
                    }, 6)
                }, 
                new[] { Resources.sMeow }, 0));
        }

        private Image FlipImage(Image image)
        {
            Bitmap rotated = new Bitmap(image);
            rotated.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return rotated;
        }
    }
}
