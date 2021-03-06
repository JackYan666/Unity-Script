﻿using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 单例模板
/// </summary>
/// <typeparam name="T"></typeparam>
public class SingleObject<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SingleObject<T>>() as T;
            }
            return instance;
        }
    }
}
/// <summary>
/// 单例类 不继承MonoBehaviour
/// </summary>
/// <typeparam name="T"></typeparam>
public class SingleClass<T> where T : class, new()
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }
            return instance;
        }
    }
}
