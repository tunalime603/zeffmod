using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace zeffmod.Projectiles
{
    public class guidepro : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 19;
            Projectile.height = 28;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.tileCollide = true;
            Projectile.penetrate = 10;
            Projectile.timeLeft = 500;
            Projectile.extraUpdates = 1;
            Projectile.ignoreWater = true;
        }
        public override void AI()
        {

            Projectile.rotation = Projectile.velocity.ToRotation() + 1.57f;
            int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Dirt, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust2].velocity *= 2f;
            Main.dust[dust2].scale = (float)Main.rand.Next(0, 0) * 0;
            Main.dust[dust2].noGravity = false;
        }


        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 10; i++)
            {
                int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.Dirt, 0f, 0f, 0, default(Color), 1f);
                Main.dust[dust].noGravity = false;
                int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Dirt, 0f, 0f, 0, default(Color), 1f);
                Main.dust[dust2].velocity *= 2f;
                Main.dust[dust2].scale = (float)Main.rand.Next(0, 0) * 0;
                Main.dust[dust2].noGravity = false;
            }
        }
    }
}