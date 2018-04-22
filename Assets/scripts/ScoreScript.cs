using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public int score = 5;
    private Text textComponent;
	void Start ()
    {
        textComponent = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
        textComponent.text = "Score: " + score;
	}
     public void Addscore()
    {
        score += 1;
    }
}
