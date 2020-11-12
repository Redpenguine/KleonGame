using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchZone : MonoBehaviour
{
    [SerializeField]
    private Transform teleportTo;

    private bool canInteract = false;

    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
    }

    

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            player.position = new Vector3(teleportTo.position.x, teleportTo.position.y, player.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            canInteract = false;
        }
    }
}
