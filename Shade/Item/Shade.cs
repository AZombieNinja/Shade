using Terraria.ID;
using Terraria.ModLoader;

namespace Shade.Item
{
	public class Shade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shade");
			Tooltip.SetDefault("A Blade of the Night");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 1;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}