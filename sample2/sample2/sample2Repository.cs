﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace sample2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the sample2Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("5015fa77-4070-4081-a201-1607cd7fde41")]
    public partial class sample2Repository : RepoGenBaseFolder
    {
        static sample2Repository instance = new sample2Repository();

        /// <summary>
        /// Gets the singleton class instance representing the sample2Repository element repository.
        /// </summary>
        [RepositoryFolder("5015fa77-4070-4081-a201-1607cd7fde41")]
        public static sample2Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public sample2Repository() 
            : base("sample2Repository", "/", null, 0, false, "5015fa77-4070-4081-a201-1607cd7fde41", ".\\RepositoryImages\\sample2Repository5015fa77.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("5015fa77-4070-4081-a201-1607cd7fde41")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class sample2RepositoryFolders
    {
    }
#pragma warning restore 0436
}
