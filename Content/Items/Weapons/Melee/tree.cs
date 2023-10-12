//based on sugercoat from item asylum
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.Audio;
using zeffmod.Assets.sounds;
using Terraria.DataStructures;

namespace zeffmod.Content.Items.Weapons.Melee
{
    public class tree : ModItem
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/Items/Weapons/Melee/" + this.Name;
            }
        }
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[base.Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.DamageType = DamageClass.Generic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.sellPrice(0, 0, 6, 9);
            Item.rare = 2;
            Item.autoReuse = true;
            Item.maxStack = 1;
        }

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            SoundEngine.PlaySound(zeffsounds.treejumpscare, player.position);
        }
    }
}