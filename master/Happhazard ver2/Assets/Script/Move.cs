using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

 
public class Move : MonoBehaviour
{
    private Vector3 targetPosition; //移動する位置
    private NavMeshAgent agent;
    private Animator animator;
    private RaycastHit hit;
    private Ray ray;

    private const string flg_isRight = "is_Right";
    private const string flg_isLeft = "is_Left";
    private const string flg_isWait = "is_Wait";
    private const string flg_isBefor = "is_Befor";
    private const string flg_isAfter = "is_After";


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();//後から変更
        this.animator.SetBool(flg_isWait, false);
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
                    this.animator.SetBool(flg_isRight, false);
                    this.animator.SetBool(flg_isLeft, true);
                    this.animator.SetBool(flg_isWait, false);
                    this.animator.SetBool(flg_isBefor, false);
                    this.animator.SetBool(flg_isAfter, false);
                }
                else
                {
                    this.animator.SetBool(flg_isLeft, false);
                }

                if (transform.position.x < targetPosition.x)
                {
                    animator.SetFloat("speed", agent.velocity.magnitude);
                    this.animator.SetBool(flg_isRight, true);
                    this.animator.SetBool(flg_isWait, false);
                    this.animator.SetBool(flg_isBefor, false);
                    this.animator.SetBool(flg_isAfter, false);
                    this.animator.SetBool(flg_isLeft, false);

                }
                else
                {
                    this.animator.SetBool(flg_isRight, false);
                }

                if (transform.position.z > targetPosition.z)
                {
                    animator.SetFloat("speed", agent.velocity.magnitude);
                    this.animator.SetBool(flg_isBefor, true);
                    this.animator.SetBool(flg_isAfter, false);
                    this.animator.SetBool(flg_isRight, false);
                    this.animator.SetBool(flg_isLeft, false);
                    this.animator.SetBool(flg_isWait, false);
                }
                else
                {
                    this.animator.SetBool(flg_isBefor, false);
                }

                if (transform.position.z < targetPosition.z)
                {
                    animator.SetFloat("speed", agent.velocity.magnitude);
                    this.animator.SetBool(flg_isBefor, false);
                    this.animator.SetBool(flg_isAfter, true);
                    this.animator.SetBool(flg_isRight, false);
                    this.animator.SetBool(flg_isLeft, false);
                    this.animator.SetBool(flg_isWait, false);
                }
                else
                {
                    this.animator.SetBool(flg_isAfter, false);
                }

            }

            if(transform.position == targetPosition)
            {
                this.animator.SetBool(flg_isWait, true);
                this.animator.SetBool(flg_isRight, false);
                this.animator.SetBool(flg_isLeft, false);
                this.animator.SetBool(flg_isBefor, false);
                this.animator.SetBool(flg_isAfter, false);
            }
            else
            {
                agent.SetDestination(targetPosition); //移動させる処理
            }
        }
    }
}