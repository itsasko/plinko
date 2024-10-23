using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TargetBehaviour : MonoBehaviour
{
    public GameObject targetPrefab;
    public Sprite green_targ;
    public Sprite cyan_targ;
    public Sprite blue_targ;
    void Start()
    {
        BuildTargets();
    }
    void Update()
    {
        
    }
    void BuildTargets()
    {
        float x0 = -2.75f, y0 = -1.27f;
        float space = 0.5f;
        Vector3 position;
        Sprite target = green_targ;
        for (int i = 0; i < 12; i++)
        {
            if (i == 4) target = cyan_targ;
            if (i == 8) target = blue_targ;
            position = new Vector3(x0, y0, 0);
            GameObject targetInstance = Instantiate(targetPrefab, position, Quaternion.identity);
            targetInstance.GetComponent<SpriteRenderer>().sprite = target;
            x0 += space;
        }   
    }
}
