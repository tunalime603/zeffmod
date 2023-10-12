using Terraria.Audio;
using Terraria.ModLoader;

namespace zeffmod.Assets.sounds
{
    public class zeffsounds : ModSystem
    {
        public static readonly SoundStyle treejumpscare = new($"zeffmod/Assets/sounds/treejumpscare")
        {
            Volume = 1000f,
            PitchVariance = 0f,
        };
        public static readonly SoundStyle ilovetree = new($"zeffmod/Assets/sounds/ilovetree")
        {
            Volume = 10f,
            PitchVariance = 0f,
        };
        public static readonly SoundStyle pipe = new($"zeffmod/Assets/sounds/pipe")
        {
            Volume = 10000f,
            PitchVariance = 0f,
        };
    }
}