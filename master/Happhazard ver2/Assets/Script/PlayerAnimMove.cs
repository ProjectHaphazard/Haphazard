using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

 
public class PlayerAnimMove : MonoBehaviour
{
    private Vector3 targetPosition; //移動する位置
    private NavMeshAgent agent;
    private Animator animator;
    private RaycastHit hit;
    private Ray ray;

    private const string Trigger_isRight = "is_Right";
    private const string Trigger_isLeft = "is_Left";
    private const string Trigger_isWait = "is_Wait";
    private const string Trigger_isBefor = "is_Befor";
    private const string Trigger_isAfter = "is_After";


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();//後から変更
        this.animator.SetTrigger(Trigger_isWait);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                targetPosition = hit.point;
                //agent.SetDestination(targetPosition); //移動させる処理

                if (transform.position.x > targetPosition.x) //プレイヤーの位置よりもクリック位置が左のときに実行
                {
                    animator.SetFloat("speed", agent.velocity.magnitude);
                    this.animator.SetTrigger(Trigger_isLeft);
                }
                
                if (transform.position.x < targetPosition.x)　//プレイヤーの位置よりもクリック位置が右のときに実行
                {
                    animator.SetFloat("speed", agent.velocity.magnitude);
                    this.animator.SetTrigger(Trigger_isRight);
                }
             
                if (transform.position.z > targetPosition.z)　//プレイヤーの位置よりもクリック位置が奥のときに実行
                {
                    animator.SetFloat("speed", agent.velocity.magnitude);
                    this.animator.SetTrigger(Trigger_isAfter);
                }
           
                if (transform.position.z < targetPosition.z)　//プレイヤーの位置よりもクリック位置が手前のときに実行
                {
                    animator.SetFloat("speed", agent.velocity.magnitude);
                    this.animator.SetTrigger(Trigger_isBefor);
                }
               
            }

            if(transform.position == targetPosition)　//押した位置と今いる位置が同じなら実行
            {
                this.animator.SetTrigger(Trigger_isWait);
            }
            else
            {
                agent.SetDestination(targetPosition); //移動させる処理
            }
        }
    }
}