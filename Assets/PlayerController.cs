using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float YSpeed;
	public float RotationSpeed;
	public Rigidbody2D shipMovement;

	// Use this for initialization
	void Start () {
		shipMovement = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float moveY = Input.GetAxis("Vertical");
		float moveRotation = Input.GetAxis("Horizontal");

		Vector2 YMovement = new Vector2(0.0F, moveY);

		shipMovement.AddForce(YMovement * YSpeed);
		shipMovement.AddTorque(moveRotation * RotationSpeed);
	}
}