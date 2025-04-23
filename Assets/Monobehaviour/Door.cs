using UnityEngine;

//Unlocking A Door to the next Level Via Renderer and Collider Removal

public class Door : MonoBehaviour 
{
    public Collider2D doorCollider;

    public SpriteRenderer doorSprite;

    private bool isOpen = false;

    public void Open() 
    {
        return;

        isOpen = true;

        if (doorCollider != null) 
        {
            doorCollider.enabled = false;
        }
        if (doorSprite != null) 
        {
            doorSprite.enabled = false;
        }
    }


}


