using UnityEngine;
using UnityEngine.UI;

public class NavigationUI : MonoBehaviour
{
    public Button scanButton;
    public Button navigateButton;
    public Dropdown destinationDropdown;

    void Start()
    {
        // Hook up the button click listeners
        scanButton.onClick.AddListener(OnScanButtonClicked);
        navigateButton.onClick.AddListener(OnNavigateButtonClicked);
        // Populate destinations
        PopulateDestinations();
    }

    void OnScanButtonClicked()
    {
        // Perform scanning action
        Debug.Log("Scanning for QR codes...");
        // Add logic for scanning
    }

    void OnNavigateButtonClicked()
    {
        string selectedDestination = destinationDropdown.options[destinationDropdown.value].text;
        // Begin navigation to the selected destination
        Debug.Log($"Navigating to: {selectedDestination}");
        // Add logic to navigate
    }

    void PopulateDestinations()
    {
        // Example destinations
        destinationDropdown.options.Add(new Dropdown.OptionData("Location A"));
        destinationDropdown.options.Add(new Dropdown.OptionData("Location B"));
        destinationDropdown.options.Add(new Dropdown.OptionData("Location C"));
        Debug.Log("Destinations populated.");
    }
}