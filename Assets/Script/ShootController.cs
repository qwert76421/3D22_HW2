using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    // Start is called before the first frame update
    public BulletController BulletPrefab;
    public GameObject DamageBar;
    float time = 0f;
    public bool shoot = false;
    public float speed = 0.05f;
    public float speedChange = 0.02f;
   // Use this for initialization
   void Start() {

   }

   // Update is called once per frame
   void Update() {
        time += Time.deltaTime;
        var bullet = FindObjectsOfType<BulletController>();
        if(Input.GetKey(KeyCode.Space)){
            speed += speedChange * Time.deltaTime;
            if(speed > 0.2f){
                speed = 0.2f;
            }
            DamageBar.transform.localPosition = new Vector3((-300 + 300*(speed/0.2f)), 0f, 0f);
            // Debug.Log("speed:" + speed);
        }
        if (Input.GetKeyUp(KeyCode.Space)) {
               if (time > 0.5f && bullet.Length < 1) {
                    BulletPrefab.speed = speed;
                    Instantiate(BulletPrefab, this.transform.position, this.transform.rotation);
                    shoot = true;
                    time = 0;
                    speed = 0.05f;
                }
        }
   }

    public float getSpeed(){
        return speed;
    }

}
