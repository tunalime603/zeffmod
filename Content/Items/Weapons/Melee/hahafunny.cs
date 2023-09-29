using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using zeffmod.Projectiles;
using System.Media;
using Terraria.Audio;
using zeffmod.tiles;
using zeffmod.Content.Items.tiles;

namespace zeffmod.Content.Items.Weapons.Melee
{

    public class hahafunny : ModItem
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
            Item.damage = 910;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = int.MaxValue;
            Item.sellPrice(platinum: -69);
            Item.rare = ItemRarityID.Gray;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.maxStack = 1;
            Item.shoot = ModContent.ProjectileType<hahaproj>();
            Item.shootSpeed = 15;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.IronAnvil, 100);
            recipe.AddIngredient(ModContent.ItemType<epicgamerBar>(), 2);
            recipe.AddTile(ModContent.TileType<epicgamerBartile>());
            recipe.Register();
        }
    }
}