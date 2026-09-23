using Godot;
using System;

public interface IInventoryController
{
    public IReadOnlyInventoryModel InventoryModel { get; }
}
