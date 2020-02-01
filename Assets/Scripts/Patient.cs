using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : MonoBehaviour
{
    // How much blood to lose per second
    public float BloodLossRate = 5f;
    private float Blood = 100.0f;

    void Update()
    {
        Blood -= BloodLossRate * Time.deltaTime;
    }

    public void Heal(float healAmount)
    {

    }
}
