using UnityEngine;
using System.Collections;

public class DangerWall : MonoBehaviour {

	// Use this for initialization
//	void Start () {
	
//	}
	
	// Update is called once per frame
//	void Update () {
	
//	}

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel(Application.loadedLevel);
        } else
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
