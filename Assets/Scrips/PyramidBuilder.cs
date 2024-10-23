using UnityEngine;

public class PyramidBuilder : MonoBehaviour
{
    public GameObject pyramidPrefab;
    public int rows = 14;
    public float space = 0.5f;
    private int numberOfComponents = 2;
    void Start()
    {
        BuildPyramid();
    }
    void Update()
    {

    }
    void BuildPyramid()
    {
        Vector3 position;
        float x0 = 0f;
        float y0 = 3.0f;
        for (int row = 0; row < rows; row++)
        {
            numberOfComponents += 1;
            if (row%2 == 0)
            {
                {
                    x0 = 0;
                    position = new Vector3(x0, y0, 0);
                    Instantiate(pyramidPrefab, position, Quaternion.identity);
                }
                for (int i = 0; i < numberOfComponents / 2; i++)
                {
                    x0 += space;
                    position = new Vector3(x0, y0, 0);
                    Instantiate(pyramidPrefab, position, Quaternion.identity);

                }
                x0 = 0;
                for (int j = 0; j < numberOfComponents / 2; j++)
                {
                    x0 -= space;
                    position = new Vector3(x0, y0, 0);
                    Instantiate(pyramidPrefab, position, Quaternion.identity);
                }
            }
            else
            {
                for (int i = 0; i < numberOfComponents / 2; i++)
                {
                    if (i == 0) x0 = space / 2;
                    else x0 += space;
                    position = new Vector3(x0, y0, 0);
                    Instantiate(pyramidPrefab, position, Quaternion.identity);

                }
                for (int j = 0; j < numberOfComponents / 2; j++)
                {
                    if (j == 0) x0 = -(space / 2);
                    else x0 -= space;
                    position = new Vector3(x0, y0, 0);
                    Instantiate(pyramidPrefab, position, Quaternion.identity);
                }
            }
            y0 -= space;

        }
    }
    
}

