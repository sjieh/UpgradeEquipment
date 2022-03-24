﻿using Terraria;
using Terraria.ModLoader;
using UpgradeEquipment.Items;
using UpgradeEquipment.UI;

namespace UpgradeEquipment
{
	class UpgradeEquipmentPlayer : ModPlayer
	{
		public override void ModifyHitNPC(Item item, NPC target, ref int damage, ref float knockback, ref bool crit)
		{
			int tier = item.GetGlobalItem<UpgradeEquipmentGlobalItem>().upgradeTier;
			float mult = PrefixHelper.GetFinalDamageMult(tier);
			damage = (int)(damage * mult);
		}

		public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
			int tier = player.HeldItem.GetGlobalItem<UpgradeEquipmentGlobalItem>().upgradeTier;
			float mult = PrefixHelper.GetFinalDamageMult(tier);
			damage = (int)(damage * mult);
		}
	}
}