using System.Collections.Generic;
using UnityEngine;

public class Interact_Player : MonoBehaviour
{
    [SerializeField] GameObject interactButton;

    List<IInteractable> interactables = new List<IInteractable>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactables.Add(collision.GetComponent<IInteractable>());
        interactButton.SetActive(true);

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactables.Remove(collision.GetComponent<IInteractable>());
        if(interactables.Count <= 0)
        {
            interactButton.SetActive(false);
        }
    }

    public void interact()
    {
        interactables[0].Interact();
    }
}
