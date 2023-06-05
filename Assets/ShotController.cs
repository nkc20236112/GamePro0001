using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float speed;//�e�̃X�s�[�h

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // �V�[����̃I�u�W�F�N�g�ƐڐG�����Ƃ��̏���
    private void OnTriggerEnter2D(Collider2D col)
    {
        // �G��������
        if (col.gameObject.tag == "Enemy")
        {
            // �Ԃ����������j��
            Destroy(col.gameObject);

            // �e��j��
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;//������E�ɒe���ړ�

        //��ʉE���ɏ�������e���폜
        if (transform.position.x >= 10f)
        {
            Destroy(gameObject);
        }
    }
}
