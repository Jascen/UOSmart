using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Items
{
        public class CraftingTokens : Item
        {
            public CraftingTokens(int min, int max) : this(Utility.Random(min, max - min))
            {
            }

            [Constructable]
            public CraftingTokens() : this(1)
            {
            }

            [Constructable]
            public CraftingTokens(int amount) : base(0xEED)
            {
                Stackable = true;
                Name = "Crafting Tokens";
                Hue = 1154;
                Weight = 0;
                Amount = amount;
                LootType = LootType.Blessed;
            }

            public CraftingTokens(Serial serial) : base(serial)
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
