using UnityEngine;

[RequireComponent(typeof(EnemyStats))]
public class EnemyMovement : MonoBehaviour {

    private Transform target;
    private int wavepointIndex = 0;

    private EnemyStats enemy;

    void Start()
    {
        enemy = GetComponent<EnemyStats>();

        // 시작 시 첫번째 Waypoint를 target으로 설정한다.
        target = Waypoints.points[0];
    }

    void Update()
    {
        // 타겟 waypoint와 현재 위치 차이를 벡터값으로 계산
        Vector3 dir = target.position - transform.position;

        // 벡터값에 따라 이동
        transform.Translate(dir.normalized * enemy.unitSpeed * Time.deltaTime, Space.World);

        // 타겟 waypoint에 가까워졌을 때 새로운 waypoint를 구함
        if(Vector3.Distance(transform.position, target.position) <= 0.5f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        // 무한 순환을 하기 위해 7로 세팅
        if (wavepointIndex == 11) { wavepointIndex = 7;}
         
        // 다음 타겟 waypoint를 target으로 설정
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
}
