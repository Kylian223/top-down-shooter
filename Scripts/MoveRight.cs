using Godot;
using System;

public partial class MoveRight : Node2D
{
    public override void _Ready()
    {
        base._Ready();
    }

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
        this.Position = Position + new Vector2(1,0);
    }
}
