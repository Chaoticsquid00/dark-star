using Godot;
using System;

[GlobalClass]
public partial class InventoryController : Node, IInventoryController
{
    // controller references its model, but doesn't store a reference to views
    // due to the many-to-one relationship.

    [Export] private InventoryModel _inventoryModel;
    public IReadOnlyInventoryModel InventoryModel => _inventoryModel;

}
