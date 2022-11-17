using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootController : MonoBehaviour
{
    public GameObject missile;
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(time);
        time += Time.deltaTime;
        if(time >= 2f){
            Instantiate(missile, this.transform.position, this.transform.rotation);
            time = 0f;
        }
    }
}
