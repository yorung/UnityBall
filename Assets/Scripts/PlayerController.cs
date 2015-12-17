using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    /*
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    */
    public float speed = 10;
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
     //   Vector3 gyro = Input.gyro.rotationRate;
     //   Vector3 gyro2 = Input.gyro.gravity;
     //   x += gyro2.x;
     //   z += gyro2.y;
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(x * speed, 0, z * speed);

        if (rigidbody.position.magnitude > 50)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
