using UnityEngine;

public class PlaceGrowingTree : MonoBehaviour
{
    public GameObject treePrefab; // Assign the tree prefab in the Inspector

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button clicked
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(treePrefab, hit.point, Quaternion.identity);
            }
        }
    }
}
