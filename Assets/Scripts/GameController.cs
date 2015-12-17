using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public UnityEngine.UI.Text scoreLabel;
    public GameObject winnerLabelObject;
    public void Start()
    {
        Input.gyro.enabled = true;
    }
    public void Update()
    {
        Vector3 g = Input.gyro.gravity;
        Physics.gravity = new Vector3(g.x, g.z, g.y) * 9.81f;
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        if (count == 0)
        {
            scoreLabel.gameObject.SetActive(false);
            winnerLabelObject.SetActive(true);
        } else
        {
            scoreLabel.text = Input.gyro.gravity.ToString();
            //scoreLabel.text = Input.gyro.rotationRate.ToString();
            //            scoreLabel.text = count.ToString();
        }
    }
}
