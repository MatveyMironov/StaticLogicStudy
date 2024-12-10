using System;
using UnityEngine;

[Serializable]
public class ConstantData
{
    [SerializeField] private float gravitationsalConstant;
    [SerializeField] private float speedOfLight;

    public float GravitationalConstant { get => gravitationsalConstant; }
    public float SpeedOfLight { get => speedOfLight; }
}
