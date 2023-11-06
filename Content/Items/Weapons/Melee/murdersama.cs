using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using System.Media;
using Terraria.Audio;
using zeffmod.Content.Items.tiles;
using zeffmod.Content.Items.Materials;
using zeffmod.Assets.sounds;

namespace zeffmod.Content.Items.Weapons.Melee
{

    public class murdersama : ModItem
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
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.damage = 3001;
            Item.DamageType = DamageClass.Melee;
            Item.width = 56;
            Item.height = 128;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = int.MaxValue;
            Item.sellPrice(gold: -30);
            Item.rare = ItemRarityID.Gray;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.maxStack = 1;
            Item.shootSpeed = 15;
        }
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            SoundEngine.PlaySound(new SoundStyle("zeffmod/Assets/sounds/what"));
        }
    }
}