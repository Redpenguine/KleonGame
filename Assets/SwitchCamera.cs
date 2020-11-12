using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField]
    private Transform[] cameras;

    private int childrenCount;

    private Transform player;
    
    private float minDistanse;
    private GameObject curentCamera;
    // Start is called before the first frame update
    void Start()
    {
        childrenCount = this.gameObject.transform.childCount;
        cameras = new Transform[childrenCount];
        for(int i = 0; i < childrenCount; i++)
        {
            cameras[i] = this.gameObject.transform.GetChild(i).gameObject.transform;
            this.gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
        player = FindObjectOfType<PlayerMovement>().gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        foreach(Transform camera in cameras)
        {
            if((camera.position - player.position).magnitude < minDistanse)
            {
                minDistanse = (camera.position - player.position).magnitude;
                if(curentCamera != null)
                {
                    curentCamera.SetActive(false);
                }
                curentCamera = camera.gameObject;
                if(!curentCamera.activeSelf)
                {
                    curentCamera.SetActive(true);
                }
            }

        }
        minDistanse = 100;

    }
    
}
