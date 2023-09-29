using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;

namespace zeffmod.Content.NPCs
{
    public class you : ModNPC
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/NPCs/" + this.Name;
            }
        }
        public override void SetDefaults()
        {
            NPC.noGravity = true;
            NPC.noTileCollide = true;
            NPC.dontTakeDamage = true;
            NPC.width = 128;
            NPC.height = 128;
            NPC.damage = 2;
            NPC.chaseable = false;
            NPC.defense = 1;
            NPC.lifeMax = 1;
            NPC.HitSound = new SoundStyle?(SoundID.NPCHit1);
            NPC.DeathSound = new SoundStyle?(SoundID.NPCDeath1);
            NPC.value = 0f;
            NPC.knockBackResist = 1f;
            Banner = base.NPC.type;
            BannerItem = ItemID.DirtBlock;
            AnimationType = 1;
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
            NPC.TargetClosest(true);
        }
    }
}