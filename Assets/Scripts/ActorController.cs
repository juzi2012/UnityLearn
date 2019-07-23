using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour {
    public GameObject model;
    public PlayerInput pi;
    public Rigidbody rigid;
    public float walkspeed = 1.4f;
    public float runningspeed = 2.5f;
    public bool LockPlanar = false;

    public float JumpVelocity = 5.0f;

    [SerializeField]
    private Animator anim;
    private Vector3 movingVec;
    private Vector3 jumpVec;
    // Use this for initialization
    void Awake () {
        pi = GetComponent<PlayerInput>();
        anim = model.GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        float targetMoveMulti = (pi.run ? 2.0f : 1.0f);
        anim.SetFloat("forward", pi.Dmag * Mathf.Lerp(anim.GetFloat("forward"), targetMoveMulti, 0.5f));
        if (pi.jump)
        {
            anim.SetTrigger("jump");
        }
        if (pi.Dmag>0.1f)
        {
            Vector3 targetForward = Vector3.Lerp(model.transform.forward, pi.Dvec, 0.5f);
            model.transform.forward = targetForward;
        }
        if (LockPlanar==false) // 跳跃的时候，速度会停止，所以这里屏蔽调
        {
            float targetRunningSpeedMuti = (pi.run ? runningspeed : 1.0f);
            movingVec = pi.Dmag * model.transform.forward * walkspeed * targetRunningSpeedMuti;
        }

    }
    void FixedUpdate()
    {
        //rigid.position += movingVec * Time.fixedDeltaTime;
        //上面和下面的俩个方式都可以，但是要注意用下面的时候，y的值需要特殊处理。
        rigid.velocity = new Vector3(movingVec.x,rigid.velocity.y,movingVec.z)+ jumpVec;
        jumpVec = new Vector3(0, 0, 0);
    }
    
    public void OnJump()
    {
        LockPlanar = true;
        jumpVec = new Vector3(0, JumpVelocity, 0);
        pi.InputEnable = false;
    }
    public void OnJumpExit()
    {
        LockPlanar = false;
        pi.InputEnable = true;
    }
}
