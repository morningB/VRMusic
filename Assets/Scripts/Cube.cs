using UnityEngine;

public class Cube : MonoBehaviour
{

    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2; // ť�갡 �̵��ǰ� ��
    }
}
