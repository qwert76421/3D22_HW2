using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissileController : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.Translate(new Vector3(0, -1 * speed, 0));
        this.transform.Translate(new Vector3(0, -1 * speed * Time.deltaTime, 0));
    }

    private void OnCollisionEnter(Collision collision) {
        // if(collision.gameObject.tag == "Cannon"){
        //     Time.timeScale = 0f;
        // }        
        if(collision.gameObject.tag == "Plane"){
            Destroy(this.gameObject);
        }
    }
}
