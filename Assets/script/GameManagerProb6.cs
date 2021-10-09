using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerProb6 : MonoBehaviour
{
    public GameObject boxPf;
    public int jumlahBox;
    public float areaConstraintValue;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < jumlahBox; i++)
        {
            GameObject box = Instantiate(boxPf, GetRandomPosition(), Quaternion.identity);
            box.transform.localScale = GetRandomScale();
            box.SetActive(true);
        }
    }

    public Vector2 GetRandomScale()
    {
        float xScale = Random.Range(10f, 10f);
        float yScale = Random.Range(10f, 10f);
        return new Vector2(xScale, yScale);
    }

    public Vector2 GetRandomPosition()
    {
        float xPosition = Random.Range(-areaConstraintValue, areaConstraintValue);
        float yPosition = Random.Range(-areaConstraintValue, areaConstraintValue);

        return new Vector2(xPosition, yPosition);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
