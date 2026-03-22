using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARSetupManager : MonoBehaviour
{
    private ARSession arSession;
    private ARPlaneManager arPlaneManager;

    void Awake()
    {
        arSession = GetComponent<ARSession>();
        arPlaneManager = GetComponent<ARPlaneManager>();
    }

    void Start()
    {
        InitializeARSession();
        EnablePlaneDetection();
    }

    private void InitializeARSession()
    {
        arSession.subsystem.Start();
    }

    private void EnablePlaneDetection()
    {
        arPlaneManager.enabled = true;
        arPlaneManager.planePrefab = null; // Replace with your plane prefab if needed
    }
}