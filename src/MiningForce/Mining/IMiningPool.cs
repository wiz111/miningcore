﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MiningForce.Blockchain;
using MiningForce.Configuration;

namespace MiningForce.Mining
{
    public interface IMiningPool
    {
	    void Configure(PoolConfig poolConfig, ClusterConfig clusterConfig);
	    Task StartAsync();
	    IObservable<IShare> Shares { get; }
    }
}
