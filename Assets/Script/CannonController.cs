using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cannon;
    public GameObject Head;
    public GameObject target;
    public float move_speed = 10f;
    public float rotate_speed = 15f;

   // Use this for initialization
   void Start() {

   }

   // Update is called once per frame
   void Update() {
        if (Input.GetKey(KeyCode.A)){
            transform.RotateAround(target.transform.position, Vector3.up, 2f * rotate_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.RotateAround(target.transform.position, -Vector3.up, 2f * rotate_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W)){
            float v = Input.GetAxisRaw("Vertical") * move_speed * Time.deltaTime;
            Head.transform.Rotate(new Vector3(v, 0, 0));
        }
        if (Input.GetKey(KeyCode.S)){
            float v = Input.GetAxisRaw("Vertical") * move_speed * Time.deltaTime;
            Head.transform.Rotate(new Vector3(v, 0, 0));
        }

   }


}
