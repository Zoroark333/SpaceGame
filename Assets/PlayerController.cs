using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float YSpeedForward;
	public float YSpeedBackward;
	public float XSpeedRight;
	public float XSpeedLeft;
	public float RotationSpeed;
	public Rigidbody2D shipMovement;

	// Use this for initialization
	void Start () {
		shipMovement = GetComponent<Rigidbody2D>();
		YSpeedForward = 3;
		YSpeedBackward = -2;
		XSpeedRight = 0.5F;
		XSpeedLeft = -0.5F;
		RotationSpeed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 YMovement = new Vector2(0.0F, 1.0F);
		Vector2 XMovement = new Vector2(1.0F, 0.0F);

		//Forward and back control and stopping
		if (Input.GetKey (KeyCode.W)) {
			shipMovement.AddRelativeForce (YMovement * YSpeedForward);
		} else if (Input.GetKey (KeyCode.S)) {
			shipMovement.AddRelativeForce (YMovement * YSpeedBackward);
		} else if (shipMovement.velocity.y > 0.0F) {
			shipMovement.AddRelativeForce (YMovement * YSpeedBackward);
		} else if (shipMovement.velocity.y < 0.0F) {
			shipMovement.AddRelativeForce (YMovement * YSpeedForward);
		}

		//Side to Side control and stopping
		if (Input.GetKey (KeyCode.Q)) {
			shipMovement.AddRelativeForce (XMovement * XSpeedLeft);
		} else if (Input.GetKey (KeyCode.E)) {
			shipMovement.AddRelativeForce (XMovement * XSpeedRight);
		} else if (shipMovement.velocity.x > 0.0F) {
			shipMovement.AddRelativeForce (XMovement * XSpeedLeft);
		} else if (shipMovement.velocity.x < 0.0F) {
			shipMovement.AddRelativeForce (XMovement * XSpeedRight);
		}

		//Rotational Control and stopping
		if (Input.GetKey (KeyCode.A)) {
			shipMovement.AddTorque (RotationSpeed);
		} else if (Input.GetKey (KeyCode.D)) {
			shipMovement.AddTorque (-RotationSpeed);
		} else if (shipMovement.angularVelocity > 0.0F) {
			shipMovement.AddTorque (-RotationSpeed);
		} else if (shipMovement.angularVelocity < 0.0F) {
			shipMovement.AddTorque (RotationSpeed);
		}
	}
}