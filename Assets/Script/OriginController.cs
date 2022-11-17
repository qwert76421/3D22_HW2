using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginController : MonoBehaviour
{
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<20;i++){
            float x = Random.Range(-50f, 50f);
            float y = Random.Range(5f, 25f);
            float z = Random.Range(-50f, 50f);
            while(Mathf.Pow(x, 2) + Mathf.Pow(z, 2) > 2500){
                x = Random.Range(0f, 50f);
                z = Random.Range(0f, 50f);
            }
            Instantiate(Target, new Vector3(x, y, z), this.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
