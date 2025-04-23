using UnityEngine;

// Health Pick-UP Code 
public class Consumable : MonoBehaviour
{
    public Item item;

    public GameObject labelText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            RMInventory playerInventory = collision.GetComponent<RMInventory>();
            if (playerInventory != null)
            {
                playerInventory.AddItem(item);
            }
            if (labelText != null)
            {
                labelText.SetActive(false);
            }
            Destroy(gameObject);
        }
    }
}

