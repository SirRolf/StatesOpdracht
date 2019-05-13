using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Vector2 move;
    private bool isChanging = true;
    private bool isMoving = true;

    void Start()
    {
        InvokeRepeating("SetRandomPos", 0, 1);
        var player = GameObject.Find("Player");
        player.transform.GetChild(0).GetComponent<Detect>().Detected += DetectionReaction;
        player.transform.GetChild(1).GetComponent<Attack>().Attacking += AttackReaction;
    }

    void DetectionReaction(bool isInRange)
    {
        if (isInRange)
        {
            isChanging = false;
            move = GameObject.Find("Player").transform.position;
            Debug.Log("Im gonna beat this &@*%");
        }
        else
        {
            isChanging = true;
            Debug.Log("what where is he");
        }
    }

    void AttackReaction(bool isInRange)
    {
        if (isInRange)
        {
            isMoving = false;
            Debug.Log("Im Punch this &@*%");
        }
        else
        {
            isMoving = true;
            Debug.Log("GET BACK HERE YOU LITTLE &@*%");
        }
    }

    void Update()
    {
        if (isMoving == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, move, Time.deltaTime*4);
        }
        if (isChanging == false)
        {
            move = GameObject.Find("Player").transform.position;
        }
    }

    void SetRandomPos()
    {
        if (isChanging == true)
        {
            move = new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
        }
    }
    
}
