using Godot;
using System;
using System.ComponentModel;

public partial class InventoryView : Control, IInventoryView
{
    protected IReadOnlyInventoryModel currentModel;

    public event Action<int> SlotPressed;
    public event Action Closed;

    [Export] private InventoryViewGrid itemSlotGrid;

    public void Connect(IInventoryController controller)
    {
        Disconnect();
        currentModel = controller.InventoryModel;
        currentModel.InventoryContentsChanged += Populate;
        currentModel.InventorySizeUpdated += OnInventorySizeUpdated;
        currentModel.SlotUpdated += OnSlotUpdated;
        currentModel.InventoryCleared += ClearView;
        currentModel.CurrencyUpdated += CurrencyUpdated;
        Populate();
    }

    public void Disconnect()
    {
        if(currentModel == null) return;
        currentModel.InventoryContentsChanged -= Populate;
        currentModel.InventorySizeUpdated -= OnInventorySizeUpdated;
        currentModel.SlotUpdated -= OnSlotUpdated;
        currentModel.InventoryCleared -= ClearView;
        currentModel.CurrencyUpdated -= CurrencyUpdated;
        currentModel = null;
    }

    protected void Populate()
    {
        itemSlotGrid.ClearSlotViews();
        foreach(IReadOnlyItemSlot slot in currentModel.ItemSlots)
        {
            itemSlotGrid.CreateSlotViewEnd(slot);
        }
    }

    protected void OnInventorySizeUpdated() {}
    protected void OnSlotUpdated(int index) {}
    protected void ClearView() {}
    protected void CurrencyUpdated() {}
}
