using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerConfig
{
    // Configuración del tracker específica para el juego
    // Struct y array para elegir desde el editor que eventos se trackean
    public struct EventConfig
    {
        public string eventName;
        public bool isTracked;
    }

    

    public TrackerConfig()
    {
        
    }
}
