using System;
using Terraria;
using Terraria.ModLoader;

namespace zeffmod.Content.Buffs
{
    public class WRizz : ModBuff
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/Buffs/" + this.Name;
            }
        }
        public override void Update(Player Player, ref int buffIndex)
        {
            Player.statDefense += 999999;
            Player.statLifeMax += 999999;
            Player.statLifeMax2 += 999999;
            Player.statLife += 999999;
            Player.statManaMax += 999999;
            Player.statManaMax2 += 999999;
            Player.statMana += 999999;
        }
    }
}
