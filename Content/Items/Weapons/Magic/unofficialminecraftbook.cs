using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using zeffmod.Projectiles;

namespace zeffmod.Content.Items.Weapons.Magic
{
    public class unofficialminecraftbook : ModItem
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/Items/Weapons/Magic/" + this.Name;
            }
        }
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            // Common Properties
            Item.width = 82; // Hitbox width of the item.
            Item.height = 52; // Hitbox height of the item.
            Item.scale = 1f;
            Item.rare = ItemRarityID.Gray; // The color that the item's name will be in-game.

            // Use Properties
            Item.useTime = 10; // The item's use time in ticks (60 ticks == 1 second.)
            Item.useAnimation = 8; // The length of the item's use animation in ticks (60 ticks == 1 second.)
            Item.useStyle = ItemUseStyleID.Shoot; // How you use the item (swinging, holding out, etc.)
            Item.autoReuse = true; // Whether or not you can hold click to automatically use it again.

            // Weapon Properties
            Item.DamageType = DamageClass.Ranged; // Sets the damage type to ranged.
            Item.damage = 20; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
            Item.knockBack = 5f; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
            Item.noMelee = true; // So the item's animation doesn't do damage.

            // Gun Properties
            Item.shoot = ModContent.ProjectileType<minediamonds>(); // For some reason, all the guns in the vanilla source have this.
            Item.shootSpeed = 20f; // The speed of the projectile (measured in pixels per frame.)
        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.

        // This method lets you adjust position of the gun in the player's hands. Play with these values until it looks good with your graphics.
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2f, 2f);
        }

    }
}