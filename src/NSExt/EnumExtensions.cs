﻿// @program: NSExt
// @file: EnumExtensions.cs
// @author: tao ke
// @mailto: taokeu@gmail.com
// @created: 07/26/2022 21:57

using System.ComponentModel;

namespace NSExt;

public static class EnumExtensions
{
    /// <summary>
    ///     获取枚举的description属性
    /// </summary>
    /// <param name="e">枚举对象</param>
    /// <returns>description属性</returns>
    public static string Desc(this Enum e)
    {
        var t     = e.GetType();
        var fi    = t.GetField(Enum.GetName(t, e)!);
        var attrs = (DescriptionAttribute[])fi!.GetCustomAttributes(typeof(DescriptionAttribute), false);
        return (attrs.Length != 0 ? attrs[0].Description : Enum.GetName(t, e)) ?? "";
    }
}
