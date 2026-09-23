using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

[GlobalClass]
public partial class InventoryModel : Resource, IInventoryModel
{
    public event Action InventoryContentsChanged;
    public event Action<int> SlotUpdated;
    public event Action InventorySizeUpdated;
    public event Action InventoryCleared;
    public event Action CurrencyUpdated;

    [Export] public int Currency { get; set; } = 0;
    [Export] public Array<ItemSlot> itemSlots = [];
    public IReadOnlyList<IReadOnlyItemSlot> ItemSlots => itemSlots;


    // TODO implement CRUD



}
