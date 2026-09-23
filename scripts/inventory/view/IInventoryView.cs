using System;

public interface IInventoryView
{
    event Action<int> SlotPressed;
    event Action Closed;

    void Connect(IInventoryController controller);
    void Disconnect();

}
