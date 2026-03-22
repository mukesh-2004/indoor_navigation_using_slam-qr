using System.Collections.Generic;
using UnityEngine;

public class SLAMMapBuilder : MonoBehaviour
{
    private List<Vector3> landmarks;

    void Start()
    {
        landmarks = new List<Vector3>();
    }

    public void AddLandmark(Vector3 position)
    {
        landmarks.Add(position);
        UpdateMap();
    }

    private void UpdateMap()
    {
        Debug.Log("Map updated with " + landmarks.Count + " landmarks.");
        // Additional map updating logic
    }

    public void ClearMap()
    {
        landmarks.Clear();
        Debug.Log("Map cleared");
    }

    public void PrintMap()
    {
        foreach (Vector3 landmark in landmarks)
        {
            Debug.Log("Landmark at: " + landmark);
        }
    }
}