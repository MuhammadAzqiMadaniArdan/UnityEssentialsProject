using UnityEngine;
using TMPro;
using System;

public class UpdateCollectibleCount : MonoBehaviour
{
    private TextMeshProUGUI collectibleText; // Reference to the TextMeshProUGUI component

    public static int TotalCollectibles { get; private set; } // Property to expose total collectibles

    void Start()
    {
        collectibleText = GetComponent<TextMeshProUGUI>();
        if (collectibleText == null)
        {
            Debug.LogError("UpdateCollectibleCount script requires a TextMeshProUGUI component on the same GameObject.");
            return;
        }
        UpdateCollectibleDisplay(); // Initial update on start
    }

    void Update()
    {
        UpdateCollectibleDisplay();
    }

    private void UpdateCollectibleDisplay()
    {
        TotalCollectibles = 0;

        // Check and count objects of type Collectible
        Type collectibleType = Type.GetType("Collectible");
        if (collectibleType != null)
        {
            TotalCollectibles += UnityEngine.Object.FindObjectsByType(collectibleType, FindObjectsSortMode.None).Length;
        }

        // Optionally, check and count objects of type Collectible2D as well if needed
        Type collectible2DType = Type.GetType("Collectible2D");
        if (collectible2DType != null)
        {
            TotalCollectibles += UnityEngine.Object.FindObjectsByType(collectible2DType, FindObjectsSortMode.None).Length;
        }

        // Update the collectible count display
        collectibleText.text = $"Collectibles remaining: {TotalCollectibles}";
    }
}

