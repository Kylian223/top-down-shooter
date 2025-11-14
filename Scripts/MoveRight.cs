using Godot;
using System;

public partial class MoveRight : Node2D
{
    /// <summary>
    /// Called when the node is added to the scene tree to perform initialization.
    /// </summary>
    /// <remarks>
    /// Currently performs no additional initialization beyond the base implementation.
    /// </remarks>
    public override void _Ready()
    {
        base._Ready();
    }

    /// <summary>
    /// Moves the node one unit to the right on each physics frame.
    /// </summary>
    /// <param name="delta">Physics frame timestep in seconds (provided by the engine; not used by this method).</param>
    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
        this.Position = Position + new Vector2(1,0);
    }
}