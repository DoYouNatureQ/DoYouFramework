using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeStyle
{
    delegate void oneD();//委托，添加D后缀
    public int jumpValue;//公有变量名，使用小驼峰命名

    private string m_NameStr;//私有变量名，变量名前加一个m_,使用大驼峰命名

    protected float m_moveSpeed;//私有受保护变量名，变量名前加一个m_,使用小驼峰命名

    bool isCanMove;//bool变量，变量名前面加一个is，使用小驼峰命名

    List<string> strList;//List列表，添加List后缀
    Dictionary<string, int> intDic;//字典Dictionary,添加Dic后缀

    /// <summary>
    /// 函数方法，首字母大写
    /// </summary>
    public void Movement()
    {

    }
}

/// <summary>
/// 接口的定义
/// 
/// 接口使用大驼峰命名
/// /// </summary>
interface Interface
{
    /// <summary>
    /// 方法名前加上大写I，方法使用大驼峰命名
    /// </summary>
    public abstract void IChangedHp();
}
