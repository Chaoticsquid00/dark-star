using Godot;
using System;
using System.Collections.Generic;

public interface IReadOnlyInventoryModel
{
    event Action InventoryContentsChanged;
    event Action<int> SlotUpdated;
    event Action InventorySizeUpdated;
    event Action InventoryCleared;
    event Action CurrencyUpdated;

    int Currency { get; }

    IReadOnlyList<IReadOnlyItemSlot> ItemSlots { get; }

}
