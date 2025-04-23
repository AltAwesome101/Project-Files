using UnityEngine;
using TMPro;

// Count the number of Parts availiable after Picking Up and Removing DONT USE IN PROTOTYPE
public class ItemUIUpdater : MonoBehaviour
{
    public Item trackedItem;

    public TextMeshProUGUI quantityText;

    private void OnEnable()
    {
        if (trackedItem != null)
        {
            trackedItem.OnQuantityChanged += UpdateQuantityDisplay;
            UpdateQuantityDisplay(trackedItem.quantity);
        }
    }
    private void OnDisable()
    {
        if (trackedItem != null)
        {
            trackedItem.OnQuantityChanged -= UpdateQuantityDisplay;
        }
    }
    private void UpdateQuantityDisplay(int quantity)
    {
        if (quantityText != null)
        {
            quantityText.text = $"Parts: {quantity}";
        }
    }
}
