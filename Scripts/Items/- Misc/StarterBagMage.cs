using System;

namespace Server.Items
{
    class StarterBagMage : Bag
    {
        [Constructable]
        public StarterBagMage()
        {
            Container cont;
            this.Name = "Starter Bag - Mage";

            cont = new Bag();
            cont.Name = "PowerScrolls Bag";
            // Power Scrolls
            PlaceItemIn(cont, 30, 35, new PowerScroll(SkillName.Meditation, 105));
            PlaceItemIn(cont, 60, 35, new PowerScroll(SkillName.Magery, 105));
            PlaceItemIn(cont, 90, 35, new PowerScroll(SkillName.EvalInt, 105));
            PlaceItemIn(cont, 30, 68, new PowerScroll(SkillName.Necromancy, 105));
            PlaceItemIn(cont, 45, 68, new PowerScroll(SkillName.SpiritSpeak, 105));
            PlaceItemIn(this, 0, 0, cont);
            for (int i = 0; i < cont.Items.Count; i++)
            {
                cont.Items[i].LootType = LootType.Blessed;
            }

            cont = new Bag();
            cont.Name = "Gear Bag";
            // Armor
            PlaceItemIn(cont, 30, 35, new LeatherArms());
            PlaceItemIn(cont, 60, 35, new LeatherGloves());
            PlaceItemIn(cont, 90, 35, new LeatherCap());
            PlaceItemIn(cont, 30, 68, new LeatherChest());
            PlaceItemIn(cont, 45, 68, new LeatherLegs());
            // Jewelry
            PlaceItemIn(cont, 75, 68, new GoldNecklace());
            PlaceItemIn(cont, 90, 68, new GoldEarrings());
            PlaceItemIn(cont, 30, 118, new GoldBracelet());
            PlaceItemIn(cont, 60, 118, new GoldRing());
            PlaceItemIn(this, 50, 0, cont);
            for (int i = 0; i < cont.Items.Count; i++)
            {
                BaseArmor armor = cont.Items[i] as BaseArmor;
                BaseJewel jewel = cont.Items[i] as BaseJewel;
                if (armor != null)
                {
                    armor.Attributes.LowerRegCost = 12;
                    armor.LootType = LootType.Newbied;
                    armor.Hue = 1154;
                    armor.Insured = false;
                    armor.TimesImbued = 50;
                    armor.LootType = LootType.Blessed;
                    armor.Weight = 0;
                }
                else if (jewel != null)
                {
                    jewel.Attributes.LowerRegCost = 12;
                    jewel.Attributes.RegenMana = 1;
                    jewel.LootType = LootType.Newbied;
                    jewel.Hue = 1152;
                    jewel.Insured = false;
                    jewel.TimesImbued = 50;
                    jewel.LootType = LootType.Blessed;
                }
            }

            cont = new Bag();
            cont.Name = "Book Bag";
            PlaceItemIn(cont, 30, 35, new Spellbook());
            PlaceItemIn(cont, 60, 35, new NecromancerSpellbook());
            Runebook runebook = new Runebook(5);
            runebook.CurCharges = runebook.MaxCharges;
            PlaceItemIn(cont, 90, 35, runebook);
            for (int i = 0; i < 3; ++i)
                PlaceItemIn(cont, 45 + (i * 10), 75, new RecallRune());
            PlaceItemIn(this, 100, 0, cont);
            for (int i = 0; i < cont.Items.Count; i++)
            {
                Spellbook spellBook = cont.Items[i] as Spellbook;

                if (spellBook != null)
                {
                    spellBook.SkillBonuses.SetValues(0, SkillName.Meditation, 100);
                    spellBook.Attributes.CastSpeed = 1;
                    spellBook.Hue = 1152;
                }
            }
        }

        private static void PlaceItemIn(Container parent, int x, int y, Item item)
        {
            parent.AddItem(item);
            item.Location = new Point3D(x, y, 0);
        }

        public StarterBagMage(Serial serial)
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
