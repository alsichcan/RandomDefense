using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static string GameMode;
    public string defaultGameMode = "Extreme";

    private bool isGameClear;
    private bool isGameOver;
    public static bool isBossAlive;

    [Header("Round")]
    // 현재 라운드
    public static int Rounds;

    // 최대 라운드
    public static int totalRounds;
    public int defaultTotalRounds;

    // 현재 시간
    public static float currentTime;


    // 라운드 시작 전 준비 시간
    public static float prepareTime;
    public float defaultPrepareTime = 2f;

    // 1 라운드 당 시간
    public static float roundTime;
    public float defaultRoundTime = 61f;

    [Header("Enemy")]
    // 1 라운드 당 Enemy 수
    public static int EnemyPerRound;
    public int defaultEnemyPerRound = 40;

    // 현재 Enemy 수
    public static int EnemyCount;

    // 최대 Enemy 수 (GameOver 기준)
    public static int MaxEnemyCount;
    public int defaultMaxEnemyCount = 100;

    private void Awake()
    {
        Screen.SetResolution(Screen.width, Screen.width * 9 / 16, true);
    }

    private void Start()
    {
        GameMode = defaultGameMode;
        isGameClear = false;
        isGameOver = false;
        isBossAlive = false;
        
        Rounds = 0;
        totalRounds = defaultTotalRounds;

        prepareTime = defaultPrepareTime;
        roundTime = defaultRoundTime;
        currentTime = defaultPrepareTime;

        EnemyPerRound = defaultEnemyPerRound;
        EnemyCount = 0;
        MaxEnemyCount = defaultMaxEnemyCount;
    }

    private void Update()
    {
        if (isGameOver || isGameClear)
            return;

        GameClear();
        GameOver();
    }

    void GameClear()
    {
        // 최종 Round(85Round)에 다다르고 모든 적을 섬멸하였을 때,
        // 보스는 이미 1 Round 전까지 잡아야함
        if(Rounds == totalRounds && EnemyCount == 0 && isBossAlive)
        {
            isGameClear = true;
            Debug.Log("GameClear");

            // TODO: gameClearUI.SetActive(true);
        }
    }

    void GameOver()
    {
        // 적의 수가 100명이 되거나
        // 정해진 Round안에 보스를 잡지 못하였을 때
        if (EnemyCount >= 100 || (Rounds % 10 == 5 && isBossAlive))
        {
            isGameOver = true;
            Debug.Log("GameOver");

            // TODO : gameOverUI.SetActive(true);
        }
    }




}