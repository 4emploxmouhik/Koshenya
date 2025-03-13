using System.Collections.Generic;

namespace Koshenya.Core
{
    internal interface ICharacterAssets
    {
        List<Animation> Animations { get; }
        List<AnimationClip> Clips { get; }
        Dictionary<string, string> Sounds { get; }

        bool IsInitialized { get; }

        void Initialize();
    }
}
