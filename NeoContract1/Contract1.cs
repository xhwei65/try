﻿using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;

namespace NeoContract1
{
    public class Contract1 : SmartContract
    {
        public static bool Main(string operation, object[] args)
        {
            Storage.Put("Hello", "World");
            return true;
        }
    }
}
