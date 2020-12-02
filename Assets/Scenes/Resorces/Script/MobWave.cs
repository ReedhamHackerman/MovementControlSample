
using System;
using UnityEngine;

[Serializable]
public struct MobWave
{

    public enum WaveType
    {
        Mobs,Minions,Boses
    }

    public WaveType type;
    public GameObject Prefab;
    public int Count;
}