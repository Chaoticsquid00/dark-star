using Godot;
using System;

[GlobalClass]
public partial class Item : Resource
{
    [Export] public String Name {get; set;}
    [Export] public Texture2D Icon {get; set;}
    [Export] public bool Stackable {get; set;}
}
