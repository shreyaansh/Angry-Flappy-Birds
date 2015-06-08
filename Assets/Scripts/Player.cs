using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	public Vector2 jumpForce = new Vector2(0, 300);
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")) {
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
			//yield return new WaitForSeconds(1.5f);
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) {
			//yield return new WaitForSeconds (1.5f);
			Die();
		}
		//yield return new WaitForSeconds(1.5f);
	}

	IEnumerator OnCollisionEnter2D (Collision2D other) {
		yield return new WaitForSeconds(1.5f);
		Die ();
	}
	void Die () {
		Application.LoadLevel (Application.loadedLevel);
	}
}
