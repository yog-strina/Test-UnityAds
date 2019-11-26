using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePassing : MonoBehaviour
{
    void OnApplicationPause(bool isPaused) {                 
        IronSource.Agent.onApplicationPause(isPaused);
    }
}
