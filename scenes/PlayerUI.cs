using Godot;
using System;

public partial class PlayerUI : CanvasLayer
{

    public IInventoryView InventoryView => _inventoryView;
    [Export] private InventoryView _inventoryView;
}
