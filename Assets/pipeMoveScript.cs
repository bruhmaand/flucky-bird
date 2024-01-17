using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pipeMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5;
    public float deadZone = -28;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=transform.position+(Vector3.left *moveSpeed)*Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
    
}
