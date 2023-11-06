using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using System.Media;
using Terraria.Audio;
using zeffmod.Content.Items.tiles;
using zeffmod.Content.Items.Materials;
using zeffmod.Assets.sounds;
using zeffmod.Content.Projectiles.Melee;

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
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 2;
        }
        public override void SetDefaults()
        {
            Item.damage = 9100;
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
            Item.shoot = ModContent.ProjectileType<hahaproj>();
            Item.maxStack = 1;
            Item.shootSpeed = 15;
        }
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            SoundEngine.PlaySound(new SoundStyle("zeffmod/Assets/sounds/pipe"));
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