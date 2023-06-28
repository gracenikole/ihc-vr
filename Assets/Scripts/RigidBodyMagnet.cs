using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMagnet : MonoBehaviour
{
    private Vector3 originalPosition;
    private bool isPlaced = false;
    private Transform targetLocation;

    private void Start()
    {
        targetLocation = GameObject.FindGameObjectWithTag("Ground 3").transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si colisiona con el lugar específico
        if (collision.collider.CompareTag("Ground 3"))
        {
            // Obtiene el collider del lugar específico
            Collider targetCollider = collision.collider;

            // Verifica si el objeto está dentro del área del collider del lugar específico
            if (targetCollider.bounds.Contains(transform.position))
            {
                // Coloca el objeto en la posición y rotación del lugar específico
                transform.position = targetLocation.position;
                transform.rotation = targetLocation.rotation;

                // Desactiva la física del objeto para evitar que se mueva
                Rigidbody rb = GetComponent<Rigidbody>();
                if (rb != null)
                    rb.isKinematic = true;

                isPlaced = true;
            }
        }
    }
    private void OnMouseDown()
    {
        // Re-activa la física del objeto si fue colocado previamente
        if (isPlaced)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
                rb.isKinematic = false;

            isPlaced = false;
        }
    }
}
