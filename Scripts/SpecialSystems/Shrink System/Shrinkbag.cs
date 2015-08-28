using System; 
using Server; 
using Server.Items; 

namespace Server.Items 
{ 
   public class Shrinkbag : Bag 
   { 
      [Constructable] 
      public Shrinkbag() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public Shrinkbag( int amount ) 
      { 
         DropItem( new ShrinkPotion() ); 
         DropItem( new ShrinkPotion() ); 
         DropItem( new ShrinkPotion() ); 
         DropItem( new ShrinkPotion() ); 
         DropItem( new ShrinkPotion() ); 
         DropItem( new ShrinkPotion() ); 
         DropItem( new ShrinkPotion() ); 
         DropItem( new ShrinkPotion() ); 
         DropItem( new ShrinkPotion() ); 
         DropItem( new ShrinkPotion() ); 

      } 

      public Shrinkbag( Serial serial ) : base( serial ) 
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