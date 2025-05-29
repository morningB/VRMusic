using UnityEngine;

public class Cube : MonoBehaviour
{

    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2; // 큐브가 이동되게 함
    }
}
