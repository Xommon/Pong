using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paddle : MonoBehaviour
{
	//Variables for paddle
	[SerializeField]
	float speed;

	float height;

	string input;
	public bool isRight;

    // Start is called before the first frame update
    void Start()
    {
        speed = 6f;
        height = transform.localScale.y;
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

        //Restrict paddle movement
        if (transform.position.y < GameManager.bottomLeft.y + height / 2 && move < 0) {
        	move = 0;
        }
        if (transform.position.y > GameManager.topRight.y - height / 2 && move > 0) {
        	move = 0;
        }

        transform.Translate (move * Vector2.up);
    }
}
