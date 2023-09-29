
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace zeffmod.Content.menu
{
    public class bestmenu : ModMenu
    {
        private const string menuAssetPath = "zeffmod/menu";

        public override Asset<Texture2D> Logo => ModContent.Request<Texture2D>("zeffmod/icon2");
        public static Texture2D BackgroundTexture
        {
            get
            {
                return ModContent.Request<Texture2D>("zeffmod/assets/menu/BG").Value;
            }
        }
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/owwie");

        public override string DisplayName => "zeff mod: TURN DOWN YOUR VOLUME RIGHT NOW YOU'VE BEEN WARNED";
        public override void OnSelected()
        {
            SoundEngine.PlaySound(SoundID.DD2_KoboldExplosion);
        }


    }
}