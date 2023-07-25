using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField] private SpriteRenderer sr;

	private const float FORCE = 1f;
	private Rigidbody2D rb2d;

	/// true = left foot (listen for left arrow key)
	/// false = right foot (listen for right arrow key)
	public bool pedalMode;

	// Start is called before the first frame update
	void Start() {
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update() {
		// Listen for left arrow
		if (pedalMode == true && Input.GetKeyDown(KeyCode.A)) {
			Pedal();
		}
		// Listen for right arrow
		if (pedalMode == false && Input.GetKeyDown(KeyCode.D)) {
			Pedal();
		}
		// Ternary operator:
		// If pedalMode == true, sr.color = red.
		// If pedalMode == false, sr.color = blue.
		//sr.color = pedalMode ? Color.red : Color.blue;

		// Up arrow = lean left, Down arrow = lean right
		if (Input.GetKey(KeyCode.LeftArrow)) {
			rb2d.AddTorque(100 * Time.deltaTime, ForceMode2D.Force);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			rb2d.AddTorque(-100 * Time.deltaTime, ForceMode2D.Force);
		}
	}

	private void Pedal() {
		rb2d.AddForce(Vector2.right * FORCE, ForceMode2D.Impulse);
		pedalMode = !pedalMode;
	}
}
