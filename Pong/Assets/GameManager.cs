using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Ball ball;
	public Paddle paddle;

	public static Vector2 bottomLeft;
	public static Vector2 topRight;

    public Text countText;
    public Text countText2;
    public static int count;
    public static int count2;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        count2 = 0;

    	bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
    	topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height));
        
        Instantiate(ball);
        
        Paddle paddle1 = Instantiate(paddle) as Paddle;
        Paddle paddle2 = Instantiate(paddle) as Paddle;
        paddle1.Init (true); //right paddle
        paddle2.Init (false); //left paddle
    }

    void Update() {
        //Restart the game is ESC is pressed
        if(Input.GetKeyDown(KeyCode.Escape)) {
            Application.LoadLevel(0);
            Time.timeScale = 1;
        }
    }
}

