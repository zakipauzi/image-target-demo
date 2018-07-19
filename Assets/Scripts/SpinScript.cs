using UnityEngine;

public class SpinScript : MonoBehaviour {

    public float speed = 10f;
	
	// Since we want the ball to continue spinning, we will implement the rotation vector in update method, so every frame is updated.

	void Update () {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

}
