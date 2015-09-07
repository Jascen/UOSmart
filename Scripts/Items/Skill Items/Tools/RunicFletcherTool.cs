using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [FlipableAttribute(0x1022, 0x1023)]
    public class RunicFletcherTools : BaseRunicTool
    {
        public override CraftSystem CraftSystem { get { return DefBowFletching.CraftSystem; } }

        public override int LabelNumber
        {
            get
            {
                int index = CraftResources.GetIndex(Resource);

                if (index >= 301 && index <= 311)
                    return 1042598 + index;

                return 1044166;
            }
        }

        public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);

            int index = CraftResources.GetIndex(Resource);

            if (index >= 301 && index <= 311)
                return;

            if (!CraftResources.IsStandard(Resource))
            {
                int num = CraftResources.GetLocalizationNumber(Resource);

                if (num > 0)
                    list.Add(num);
                else
                    list.Add(CraftResources.GetName(Resource));
            }
        }

        [Constructable]
        public RunicFletcherTools(CraftResource resource) : base(resource, 0x1022)
        {
            Weight = 2.0;
            Hue = CraftResources.GetHue(resource);
        }

        [Constructable]
        public RunicFletcherTools(CraftResource resource, int uses) : base(resource, uses, 0x1022)
        {
            Weight = 2.0;
            Hue = CraftResources.GetHue(resource);
        }

        public RunicFletcherTools(Serial serial) : base(serial)
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

        //daat99 OWTLR start - runic storage
        public override Type GetCraftableType()
        {
            switch (Resource)
            {
                case CraftResource.OakWood:
                    return typeof(OakRunicFletcherTools);
                case CraftResource.AshWood:
                    return typeof(AshRunicFletcherTools);
                case CraftResource.YewWood:
                    return typeof(YewRunicFletcherTools);
                case CraftResource.Heartwood:
                    return typeof(HeartwoodRunicFletcherTools);
                case CraftResource.Bloodwood:
                default:
                    return null;
            }
        }
        //daat99 OWLTR end - runic storage
    }
    public class OakRunicFletcherTools : RunicFletcherTools
    {
        public override CraftSystem CraftSystem { get { return DefBowFletching.CraftSystem; } }
        [Constructable]
        public OakRunicFletcherTools()
            : base(CraftResource.OakWood, 45)
        {
            Name = "Oak Runic Fletchers Tools";
        }
        public OakRunicFletcherTools(Serial serial) : base(serial) { }

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
    public class AshRunicFletcherTools : RunicFletcherTools
    {
        public override CraftSystem CraftSystem { get { return DefBowFletching.CraftSystem; } }
        [Constructable]
        public AshRunicFletcherTools()
            : base(CraftResource.AshWood, 35)
        {
            Name = "Ash Runic Fletchers Tools";
        }
        public AshRunicFletcherTools(Serial serial) : base(serial) { }

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
    public class YewRunicFletcherTools : RunicFletcherTools
    {
        public override CraftSystem CraftSystem { get { return DefBowFletching.CraftSystem; } }
        [Constructable]
        public YewRunicFletcherTools()
            : base(CraftResource.YewWood, 25)
        {
            Name = "Yew Runic Fletchers Tools";
        }
        public YewRunicFletcherTools(Serial serial) : base(serial) { }

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
    public class HeartwoodRunicFletcherTools : RunicFletcherTools
    {
        public override CraftSystem CraftSystem { get { return DefBowFletching.CraftSystem; } }
        [Constructable]
        public HeartwoodRunicFletcherTools()
            : base(CraftResource.Heartwood, 15)
        {
            Name = "Heartwood Runic Fletchers Tools";
        }
        public HeartwoodRunicFletcherTools(Serial serial) : base(serial) { }

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