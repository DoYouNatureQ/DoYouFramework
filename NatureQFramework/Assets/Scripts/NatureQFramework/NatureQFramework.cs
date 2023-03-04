/***************
Copyright(c) 2023-now NatureQ MIT License

NatureFramework V0.1

***************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NatureQFramework
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

    public interface ISend
    {
        void SendCommand<T>() where T : class;
    }

}
