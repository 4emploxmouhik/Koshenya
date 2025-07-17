namespace Koshenya.Core
{
    internal abstract class CharacterState
    {
        protected Character _character;

        protected CharacterState(Character character)
        {
            _character = character;
        }

        public abstract void Handle();
    }
}
