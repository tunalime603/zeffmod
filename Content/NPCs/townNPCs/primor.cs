using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using zeffmod.Content.Items.potions;
using zeffmod.Content.Items.Weapons.Melee;
using zeffmod.Content.Items.Weapons.Throwing;
using Terraria.Utilities;
using zeffmod.Projectiles;

namespace zeffmod.Content.NPCs.townNPCs
{
    // [AutoloadHead] and npc.townNPC are extremely important and absolutely both necessary for any Town NPC to work at all.
    [AutoloadHead]
    public class man : ModNPC
    {
        public override string Texture => "zeffmod/Content/NPCs/townNPCs/primor";
        public override void SetStaticDefaults()
        {
            // DisplayName automatically assigned from .lang files, but the commented line below is the normal approach.
            // DisplayName.SetDefault("Example Person");
            Main.npcFrameCount[NPC.type] = 2;
            NPCID.Sets.DangerDetectRange[NPC.type] = 700;
            NPCID.Sets.HatOffsetY[NPC.type] = 4;
        }
        public override void SetDefaults()
        {
            NPC.townNPC = true;
            NPC.friendly = true;
            NPC.width = 52;
            NPC.height = 51;
            NPC.aiStyle = 7;
            NPC.damage = 1;
            NPC.defense = 69420;
            NPC.lifeMax = 6;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;
            AnimationType = 1;
        }
        public bool CanTownNpcSpawn(int numTownNPCs, int money)
        {

            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (!player.active)
                {
                    continue;
                }

                foreach (Item item in player.inventory)
                {
                    if (item.type == ModContent.ItemType<hahafunny>())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public override List<string> SetNPCNameList()/* tModPorter Suggestion: Return a list of names */
        {
            return new List<string>
            {
                "bald",
                "emo",
                "coconut",
                "overboard",
                "wise",
                "cool",
                "party",
                "classy",
                "idk",
                "chad",
                "angery",
                "censored",
                "wonka's slave",
                "drip",
                "yes",
                "certified 100%"
            };
        }

        public override void FindFrame(int frameHeight)
        {
            /*npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
        }
        /*
        public override string GetChat()
        {
            int billnye = NPC.FindFirstNPC(NPCID.Clothier);
            if (billnye >= 0 && Main.rand.NextBool(4))
            {
                return "" + Main.npc[billnye].GivenName + " thinks i need clothes, i think i don't.";
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "im too tired to fight";
                case 1:
                    return "life is road blocks";
                case 2:
                    {
                        // Main.npcChatCornerItem shows a single item in the corner, like the Angler Quest chat.
                        Main.npcChatCornerItem = ModContent.ItemType<guide>();
                        return $"this guy tells you what to do, not me.";
                    }
                default:
                    return "their will be blood";
            }
        }
        */

		// Consider using this alternate approach to choosing a random thing. Very useful for a variety of use cases.
		// The WeightedRandom class needs "using Terraria.Utilities;" to use
		public override string GetChat()
		{
			WeightedRandom<string> chat = new WeightedRandom<string>();

			int billnye = NPC.FindFirstNPC(NPCID.Clothier);
			if (billnye >= 0 && Main.rand.NextBool(4))
			{
				chat.Add("" + Main.npc[billnye].GivenName + " thinks i need clothes, i don't.");
			}
			chat.Add("im too tired to fight");
			chat.Add("life is road blocks");
            chat.Add("(ಠಿ_ಠ)");
            chat.Add("");
            chat.Add("#################");
            chat.Add("L+ratio+fatherless");
            chat.Add("can't wait to consume my daily dose of burger king foot lettuce");
            chat.Add("evil man likes \"their will be blood\" a bit too much");
			chat.Add("hey guys welcome back to another banger video today we will be playing undertale and finding out if sans is truly y2k emo", 0.1);
			chat.Add("This message has a weight of 0.01, meaning it appears 100 times as rare.", 0.01);
			return chat; // chat is implicitly cast to a string. You can also do "return chat.Get();" if that makes you feel better
		}
        public void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<murdersama>());
            nextSlot++;
            if (Main.LocalPlayer.HasBuff(BuffID.JunimoPet))
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<WrizzPotion>());
                nextSlot++;
            }
        }
        public override bool CanGoToStatue(bool toKingStatue)
        {
            return true;
        }
        public override void OnGoToStatue(bool toKingStatue)
        {
            StatueTeleport();
        }

        // Create a square of pixels around the NPC on teleport.
        public void StatueTeleport()
        {
            for (int i = 0; i < 30; i++)
            {
                Vector2 position = Main.rand.NextVector2Square(-20, 21);
                if (Math.Abs(position.X) > Math.Abs(position.Y))
                {
                    position.X = Math.Sign(position.X) * 20;
                }
                else
                {
                    position.Y = Math.Sign(position.Y) * 20;
                }
                Dust.NewDustPerfect(NPC.Center + position, DustID.Dirt, Vector2.Zero).noGravity = true;
            }
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 1;
            knockback = 100f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 30;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ModContent.ProjectileType<hahaproj>();
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}