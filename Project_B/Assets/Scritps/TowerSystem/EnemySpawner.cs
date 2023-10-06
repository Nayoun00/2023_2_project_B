using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyController[] enemiesToSpawn;        //�� ���� �迭
    public Transform spawnPoint;        //���� ��ġ ����
    public float timeBetweenSpawns = 0.5f;      //���� <- �ð� -> ����
    public float spawnCounter;                  //�ð��� �帣���ؼ� �����Ǵ� �ð� ����
    public int amountToSpawn = 15;              //���� �׷� ����

    // Start is called before the first frame update
    void Start()
    {
        spawnCounter = timeBetweenSpawns;       //Counter�� �ð��� �Է�
    }

    // Update is called once per frame
    void Update()
    {
        if(amountToSpawn > 0)       //��ȯ�� ���� ������ ����������
        {
            spawnCounter -= Time.deltaTime;     //timeBetwwnSpawn������ �ð����� -> 0.0�ʷ� ����.
            if(spawnCounter <= 0)
            {
                spawnCounter = timeBetweenSpawns; //0.0�� ������ ī���Ϳ� �ٽ� ������ �ð��� �Է��Ѵ�.
                //enemisToSpawn �迭���� ���������� ���� ����
                Instantiate(enemiesToSpawn[Random.RandomRange(0, enemiesToSpawn.Length)], spawnPoint.position, spawnPoint.rotation);
                amountToSpawn -= 1;         //��ȯ�Ŀ� ���ڸ� 1 ���ش�.
            }
        }
    }
}