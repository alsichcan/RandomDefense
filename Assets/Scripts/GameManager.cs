using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver;

    public static string GameMode;
    public string defaultGameMode = "Extreme";

    [Header("Round")]
    // 현재 라운드
    public static int Rounds;

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

    [Header("Boss")]
    // 보스 생존 여부
    public static bool isBossAlive;

    // 보스 현재 체력
    public static float BossHealthPoint;

    // 보스 최대 체력
    public static float BossMaxHealthPoint;

    private void Awake()
    {
        Screen.SetResolution(Screen.width, Screen.width * 9 / 16, true);
    }

    private void Start()
    {
        isGameOver = false;
        GameMode = defaultGameMode;
        isBossAlive = false;
        
        Rounds = 0;
        prepareTime = defaultPrepareTime;
        roundTime = defaultRoundTime;
        currentTime = defaultPrepareTime;

        EnemyPerRound = defaultEnemyPerRound;
        EnemyCount = 0;
        MaxEnemyCount = defaultMaxEnemyCount;
    }

    private void Update()
    {         
        // TODO : Implement GameOver() and GameClear()
    }
}