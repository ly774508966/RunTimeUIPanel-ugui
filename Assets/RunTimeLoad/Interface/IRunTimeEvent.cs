﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


public interface IRunTimeEvent {
    event UnityAction OnDelete;
    void OnCreate();
}