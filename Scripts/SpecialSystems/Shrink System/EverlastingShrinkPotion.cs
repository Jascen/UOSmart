using System;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;

namespace Server.Items
{
	public class EverlastingShrinkPotion : Item
	{

		#region Constructors
		public EverlastingShrinkPotion( Serial serial ) : base( serial )
		{
		}
		[Constructable]
		public EverlastingShrinkPotion() : base( 0xF04 )
		{
			Name="an Everlasting Shrink Potion";
			Hue=38;
			LootType=LootType.Blessed;
		}
		#endregion

		public override void OnDoubleClick( Mobile from )
		{
			if ( !Movable )
				return;
			else if( from.InRange( this.GetWorldLocation(), 2 ) == false )
			{
				from.SendLocalizedMessage( 500486 );	//That is too far away.
				return;
			}

			Container pack = from.Backpack;

			if ( !(Parent == from || ( pack != null && Parent == pack )) ) //If not in pack.
			{
				from.SendLocalizedMessage( 1042001 );	//That must be in your pack to use it.
				return;
			}
			from.Target=new EverlastingShrinkPotionTarget( this );
			from.SendMessage( "What do you wish to shrink?" );
		}


		private class EverlastingShrinkPotionTarget : Target
		{
			private EverlastingShrinkPotion m_Potion;

			public EverlastingShrinkPotionTarget( Item i ) : base( 3, false, TargetFlags.None )
			{
				m_Potion=(EverlastingShrinkPotion)i;
			}
			
			protected override void OnTarget( Mobile from, object targ )
			{
				if ( !(m_Potion.Deleted) )
				{
					if ( ShrinkFunctions.Shrink( from, targ ) )
					{
						
					}
				}

				return;
			}
		}


		#region Serialization
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
		#endregion
	}
}
