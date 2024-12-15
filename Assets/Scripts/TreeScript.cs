using UnityEngine;

public class TreeScript : MonoBehaviour
{
	private float speed = 1.0f;
	void Start()
	{

	}

	void Update()
	{
		this.transform.Translate(Vector2.left * Time.deltaTime * speed);
	}
}
