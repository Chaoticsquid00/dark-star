
using Godot;
using System;

public interface IReadOnlyItemSlot
{
    int Amount { get; }
    Item Item { get; }
    
}
