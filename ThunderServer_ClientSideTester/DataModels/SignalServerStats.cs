﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderServer_ClientSideTester.DataModels
{
    /// <summary>
    /// Сигнальный сервер.
    /// Единственный в сети.
    /// Управляет подключением/отключением серверов.
    /// </summary>
    public class SignalServerStats : NetNode
    {
        public string name;
        public string ip;
        public string port;
    }
}