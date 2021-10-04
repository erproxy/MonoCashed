using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoCashed : MonoBehaviour
{
    public static List<MonoCashed> allTicks = new List<MonoCashed>(500);
    public static List<MonoCashed> allFixedTicks = new List<MonoCashed>(500);
    public static List<MonoCashed> allLateTicks = new List<MonoCashed>(100);

    private void OnEnable()
    {
        allTicks.Add(this);
        allFixedTicks.Add(this);
        allLateTicks.Add(this);
    }
    private void OnDisable()
    {
        allTicks.Remove(this);
        allFixedTicks.Remove(this);
        allLateTicks.Remove(this);
    }

    public void Tick()
    {
        Ontick();
    }
    public void FixedTick()
    {
        Onfixedtick();
    }
    public void LateTick()
    {
        Onlatetick();   
    }

    public virtual void Ontick()
    {
    }

    public virtual void Onfixedtick()
    {
        
    }
    public virtual void Onlatetick()
    {
    }
}
