using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region SINGLETON
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if (_instance == null) Debug.LogError("Tidak ditemukan game manager");
            }
            return _instance;
        }
    }
    #endregion
    public GameObject boxPf;
    public int jumlahBox;
    public float areaConstraintValue;

    public int Score { get; private set; }

    
    
    [Header("UI")]
    public Text scoreText;

    private void Start()
    {
        for (int i = 0; i < jumlahBox; i++)
        {
            GameObject box = Instantiate(boxPf, GetRandomPosition(), Quaternion.identity);
            box.transform.localScale = GetRandomScale();
            box.SetActive(true);
        }
        scoreText.text = $"Score\n{Score}";
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

    public void AddScore()
    {
        Score++;
        scoreText.text = $"Score\n{Score}";
    }

   
}

