using Godot;
using System;

public partial class InventoryViewGrid : Godot.GridContainer
{    
    [Export] PackedScene itemSlotViewScn;

    public void CreateSlotViewEnd()
    {
        ItemSlotView container = itemSlotViewScn.Instantiate<ItemSlotView>();
        AddChild(container);
    }

    public void CreateSlotViewEnd(IReadOnlyItemSlot itemSlot)
    {
        ItemSlotView container = itemSlotViewScn.Instantiate<ItemSlotView>();
        AddChild(container);
        container.UpdateItemSlot(itemSlot);
    }

    public void RemoveSlotViewEnd()
    {
        GetChild(GetChildCount()).QueueFree();
    }

    public void ClearSlotViews()
    {
        foreach(ItemSlotView view in GetChildren())
        {
            view.QueueFree();
        }
    }

    public void UpdateSlotAt(int idx, IReadOnlyItemSlot itemSlot)
    {
        GetChild<ItemSlotView>(idx).UpdateItemSlot(itemSlot);
    }
}
