﻿/*
 * MIT License
 *  Copyright (c) 2018 SPARKCREATIVE
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
 *  The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 *  
 *  @author Noriyuki Hiromoto <hrmtnryk@sparkfx.jp>
*/

using UnityEngine;

public class SPCRJointDynamicsPointGrabber : MonoBehaviour
{
    [SerializeField]
    bool _IsEnabled = true;
    [SerializeField, Range(0.0f, 5.0f)]
    float _Radius = 0.05f;
    [SerializeField, Range(0.0f, 1.0f)]
    float _Force = 0.5f;

    public Transform RefTransform { get; private set; }
    public bool IsEnabled { get { return enabled && _IsEnabled; } set { _IsEnabled = value; } }
    public float Radius { get { return _Radius; } set { _Radius = value; } }
    public float Force { get { return _Force; } set { _Force = value; } }

    void Awake()
    {
        RefTransform = transform;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, _Radius);
    }
}
