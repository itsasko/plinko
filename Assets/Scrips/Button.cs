using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject ball;
    public Sprite asset;

    public void ButttonPressed()
    {
        float randomFloat = Random.Range(-0.45f, 0.45f);
        Vector3 position = new Vector3(randomFloat, 3.7f, 0);
        GameObject targetInstance = Instantiate(ball, position, Quaternion.identity);
        targetInstance.GetComponent<SpriteRenderer>().sprite = asset;
    }
}
