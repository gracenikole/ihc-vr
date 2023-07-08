using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourWater : MonoBehaviour
{
    public float thresholdAngle = 45f; // The angle of tilting to start pouring
    public ParticleSystem waterParticles; // The Particle System

    void Update()
    {
        // Check if the watering can is tilted enough
        if (Vector3.Angle(Vector3.up, transform.up) > thresholdAngle)
        {
            Debug.Log(Vector3.Angle(Vector3.up, transform.up));
            // If it is, start the Particle System
            if (!waterParticles.isPlaying)
            {
                waterParticles.Play();
            }
        }
        else
        {
            // If it's not, stop the Particle System
            if (waterParticles.isPlaying)
            {
                waterParticles.Stop();
            }
        }
    }
}
