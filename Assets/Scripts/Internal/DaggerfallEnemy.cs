﻿// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2018 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using UnityEngine;
using System.Collections;

namespace DaggerfallWorkshop
{
    /// <summary>
    /// Stores enemy settings for serialization and other tasks.
    /// </summary>
    public class DaggerfallEnemy : MonoBehaviour
    {
        ulong loadID = 0;
        bool questSpawn = false;

        public ulong LoadID
        {
            get { return loadID; }
            set { loadID = value; }
        }

        public bool QuestSpawn
        {
            get { return questSpawn; }
            set { questSpawn = value; }
        }
    }
}