using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Camera camera;
    public ShootController cannon;
    // public PlaneController plane;
    public PlaneController terrain;
    public int currScore;
    public Text _text;
    public Text WinOrLose;

    // public TargetController target;
    int i = 20;
    // Start is called before the first frame update
    void Start()
    {
        currScore = 0;
        _text.text = "SCORE: " + currScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        var TargetObjects = FindObjectsOfType<TargetController>();
        if(cannon.shoot == false && terrain.collide == false){
            camera.rect = new Rect(0f, 0f, 1f, 1f);
        }else if(terrain.collide == true|| TargetObjects.Length == i-1){
            if(TargetObjects.Length == i-1){
                i -= 1;
                AddScoreAndDisplay();
                if(currScore == 2000){
                    Time.timeScale = 0f;
                    WinOrLose.gameObject.SetActive(true);
                    WinOrLose.text = "YOU WIN!";
                }
            }
            // plane.collide = false;
            terrain.collide = false;
            cannon.shoot = false;
            camera.rect = new Rect(0f, 0f, 1f, 1f);
        }else if(cannon.shoot == true){
            camera.rect = new Rect(0f, 0f, 0.5f, 1f);
        }
    }

    private void AddScoreAndDisplay()
    {
        currScore += 100;
        _text.text = "SCORE: " + currScore.ToString();
    }
}
