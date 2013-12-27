using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public int speedX = 12;
	public int speedY = 12;

	private int p1Score = 0;
	private int p2Score = 0;
	public TextMesh p1ScoreText;
	public TextMesh p2ScoreText;

	// Use this for initialization
	void Start()
	{
		p1ScoreText.text = "0";
		p2ScoreText.text = "0";
	}
	
	// Update is called once per frame
	void Update()
	{
		rigidbody2D.velocity = new Vector2(speedX, speedY);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "player")
		{
			speedX *= -1;
		}
		if (col.gameObject.tag == "topBottomWall") 
		{
			speedY *= -1;
		}
		if (col.gameObject.tag == "leftWall")
		{
			transform.position = new Vector2(0, 0);
			p2Score++;
			p2ScoreText.text = p2Score.ToString();
		}
		if (col.gameObject.tag == "rightWall")
		{
			transform.position = new Vector2(0, 0);
			p1Score++;
			p1ScoreText.text = p1Score.ToString();
		}
	}
}
