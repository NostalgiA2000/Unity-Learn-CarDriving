using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject player;
    private Vector3 offest = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    private void LateUpdate()
    {
        transform.position = player.transform.position + offest;
    }
}
