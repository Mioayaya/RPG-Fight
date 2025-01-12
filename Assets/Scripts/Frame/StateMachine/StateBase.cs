using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 状态基类
/// </summary>
public abstract class StateBase
{
    /// <summary>
    /// 初始化
    /// 只在状态第一次创建的时候调用
    /// </summary>
    /// <param name="owner">宿主</param>
    /// <param name="stateType">当前这个状态代表的实际枚举的int值</param>
    public virtual void Init(IStateMachineOwner owner,int stateType)
    {

    }
    /// <summary>
    /// 反初始化，销毁时，释放一些资源
    /// </summary>
    public virtual void Uninit() { }
    /// <summary>
    /// 状态每次进入都执行一次
    /// </summary>
    public virtual void Enter() { }
    /// <summary>
    /// 状态退出
    /// </summary>
    public virtual void Exit() { }
    public virtual void Update() { }
    public virtual void LateUpdate() { }
    public virtual void FixedUpdate() { }
}
