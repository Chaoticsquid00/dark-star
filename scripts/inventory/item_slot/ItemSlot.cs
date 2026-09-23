using Godot;
using System;

[GlobalClass]
public partial class ItemSlot : Resource, IReadOnlyItemSlot
{
    
    [Export] public int Amount {get; set;} = 1;
    [Export] public Item Item {get; set;}

    // TODO implement CRUD-esque

}
