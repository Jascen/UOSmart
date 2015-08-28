using System;
using Server;
using Server.Targeting;

namespace Server.Items
{
	[Flipable( 0x1374, 0x1375 )]
	public class PetLeash : AddonComponent
	{
		#region Constructors
		[Constructable]
		public PetLeash() : this( 0x1374 )
		{
			Name="a pet leash";
			Movable= true;
			LootType = LootType.Blessed;
		}

		[Constructable]
		public PetLeash( int itemID ) : base( itemID )
		{
		}
		
		public PetLeash( Serial serial ) : base( serial )
		{
		}
		#endregion

		public override void OnDoubleClick( Mobile from )
		{
			if( from.InRange( this.GetWorldLocation(), 2 ) == false )
			{
				from.SendLocalizedMessage( 500486 );	//That is too far away.
			}
			else
			{
				from.Target=new PetLeashTarget( this );
				from.SendMessage( "What do you wish to shrink?" );
			}
		}

		private class PetLeashTarget : Target
		{
			private PetLeash m_Post;

			public PetLeashTarget( Item i ) : base( 3, false, TargetFlags.None )
			{
				m_Post=(PetLeash)i;
			}
			
			protected override void OnTarget( Mobile from, object targ )
			{
				if ( !(m_Post.Deleted) )
				{
					ShrinkFunctions.Shrink( from, targ );
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
