using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;

namespace zeffmod.Content.NPCs
{
    public class publicservent : ModNPC
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/NPCs/" + this.Name;
            }
        }
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Sky,
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Surface,
                new FlavorTextBestiaryInfoElement("some guy who has magic powers and a messaiah complex. he wanted to \"save\" your terraria world but then you killed his uncle you little devious little something.")
            });
        }
        public override void SetDefaults()
        {
            NPC.noGravity = false;
            NPC.noTileCollide = false;
            NPC.dontTakeDamage = false;
            NPC.width = 128;
            NPC.height = 128;
            NPC.damage = 25;
            NPC.chaseable = false;
            NPC.defense = 6;
            NPC.lifeMax = 5000;
            NPC.HitSound = new SoundStyle?(SoundID.PlayerHit);
            NPC.DeathSound = new SoundStyle?(SoundID.PlayerHit);
            NPC.value = 0f;
            NPC.knockBackResist = 1f;
            AnimationType = 1;
            NPC.aiStyle = 5;
            AIType = 299;
            NPC.friendly = false;
            NPC.rarity = 1;
            NPC.lavaImmune = false;
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