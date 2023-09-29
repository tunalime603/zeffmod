using Terraria.Audio;
using Terraria.ModLoader;

namespace zeffmod.sounds
{
    public class zeffsounds : ModSystem
    {
        public static readonly SoundStyle treejumpscare = new($"zeffmod/sounds/treejumpscare")
        {
            Volume = 1000f,
            PitchVariance = 0f,
        };
        public static readonly SoundStyle ilovetree = new($"zeffmod/sounds/ilovetree")
        {
            Volume = 10f,
            PitchVariance = 0f,
        };
    }
}