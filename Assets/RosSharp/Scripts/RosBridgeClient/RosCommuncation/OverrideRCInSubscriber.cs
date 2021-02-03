﻿/*
© Siemens AG, 2017-2018
Author: Dr. Martin Bischoff (martin.bischoff@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using UnityEngine;
namespace RosSharp.RosBridgeClient
{
    public class OverrideRCInSubscriber : Subscriber<MessageTypes.Mavros.OverrideRcIn>
    {
        //public OverrideChannelsWriter[] channelWriters;
       

		protected override void Start()
		{
			base.Start();
		}
		
        protected override void ReceiveMessage(MessageTypes.Mavros.OverrideRcIn orc)
        {
            int idx;
            for (idx=0; idx<8; idx++)
            {
                Debug.Log("channel[" + idx.ToString() + "]=" + orc.channels[idx].ToString());
            }
            /***
            int I = channelWriters.Length < orc.channels.Length ? channelWriters.Length : orc.channels.Length;
            for (int i = 0; i < I; i++)
                if (channelWriters[i] != null)
                    channelWriters[i].Write(orc.channels[i]); **/

            
        }
    }
}
