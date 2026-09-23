using Godot;
using System;

public partial class Game : Node
{
    [Export] private World _currentWorld;
    [Export] private PlayerUI _playerUI;

    public override void _Ready()
    {
        _playerUI.InventoryView.Connect(_currentWorld.player.inventoryController);
    }

}
