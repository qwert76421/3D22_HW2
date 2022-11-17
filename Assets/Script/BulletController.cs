using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.2f;
    public GameObject boom;
    
    void Start() {
        Destroy(this.gameObject, 5.0f);

        Physics.gravity = new Vector3(0, -9.81f, 0);
    }

   // Update is called once per frame
    void Update() {
        this.transform.Translate(new Vector3(0, -1 * speed, 0));
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Target") {
            Instantiate(boom, this.transform.position, Quaternion.Euler(270.0f,90.0f,90.0f));
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            
        }
        if(collision.gameObject.tag == "Plane"){
            Destroy(this.gameObject);
        }
    }
}
