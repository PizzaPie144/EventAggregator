﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PizzaPie.EventAggregator
{
    public interface ISubscriber<in TEventArgs> where TEventArgs : EventArgs
    {
        void Handler(object sender, TEventArgs e);
    }
}
