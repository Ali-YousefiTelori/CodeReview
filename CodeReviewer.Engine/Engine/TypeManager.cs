﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CodeReviewer.Engine
{
    /// <summary>
    /// manage types at runtime
    /// </summary>
    public static class TypeManager
    {
        /// <summary>
        /// get list of methods of type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static List<MethodInfo> GetPublicMethods(this Type type)
        {
            return type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                .Where(x => !x.IsSpecialName).ToList();
        }

        /// <summary>
        /// get list of public properties
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static List<PropertyInfo> GetPublicProperties(this Type type)
        {
            return type.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance).ToList();
        }
    }
}
