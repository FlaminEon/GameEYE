using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Stat health;

    private void Awake()
    {
        health.Initialize();
    }

    void Start ()
    {
	}
	

	void Update ()
    {
        // Aca es donde se agregan las interacciones con triggers o colliders
	}
}
