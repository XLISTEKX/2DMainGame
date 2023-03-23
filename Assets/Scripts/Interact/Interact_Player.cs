using UnityEngine;

public class Interact_Player : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        IInteract interactObject = collision.GetComponent<IInteract>();
        interactObject.Interact();
    }
}
