using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool collide = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Bullet") {
            collide = true;
        }
   }
}
