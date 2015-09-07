using System;
using Server.Engines.Craft;

namespace Server.Items
{
    public class RunicSewingKit : BaseRunicTool
    {
        [Constructable]
        public RunicSewingKit(CraftResource resource)
            : base(resource, 0xF9D)
        {
            this.Weight = 2.0;
            this.Hue = CraftResources.GetHue(resource);
        }

        [Constructable]
        public RunicSewingKit(CraftResource resource, int uses)
            : base(resource, uses, 0xF9D)
        {
            this.Weight = 2.0;
            this.Hue = CraftResources.GetHue(resource);
        }

        public RunicSewingKit(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefTailoring.CraftSystem;
            }
        }
        public override void AddNameProperty(ObjectPropertyList list)
        {
            string v = " ";

            if (!CraftResources.IsStandard(this.Resource))
            {
                int num = CraftResources.GetLocalizationNumber(this.Resource);

                if (num > 0)
                    v = String.Format("#{0}", num);
                else
                    v = CraftResources.GetName(this.Resource);
            }

            list.Add(1061119, v); // ~1_LEATHER_TYPE~ runic sewing kit
        }

        public override void OnSingleClick(Mobile from)
        {
            string v = " ";

            if (!CraftResources.IsStandard(this.Resource))
            {
                int num = CraftResources.GetLocalizationNumber(this.Resource);

                if (num > 0)
                    v = String.Format("#{0}", num);
                else
                    v = CraftResources.GetName(this.Resource);
            }

            this.LabelTo(from, 1061119, v); // ~1_LEATHER_TYPE~ runic sewing kit
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

            if (this.ItemID == 0x13E4 || this.ItemID == 0x13E3)
                this.ItemID = 0xF9D;
        }
    }
    public class SpinedRunicSewingKit : RunicSewingKit
    {
        public override CraftSystem CraftSystem { get { return DefTailoring.CraftSystem; } }
        [Constructable]
        public SpinedRunicSewingKit()
            : base(CraftResource.SpinedLeather)
        {
            Name = "Spined Runic Sewing Kit";
            UsesRemaining = 45;
        }
        public SpinedRunicSewingKit(Serial serial) : base(serial) { }

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
    public class HornedRunicSewingKit : RunicSewingKit
    {
        public override CraftSystem CraftSystem { get { return DefTailoring.CraftSystem; } }
        [Constructable]
        public HornedRunicSewingKit()
            : base(CraftResource.HornedLeather)
        {
            Name = "Horned Runic Sewing Kit";
            UsesRemaining = 30;
        }
        public HornedRunicSewingKit(Serial serial) : base(serial) { }

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
    public class BarbedRunicSewingKit : RunicSewingKit
    {
        public override CraftSystem CraftSystem { get { return DefTailoring.CraftSystem; } }
        [Constructable]
        public BarbedRunicSewingKit()
            : base(CraftResource.BarbedLeather)
        {
            Name = "Barbed Runic Sewing Kit";
            UsesRemaining = 15;
        }
        public BarbedRunicSewingKit(Serial serial) : base(serial) { }

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