using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public Herodate data;
    /// <summary>
    /// 動畫控制器
    /// </summary>
    private Animator ani;
    /// <summary>
    /// 技能計時器：累加時間用
    /// </summary>
    private float[] skillTimer = new float[4];
    /// <summary>
    /// 技能是否開始
    /// </summary>
    private bool[] skillStart = new bool[4];

    // protected 保護 - 允許子類別存取
    // virtual 虛擬 - 允許子類別複寫
    protected virtual void Awake()
    {
        ani = GetComponent<Animator>();
    }
    public void Move()
    {
        
    }
    public void Skill1()
    {
        if (skillStart[0]) return;
        ani.SetTrigger("第一招");
        skillStart[0] = true;
    }

    public void Skill2()
    {
        if (skillStart[1]) return;
        ani.SetTrigger("第二招");
        skillStart[1] = true;
    }

    public void Skill3()
    {
        if (skillStart[2]) return;
        ani.SetTrigger("第三招");
        skillStart[2] = true;
    }

    public void Skill4()
    {
        if (skillStart[3]) return;
        ani.SetTrigger("大絕");
        skillStart[3] = true;
    }
}
