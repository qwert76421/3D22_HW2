using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollideController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text WinOrLose;
    public Button button;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Missile"){
            Time.timeScale = 0f;
            button.gameObject.SetActive(true);
            WinOrLose.gameObject.SetActive(true);
            WinOrLose.text = "YOU LOSE!";
        }
    }
}
