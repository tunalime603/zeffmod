using System;
using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using zeffmod.Assets.sounds;
using zeffmod.Content.Buffs;

namespace zeffmod.Content.Projectiles.Melee
{
    public class hahaproj : ModProjectile
    {
        public override string Texture => "zeffmod/Assets/Projectiles/" + Name;
        public override void SetDefaults()
        {
            Projectile.width = 75;
            Projectile.height = 75;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.tileCollide = false;
            Projectile.penetrate = 999999;
            Projectile.timeLeft = 500;
            Projectile.extraUpdates = 1;
            Projectile.ignoreWater = true;
        }
        public override void AI()
        {
            int num3 = Projectile.frameCounter;
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(Projectile.position + Projectile.velocity, Projectile.width, Projectile.height, 6, Projectile.velocity.X * 0.5f, Projectile.velocity.Y * 0.5f);
            }
            Projectile.frameCounter = num3 + 1;
            if (Projectile.frameCounter > 0)
            {
                num3 = Projectile.frame;
                Projectile.frame = num3 + 1;
                Projectile.frameCounter = 0;
                if (Projectile.frame > 2)
                {
                    Projectile.frame = 0;
                }
            }
            if (Projectile.velocity.X < 0f)
            {
                Projectile.spriteDirection = -1;
                Projectile.rotation = (float)Math.Atan2(-(double)Projectile.velocity.Y, -(double)Projectile.velocity.X);
            }
            else
            {
                Projectile.spriteDirection = 1;
                Projectile.rotation = (float)Math.Atan2(Projectile.velocity.Y, Projectile.velocity.X);
            }
            if (Projectile.ai[0] >= 0f && Projectile.ai[0] < 200f)
            {
                int num543 = (int)Projectile.ai[0];
                NPC nPC2 = Main.npc[num543];
                if (nPC2.CanBeChasedBy(Projectile, false))
                {
                    float num544 = 20f;
                    Vector2 vector40 = new Vector2(Projectile.Center.X + Projectile.width * 0.5f, Projectile.position.Y + Projectile.height * 0.5f);
                    float num545 = Main.npc[num543].position.X - vector40.X;
                    float num546 = Main.npc[num543].position.Y - vector40.Y;
                    float num547 = (float)Math.Sqrt((double)(num545 * num545 + num546 * num546));
                    num547 = num544 / num547;
                    num545 *= num547;
                    num546 *= num547;
                    Projectile.velocity.X = (Projectile.velocity.X * 14f + num545) / 15f;
                    Projectile.velocity.Y = (Projectile.velocity.Y * 14f + num546) / 15f;
                }
                else
                {
                    float num548 = 1000f;
                    for (int num549 = 0; num549 < 200; num549++)
                    {
                        if (Main.npc[num549].CanBeChasedBy(Projectile, false))
                        {
                            float num550 = Main.npc[num549].Center.X + Main.npc[num549].width / 2;
                            float num551 = Main.npc[num549].Center.Y + Main.npc[num549].height / 2;
                            float num552 = Math.Abs(Projectile.Center.X + Projectile.width / 2 - num550) + Math.Abs(Projectile.Center.Y + Projectile.height / 2 - num551);
                            if (num552 < num548 && Collision.CanHit(Projectile.Center, Projectile.width, Projectile.height, Main.npc[num549].Center, Main.npc[num549].width, Main.npc[num549].height))
                            {
                                num548 = num552;
                                Projectile.ai[0] = num549;
                            }
                        }
                    }
                }
                return;
            }
            Projectile.Kill();
            return;
        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(ModContent.BuffType<LRizz>(), 180, false);
            target.AddBuff(BuffID.OnFire3, 180, false);
            target.AddBuff(BuffID.Frostburn2, 180, false);
            SoundEngine.PlaySound(new SoundStyle("zeffmod/Assets/sounds/pipe"));
        }

        public override void OnKill(int timeLeft)
        {
        }
    }
}