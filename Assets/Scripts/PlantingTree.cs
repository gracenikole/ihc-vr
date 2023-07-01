using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantingTree : MonoBehaviour
{
    public GameObject treePrefab;  // Prefab del árbol
    public Transform plantingArea; // Transform del área de plantación (el plane)

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("PlantingArea"))
        {
            // Elimina el árbol colisionado
            Destroy(gameObject);

            /*
            Vector3 pos = new Vector3(-1.397F, 0.312F, 0.4F);
            // Instancia un nuevo árbol en el área de plantación
            Instantiate(treePrefab, pos, Quaternion.identity);
            treePrefab.SetActive(true);
            */
        }
    }
}
