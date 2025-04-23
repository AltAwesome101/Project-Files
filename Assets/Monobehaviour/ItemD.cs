using UnityEngine;
using TMPro;

//Method to Access the count of Scriptable Objects Directly

public class ItemQuantityDisplay : MonoBehaviour 
{
    public Item itemToTrack;

    public TextMeshProUGUI quantityText;
    private void UpdateQuantityText(int quantity)
    {
        if (quantityText != null)
        {
            quantityText.text = $"Parts: {quantity}";
        }
    }
    private void OnEnable() 
    {
        if (itemToTrack != null ) 
        {
            itemToTrack.OnQuantityChanged += UpdateQuantityText;

            UpdateQuantityText(itemToTrack.quantity);

        }
    }
    private void OnDisable() 
    {
        if (itemToTrack != null ) 
        {
            itemToTrack.OnQuantityChanged -= UpdateQuantityText;
        }
    }

}