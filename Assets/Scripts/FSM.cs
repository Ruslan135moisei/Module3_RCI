using UnityEngine;

public class FSM : MonoBehaviour
{
    public enum State { Idle, Chase }
    public State currentState = State.Idle;

    public Transform player;
    public float speed = 2f;
    public float chaseDistance = 5f;

    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.position);

        switch (currentState)
        {
            case State.Idle:
                if (dist < chaseDistance) currentState = State.Chase;
                break;

            case State.Chase:
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    player.position,
                    speed * Time.deltaTime
                );

                if (dist > chaseDistance) currentState = State.Idle;
                break;
        }
    }
}