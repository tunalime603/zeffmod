using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace zeffmod.Projectiles
{
    public class minediamonds : ModProjectile
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/Projectiles/" + this.Name;
            }
        }
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
            Dust dust;
            // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
            Vector2 position = Main.LocalPlayer.Center;
            dust = Main.dust[Terraria.Dust.NewDust(position, 9, 9, 109, 0f, 0f, 145, new Color(255, 0, 0), 5f)];
            dust.noGravity = true;
            dust.shader = GameShaders.Armor.GetSecondaryShader(120, Main.LocalPlayer);


        }


        public override void OnKill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.DD2_KoboldExplosion, Projectile.position);
        }
    }
}