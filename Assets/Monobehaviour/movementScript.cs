using UnityEngine;

// Movement Code We'll Use for Prototype

public class movementtest : MonoBehaviour
{
    private Vector2 moveAmount;

    [SerializeField] private float speed;

    [SerializeField] private Rigidbody2D m_RB;

    [SerializeField] private Transform art;

    [SerializeField] private Transform lightmove;
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        moveAmount = moveInput.normalized * speed;

        switch (moveInput)
        {
            case Vector2 vector when vector.Equals(Vector2.left):
                art.rotation = Quaternion.Euler(new Vector3(0, 0, -90));
                lightmove.rotation = Quaternion.Euler(new Vector3(0, 0, -90));
                break;

            case Vector2 vector when vector.Equals(Vector2.right):
                art.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
                lightmove.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
                break;

            case Vector2 vector when vector.Equals(Vector2.down):
                art.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                lightmove.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                break;

            case Vector2 vector when vector.Equals(Vector2.up):
                art.rotation = Quaternion.Euler(new Vector3(0, 0, -180));
                lightmove.rotation = Quaternion.Euler(new Vector3(0, 0, -180));
                break;
            default:

                break;
        }


    }
    private void FixedUpdate()
    {
        m_RB.MovePosition(m_RB.position + moveAmount * Time.fixedDeltaTime);
    }
}