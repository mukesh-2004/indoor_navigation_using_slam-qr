using UnityEngine;  
using UnityEngine.XR.ARFoundation;  
using UnityEngine.XR.ARSubsystems;  

public class QRCodeAnchor : MonoBehaviour  
{  
    private ARTrackedImageManager trackedImageManager;  
    
    void Start()  
    {  
        trackedImageManager = FindObjectOfType<ARTrackedImageManager>();  
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;  
    }  
    
    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)  
    {  
        foreach (var trackedImage in eventArgs.added)  
        {  
            AnchorQRCode(trackedImage);  
        }  
        
        foreach (var trackedImage in eventArgs.updated)  
        {  
            // Perform drift correction  
            UpdateQRCodeAnchor(trackedImage);  
        }  
    }  
    
    private void AnchorQRCode(ARTrackedImage trackedImage)  
    {  
        // Create an anchor at the QR code's position  
        var anchor = trackedImage.gameObject.AddComponent<ARAnchor>();  
        anchor.transform.position = trackedImage.transform.position;  
        anchor.transform.rotation = trackedImage.transform.rotation;  
    }  
    
    private void UpdateQRCodeAnchor(ARTrackedImage trackedImage)  
    {  
        // Drift correction algorithm  
        Vector3 correctedPosition = trackedImage.transform.position;  
        // Implement drift correction logic here  
        // Example: Use Kalman filter or any other approach  
        trackedImage.transform.position = correctedPosition;  
    }  
}
