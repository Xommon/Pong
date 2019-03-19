using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
	//Variables for paddle
	float speed;
	float height;

	string input;
	bool isRight;

    // Start is called before the first frame update
    void Start()
    {
        height = transform.localScale.y;
        speed = 5f;
    }

    public void Init(bool isRightPaddle) {

    	isRight = isRightPaddle;

    	Vector2 pos = Vector2.zero;

    	if (isRightPaddle) {
    		pos = new Vector2 (GameManager.topRight.x,0);
    		pos -= Vector2.right * transform.localScale.x; //Move a bit to the left
    	
    		input = "PaddleRight";
    	} else {
    		pos = new Vector2 (GameManager.bottomLeft.x,0);
    		pos += Vector2.right * transform.localScale.x; //Move a bit to the right
    	
    		input = "PaddleLeft";
    	}

    	//Update the paddle's position
    	transform.position = pos;

    	transform.name = input;
    }

    // Update is called once per frame
    void Update()
    {
        //Move the paddle

        //GetAxis is a number between 1 and -1
        float move = Input.GetAxis(input) * Time.deltaTime * speed;

        transform.Translate (move * Vector2.up);
    }
}
