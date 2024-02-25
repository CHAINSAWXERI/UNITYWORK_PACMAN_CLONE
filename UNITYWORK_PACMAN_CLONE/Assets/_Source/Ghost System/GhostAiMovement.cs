using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GhostAiMovement
{
    public void SetStrategy(IModeStrategy strategy);

    public void PerformMode();
}
