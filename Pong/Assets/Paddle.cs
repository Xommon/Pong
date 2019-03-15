using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Init(bool isRightPaddle) {

    	Vector2 pos = Vector2.zero;

    	if (isRightPaddle) {
    		pos = new Vector2 (GameManager.topRight.x,0);
    		pos -= Vector2.right * transform.localScale.x; //Move a bit to the left
    	}
    	else {
    		pos = new Vector2 (GameManager.bottomLeft.x,0);
    		pos += Vector2.right * transform.localScale.x; //Move a bit to the right
    	}

    	//Update the paddle's position
    	transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
