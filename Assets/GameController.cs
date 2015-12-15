using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public UnityEngine.UI.Text scoreLabel;
    public GameObject winnerLabelObject;
    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        if (count == 0)
        {
            scoreLabel.gameObject.SetActive(false);
            winnerLabelObject.SetActive(true);
        } else
        {
            scoreLabel.text = count.ToString();
        }
    }
}
