using System;
using Server.Items;

namespace Server.Items
{
	public class ShrinkStone : Item
	{
		[Constructable]
		public ShrinkStone() : base( 0xED4 )
		{
			Movable = false;
			Hue = 0x26;
			Name = "10 Shrink Potions Stone";
		}

		public override void OnDoubleClick( Mobile from )
		{
			Container pack = from.Backpack;
			
			if ( pack != null && pack.ConsumeTotal( typeof( Gold ), 5000) )
			{
				Shrinkbag sbag = new Shrinkbag( 1 );


				if ( !from.AddToBackpack( sbag ) )
					sbag.Delete();	
			}
			else
			{
				from.SendMessage( 0XAD, "You need at least 5000gp in your backpack to use this." );
			}
		}

		public ShrinkStone( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
