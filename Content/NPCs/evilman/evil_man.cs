using Terraria;
using Terraria.Audio;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using zeffmod.Content.Buffs;
using zeffmod.Content.Items.Weapons.Melee;

namespace zeffmod.Content.NPCs.zeffgodgamer
{
    public class evil_man : ModNPC
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/NPCs/evilman/" + this.Name;
            }
        }
        public override void SetDefaults()
        {
            NPC.noGravity = true;
            NPC.noTileCollide = true;
            NPC.width = 90;
            NPC.height = 93;
            NPC.damage = 2;
            NPC.chaseable = false;
            NPC.defense = 1;
            NPC.lifeMax = 10000;
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
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<murdersama>()));
        }
        public override bool CheckActive()
        {
            return false;
        }
        public override void AI()
        {
            
        }
    }
}