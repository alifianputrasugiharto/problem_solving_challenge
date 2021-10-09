using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerProb8 : MonoBehaviour
{
    #region SINGLETON
    private static GameManagerProb8 _instance;
    public static GameManagerProb8 Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameManagerProb8>();
                if (_instance == null) Debug.LogError("No Game Manager Found!!!");
            }
            return _instance;
        }
    }
    #endregion

    public int Score { get; private set; }

    [Header("Box Coin Controller")]
    public int coinSpawn;
    [SerializeField] BoxCoinProb8 boxCoinPrefab;
    private List<BoxCoinProb8> boxCoinsPool = new List<BoxCoinProb8>();

    [Header("Game area constraint")]
    public float areaConstraintValue = 5f;

    [Header("UI")]
    public Text scoreText;

    private void Start()
    {
        for (int i = 0; i < coinSpawn; i++)
        {
            BoxCoinProb8 coin = GetBox();
            coin.Spawn();
        }
        scoreText.text = $"Score\n{Score}";
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


    public void RespawnBox() => StartCoroutine(ReSpawnBox());
    IEnumerator ReSpawnBox()
    {
        yield return new WaitForSeconds(3);
        BoxCoinProb8 coin = GetBox();
        coin.Spawn();
    }

    public BoxCoinProb8 GetBox()
    {
        for (int i = 0; i < boxCoinsPool.Count; i++)
        {
            if (!boxCoinsPool[i].gameObject.activeSelf)
            {
                boxCoinsPool[i].gameObject.SetActive(true);
                return boxCoinsPool[i];
            }
        }

        BoxCoinProb8 boxObject = Instantiate(boxCoinPrefab, transform);
        boxCoinsPool.Add(boxObject);
        return boxObject;
    }
}
