using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody rb;           //���� ��ü ����

    public float moveSpeed;         //�̵� �ӵ�
    public float damagedAmount;     //������ ��
    private bool hasDamaged;        //������ �˻�

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();     //�����ҋ� ��ü�� �����´�.
        rb.velocity = transform.forward * moveSpeed;        //�����Ҷ� �ش� ��ü ���� �������� MoveSpeed ��ŭ�� �ӵ��� �Է�
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" && !hasDamaged)
        {
            hasDamaged = true;
        }

        Destroy(gameObject);            //�⵹�� �Ͼ ��� �ı�
    }

}
