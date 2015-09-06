using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [FlipableAttribute(0x13E4, 0x13E3)]
    public class RunicHammer : BaseRunicTool
    {
        [Constructable]
        public RunicHammer(CraftResource resource)
            : base(resource, 0x13E3)
        {
            this.Weight = 8.0;
            this.Layer = Layer.OneHanded;
            this.Hue = CraftResources.GetHue(resource);
        }

        [Constructable]
        public RunicHammer(CraftResource resource, int uses)
            : base(resource, uses, 0x13E3)
        {
            this.Weight = 8.0;
            this.Layer = Layer.OneHanded;
            this.Hue = CraftResources.GetHue(resource);
        }

        public RunicHammer(Serial serial)
            : base(serial)
        {
        }

        public override CraftSystem CraftSystem
        {
            get
            {
                return DefBlacksmithy.CraftSystem;
            }
        }
        public override int LabelNumber
        {
            get
            {
                int index = CraftResources.GetIndex(this.Resource);

                if (index >= 1 && index <= 8)
                    return 1049019 + index;

                return 1045128; // runic smithy hammer
            }
        }
        public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);

            int index = CraftResources.GetIndex(this.Resource);

            if (index >= 1 && index <= 8)
                return;

            if (!CraftResources.IsStandard(this.Resource))
            {
                int num = CraftResources.GetLocalizationNumber(this.Resource);

                if (num > 0)
                    list.Add(num);
                else
                    list.Add(CraftResources.GetName(this.Resource));
            }
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
    public class DullCopperRunicHammer : RunicHammer
    {
        public override CraftSystem CraftSystem { get { return DefBlacksmithy.CraftSystem; } }
        [Constructable]
        public DullCopperRunicHammer()
            : base(CraftResource.DullCopper)
        {
            Name = "DullCopper Runic Hammer";
            UsesRemaining = 50;
        }
        public DullCopperRunicHammer(Serial serial) : base(serial) { }

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
    public class ShadowIronRunicHammer : RunicHammer
    {
        public override CraftSystem CraftSystem { get { return DefBlacksmithy.CraftSystem; } }
        [Constructable]
        public ShadowIronRunicHammer()
            : base(CraftResource.ShadowIron)
        {
            Name = "ShadowIron Runic Hammer";
            UsesRemaining = 45;
        }
        public ShadowIronRunicHammer(Serial serial) : base(serial) { }

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
    public class CopperRunicHammer : RunicHammer
    {
        public override CraftSystem CraftSystem { get { return DefBlacksmithy.CraftSystem; } }
        [Constructable]
        public CopperRunicHammer()
            : base(CraftResource.Copper)
        {
            Name = "Copper Runic Hammer";
            UsesRemaining = 40;
        }
        public CopperRunicHammer(Serial serial) : base(serial) { }

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
    public class BronzeRunicHammer : RunicHammer
    {
        public override CraftSystem CraftSystem { get { return DefBlacksmithy.CraftSystem; } }
        [Constructable]
        public BronzeRunicHammer()
            : base(CraftResource.Bronze)
        {
            Name = "Bronze Runic Hammer";
            UsesRemaining = 35;
        }
        public BronzeRunicHammer(Serial serial) : base(serial) { }

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
    public class GoldRunicHammer : RunicHammer
    {
        public override CraftSystem CraftSystem { get { return DefBlacksmithy.CraftSystem; } }
        [Constructable]
        public GoldRunicHammer()
            : base(CraftResource.Gold)
        {
            Name = "Gold Runic Hammer";
            UsesRemaining = 30;
        }
        public GoldRunicHammer(Serial serial) : base(serial) { }

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
    public class AgapiteRunicHammer : RunicHammer
    {
        public override CraftSystem CraftSystem { get { return DefBlacksmithy.CraftSystem; } }
        [Constructable]
        public AgapiteRunicHammer()
            : base(CraftResource.Agapite)
        {
            Name = "Agapite Runic Hammer";
            UsesRemaining = 25;
        }
        public AgapiteRunicHammer(Serial serial) : base(serial) { }

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
    public class VeriteRunicHammer : RunicHammer
    {
        public override CraftSystem CraftSystem { get { return DefBlacksmithy.CraftSystem; } }
        [Constructable]
        public VeriteRunicHammer()
            : base(CraftResource.Verite)
        {
            Name = "Verite Runic Hammer";
            UsesRemaining = 20;
        }
        public VeriteRunicHammer(Serial serial) : base(serial) { }

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
    public class ValoriteRunicHammer : RunicHammer
    {
        public override CraftSystem CraftSystem { get { return DefBlacksmithy.CraftSystem; } }
        [Constructable]
        public ValoriteRunicHammer()
            : base(CraftResource.Valorite)
        {
            Name = "Valorite Runic Hammer";
            UsesRemaining = 15;
        }
        public ValoriteRunicHammer(Serial serial) : base(serial) { }

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