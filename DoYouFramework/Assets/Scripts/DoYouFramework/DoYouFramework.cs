using System.Runtime.InteropServices;
using System;
/***************
Copyright(c) 2023-now NatureQ MIT License

DoYouFramework V0.1

***************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DoYouFramework
{
    /// <summary>
    /// 泛型单例
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T> where T : class, new()
    {
        private static T m_Instance;

        public static T GetInstance()
        {
            if (m_Instance == null)
            {
                m_Instance = new T();
            }
            return m_Instance;
        }
    }

    /// <summary>
    /// 统一延迟调用方法
    /// </summary>
    public class CallMethod
    {
        public delegate void CallEvents();
        public void Invoke(CallEvents callEvents, float _time)
        {
            MonoSub.instance.StartCoroutine(WaitCall(callEvents, _time));
        }

        public IEnumerator WaitCall(CallEvents callEvents, float _time)
        {
            yield return new WaitForSeconds(_time);

            callEvents?.Invoke();
        }
    }

    public interface ISend
    {
        void SendCommand<T>() where T : class;

        T GetModel<T>();
    }
}
