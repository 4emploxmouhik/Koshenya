using Koshenya.Properties;
using System.Media;

namespace Koshenya.Core
{
    internal abstract class Character
    {
        protected readonly ICharacterBox box;
        protected ICharacterAssets assets;

        protected readonly Movement movement;
        protected readonly AnimationPlayer animationPlayer;
        protected readonly SoundPlayer soundPlayer;

        public Character(ICharacterAssets assets, ICharacterBox box)
        {
            this.assets = assets;
            this.box = box;

            movement = new Movement(box);
            animationPlayer = new AnimationPlayer(box);
            soundPlayer = new SoundPlayer();
        }

        public ICharacterAssets Assets 
        { 
            get => assets; 
            set 
            { 
                assets = value;

                if (!assets.IsInitialized)
                    assets.Initialize();
            } 
        }
        public ICharacterBox Box => box;

        public void Mute(bool isMutted)
        {
            Settings.Default.IsMutted = isMutted;
            Settings.Default.Save();
        }

        public void Start()
        {
            movement.Start();
            animationPlayer.Start();
        }

        public void Stop()
        {
            movement.Stop();
            animationPlayer.Stop();
            soundPlayer.Stop();
        }
    }
}
