using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[RequireComponent (typeof(ShipBehaviour))]
public abstract class SteeringBehaviour:MonoBehaviour
{
    public float weight = 1.0f;
    public Vector3 force;

    [HideInInspector]
    public ShipBehaviour boid;

    public void Awake()
    {
        boid = GetComponent<ShipBehaviour>();
    }

    public abstract Vector3 Calculate();
}