using UnityEngine;

public class HorrorObject : MonoBehaviour
{

    private Rigidbody rig;

   /* private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        rig.useGravity = false; //取消地心引力
        rig.constraints = RigidbodyConstraints.FreezeAll;//全部凍結
    }*/


    public virtual void TriggerEvent()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "玩家") TriggerEvent();

    }

}
