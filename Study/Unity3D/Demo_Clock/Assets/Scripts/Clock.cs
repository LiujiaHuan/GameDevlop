using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Clock : MonoBehaviour
{
    const float hoursToDegrees = 30f, minutesToDegrees = 6f, secondsToDegrees = 6f;
    [SerializeField]    //Unity保存场景时 把所有数据序列化写入
    //可以使用public 但是 经验法则是仅在其他类型的C＃代码需要访问类内容时才公开类内容，然后优先于字段使用方法或属性。
    //越难访问的东西越容易维护，因为可以直接依赖它的代码更少。
    //在本教程中，我们唯一的C＃代码是Clock，因此没有理由公开其内容。
    Transform hourPivot = default, minutesPivot, secondPivot;
    void Update()
    {   //特殊Unity事件方法

        var time = DateTime.Now;
        //变量的作用类似于字段，只是它仅在执行方法时存在。它属于方法，而不是类。

        //如果是变量，则可以省略类型声明，而用var关键字替换。
        //这样可以缩短代码，但只有在声明变量时可以从分配给变量的类型中推断出变量的类型时才有可能。
        hourPivot.localRotation =
            Quaternion.Euler(hoursToDegrees * time.Hour, 0f, 0f);
        minutesPivot.localRotation =
            Quaternion.Euler(minutesToDegrees * time.Minute, 0f, 0f);
        secondPivot.localRotation =
            Quaternion.Euler(secondsToDegrees * time.Second, 0f, 0f);
        //表示由Transform组件描述的旋转，因此是相对于其父级的旋转
        //调用Quaternion.Euler方法基于欧拉角创建四元数

    }
}
