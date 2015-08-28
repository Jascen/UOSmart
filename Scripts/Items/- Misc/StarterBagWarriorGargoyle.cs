using System;

namespace Server.Items
{
    class StarterBagWarriorGargoyle : Bag
    {
        [Constructable]
        public StarterBagWarriorGargoyle()
        {
            Container cont;
            this.Name = "Starter Bag - Warrior";

            cont = new Bag();
            cont.Name = "PowerScroll Bag";
            PlaceItemIn(cont, 30, 35, new PowerScroll(SkillName.Fencing, 105));
            PlaceItemIn(cont, 60, 35, new PowerScroll(SkillName.Swords, 105));
            PlaceItemIn(cont, 90, 35, new PowerScroll(SkillName.Macing, 105));
            PlaceItemIn(cont, 30, 68, new PowerScroll(SkillName.Archery, 105));
            PlaceItemIn(cont, 45, 68, new PowerScroll(SkillName.Parry, 105));
            PlaceItemIn(cont, 75, 68, new PowerScroll(SkillName.Chivalry, 105));
            PlaceItemIn(cont, 90, 68, new PowerScroll(SkillName.Tactics, 105));
            PlaceItemIn(cont, 30, 118, new PowerScroll(SkillName.Anatomy, 105));
            PlaceItemIn(cont, 60, 118, new PowerScroll(SkillName.Healing, 105));
            PlaceItemIn(this, 0, 0, cont);
            for (int i = 0; i < cont.Items.Count; i++)
            {
                cont.Items[i].LootType = LootType.Blessed;
            }

            cont = new Bag();
            cont.Name = "Gear Bag";
            // Armor
            PlaceItemIn(cont, 30, 35, new GargishPlateChest());
            PlaceItemIn(cont, 90, 35, new GargishPlateArms());
            PlaceItemIn(cont, 30, 68, new GargishPlateKilt());
            PlaceItemIn(cont, 45, 68, new GargishPlateWingArmor());
            PlaceItemIn(cont, 45, 68, new GargishRobe());
            // Jewelry
            PlaceItemIn(cont, 90, 68, new GargishNecklace());
            PlaceItemIn(cont, 30, 118, new GargishEarrings());
            PlaceItemIn(cont, 60, 118, new GargishRing());
            PlaceItemIn(cont, 90, 100, new GargishBracelet());
            PlaceItemIn(this, 50, 0, cont);
            for (int i = 0; i < cont.Items.Count; i++)
            {
                BaseArmor armor = cont.Items[i] as BaseArmor;
                BaseJewel jewel = cont.Items[i] as BaseJewel;
                BaseClothing clothes = cont.Items[i] as BaseClothing;
                if (jewel != null)
                {
                    jewel.Attributes.LowerRegCost = 12;
                    jewel.Attributes.AttackChance = 5;
                    jewel.Attributes.DefendChance = 5;
                    jewel.LootType = LootType.Blessed;
                    jewel.Hue = 1161;
                    jewel.Insured = false;
                    jewel.TimesImbued = 50;
                }
                else if (armor != null)
                {
                    armor.Attributes.LowerRegCost = 12;
                    armor.ArmorAttributes.MageArmor = 1;
                    armor.LootType = LootType.Blessed;
                    armor.Hue = 1157;
                    armor.Insured = false;
                    armor.TimesImbued = 50;
                    armor.StrRequirement = 0;
                    armor.Weight = 0;
                }
                else if (clothes != null)
                {
                    clothes.Attributes.LowerRegCost = 12;
                    clothes.LootType = LootType.Blessed;
                    clothes.TimesImbued = 50;
                }
            }

            cont = new Bag();
            cont.Name = "Weapon Bag";
            // Weapons
            PlaceItemIn(cont, 30, 35, new Cyclone());
            PlaceItemIn(cont, 45, 68, new GargishKryss());
            PlaceItemIn(cont, 75, 68, new GargishBattleAxe());
            PlaceItemIn(cont, 90, 68, new GargishGnarledStaff());
            PlaceItemIn(cont, 30, 118, new BookOfChivalry((UInt64)0x3FF));
            PlaceItemIn(cont, 60, 118, new BookOfNinjitsu());
            PlaceItemIn(this, 100, 0, cont);

            for (int i = 0; i < cont.Items.Count; i++)
            {
                BaseThrown thrown = cont.Items[i] as BaseThrown;
                BaseMeleeWeapon melee = cont.Items[i] as BaseMeleeWeapon;
                if (thrown != null)
                {
                    thrown.Attributes.WeaponSpeed = 35;
                    thrown.Attributes.RegenHits = 20;
                    thrown.TimesImbued = 50;
                    thrown.DurabilityLevel = WeaponDurabilityLevel.Regular;
                    thrown.Hue = 1161;
                    thrown.LootType = LootType.Blessed;
                    thrown.TimesImbued = 50;
                }
                else if (melee != null)
                {
                    melee.Attributes.WeaponSpeed = 35;
                    melee.Attributes.RegenHits = 20;
                    melee.TimesImbued = 50;
                    melee.DurabilityLevel = WeaponDurabilityLevel.Regular;
                    melee.Hue = 1161;
                    melee.LootType = LootType.Blessed;
                    melee.TimesImbued = 50;
                }
            }
        }

        private static void PlaceItemIn(Container parent, int x, int y, Item item)
        {
            parent.AddItem(item);
            item.Location = new Point3D(x, y, 0);
        }

        public StarterBagWarriorGargoyle(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}
