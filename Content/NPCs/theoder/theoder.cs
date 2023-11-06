using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using zeffmod.Content.Buffs;

namespace zeffmod.Content.NPCs.zeffgodgamer
{
    [AutoloadBossHead]
    public class theoder : ModNPC
    {
        public override string Texture => "zeffmod/Assets/NPCs/theoder/" + this.Name;
        public override string HeadTexture => "zeffmod/Assets/NPCs/theoder/" + this.Name + "_Head_Boss";
        public override void SetDefaults()
        {
            NPC.aiStyle = 1;
            NPC.lifeMax = 1;
            NPC.damage = 2147483646;
            NPC.defense = 0;
            NPC.knockBackResist = 0f;
            NPC.width = 100;
            NPC.height = 100;
            NPC.value = Item.buyPrice(0, 20, 0, 0);
            NPC.npcSlots = 1f;
            NPC.boss = true;
            NPC.lavaImmune = false;
            NPC.noGravity = false;
            NPC.noTileCollide = false;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            Music = MusicID.Boss2;
        }
        public override bool CheckActive()
        {
            return false;
        }
        public override void AI()
        {
            Player player = Main.player[NPC.target];
        }
        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1f;
            return null;
        }
    }
}