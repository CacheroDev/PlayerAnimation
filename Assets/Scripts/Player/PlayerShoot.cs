using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] public bool shootRequested;
    [SerializeField] float shootingRate;
    float ctr;

    void Start()
    {
        shootRequested = false;
        ctr = 0;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shootRequested = true;
            Debug.Log("Instantiate projectile");
        }

        if (shootRequested)
        {
            if (ctr < shootingRate)
            {
                ctr += Time.deltaTime;
            }
            else
            {
                ctr = 0;
                shootRequested = false;
            }
        }
    }
}
