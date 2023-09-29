using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using zeffmod.Content.Buffs;

namespace zeffmod.Content.NPCs.zeffgodgamer
{
    public class zeffgodgamer : ModNPC
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/NPCs/zeffgodgamer/" + this.Name;
            }
        }
        public override void SetDefaults()
        {
            NPC.noGravity = true;
            NPC.noTileCollide = true;
            NPC.dontTakeDamage = true;
            NPC.width = 90;
            NPC.height = 93;
            NPC.damage = 2;
            NPC.chaseable = false;
            NPC.defense = 1;
            NPC.lifeMax = 1;
            NPC.HitSound = new SoundStyle?(SoundID.NPCHit1);
            NPC.DeathSound = new SoundStyle?(SoundID.NPCDeath1);
            NPC.value = 0f;
            NPC.knockBackResist = 1f;
            Banner = NPC.type;
            BannerItem = ItemID.DirtBlock;
            AnimationType = 0;
            NPC.aiStyle = 44;
            AIType = 299;
            NPC.friendly = false;
            NPC.rarity = 1;
            NPC.lavaImmune = true;
        }

        public override bool CheckActive()
        {
            return false;
        }
        public override void AI()
        {
            Player player = Main.player[NPC.target];
        }
    }
}