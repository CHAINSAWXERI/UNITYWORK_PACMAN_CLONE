using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ModePerformer
{
    private GhostAiMovement _ghost;

    public ModePerformer(GhostAiMovement ghost)
    {
        _ghost = ghost;
    }

    public void PerformMode(IModeStrategy attackStrategy)
    {
        _ghost.SetStrategy(attackStrategy);
        _ghost.PerformMode();
    }
}
