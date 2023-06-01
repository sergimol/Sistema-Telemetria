using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public abstract class ISerializer
{
    public abstract string Serialize(TrackerEvent e);
}

