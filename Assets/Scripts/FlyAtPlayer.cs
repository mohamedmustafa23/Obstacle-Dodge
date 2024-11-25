using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform Player;
    Vector3 PlayerPostion;
    [SerializeField] float Speed = 0.05f;
    void Start()
    {
        PlayerPostion = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        if (transform.position == PlayerPostion)
        {
            DestroyWhenReached();
        }
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, PlayerPostion, Time.deltaTime * Speed);
    }
    void DestroyWhenReached()
    {
        Destroy(gameObject);
    }
}
