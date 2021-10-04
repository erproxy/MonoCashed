using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  HomeSingle;
public class UpdateManager : Singleton<UpdateManager>
{
    private void Update()
    {
        for (var i = 0; i < MonoCashed.allTicks.Count; i++)
        {
            MonoCached.allTicks[i].Tick();
        }
    }

    private void FixedUpdate()
    {
        for (var i = 0; i < MonoCashed.allFixedTicks.Count; i++)
        {
            MonoCached.allTicks[i].FixedTick();
        }
    }

    private void LateUpdate()
    {
        for (var i = 0; i < MonoCashed.allLateTicks.Count; i++)
        {
            MonoCached.allTicks[i].LateTick();
        }
    }
}
