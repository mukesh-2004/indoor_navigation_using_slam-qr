using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MapPoint
{
    public Vector3 position;
    public string identifier;

    public MapPoint(Vector3 position, string identifier)
    {
        this.position = position;
        this.identifier = identifier;
    }
}

[Serializable]
public class FloorMap
{
    public List<MapPoint> mapPoints;
    public string floorIdentifier;

    public FloorMap(string floorIdentifier)
    {
        this.floorIdentifier = floorIdentifier;
        mapPoints = new List<MapPoint>();
    }

    public void AddMapPoint(Vector3 position, string identifier)
    {
        MapPoint newPoint = new MapPoint(position, identifier);
        mapPoints.Add(newPoint);
    }
}

public class MapDataManager : MonoBehaviour
{
    private Dictionary<string, FloorMap> floorMaps;

    void Awake()
    {
        floorMaps = new Dictionary<string, FloorMap>();
        LoadMaps(); // Load existing maps on startup
    }

    public void CreateFloorMap(string floorIdentifier)
    {
        if (!floorMaps.ContainsKey(floorIdentifier))
        {
            FloorMap newFloorMap = new FloorMap(floorIdentifier);
            floorMaps[floorIdentifier] = newFloorMap;
        }
    }

    public void AddPointToFloorMap(string floorIdentifier, Vector3 position, string identifier)
    {
        if (floorMaps.ContainsKey(floorIdentifier))
        {
            floorMaps[floorIdentifier].AddMapPoint(position, identifier);
        }
    }

    public void SaveMaps()
    {
        // Implement your save logic (e.g., using PlayerPrefs or Serialization) here
        Debug.Log("Maps saved.");
    }

    public void LoadMaps()
    {
        // Implement your load logic here
        Debug.Log("Maps loaded.");
    }
}