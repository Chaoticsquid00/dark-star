using Godot;
using System;

public partial class ItemSlotView : AspectRatioContainer
{
    [Export] private RichTextLabel amountLabel;
    [Export] private TextureRect textureRect;


    public void UpdateItemSlot(IReadOnlyItemSlot itemSlot)
    {
        if(itemSlot == null || itemSlot.Item.Icon == null)
        {
            SetContentVisibility(false);
            return;
        }
        amountLabel.Visible = itemSlot.Item.Stackable && itemSlot.Amount > 1;
        amountLabel.Text = itemSlot.Amount.ToString();
        textureRect.Texture = itemSlot.Item.Icon;
    }

    public void SetContentVisibility(bool visible)
    {
        amountLabel.Visible = visible;
        textureRect.Visible = visible;
    }
}
