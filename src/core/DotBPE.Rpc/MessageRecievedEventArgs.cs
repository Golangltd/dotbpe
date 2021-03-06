﻿using DotBPE.Rpc.Codes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotBPE.Rpc
{
    public class MessageRecievedEventArgs<TMessage> where TMessage : InvokeMessage
    {
        public MessageRecievedEventArgs()
        {

        }
        public MessageRecievedEventArgs(IRpcContext<TMessage> context, TMessage message)
        {

            this.Context = context;
            this.Message = message;
        }

        public IRpcContext<TMessage> Context { get; set; }
        public TMessage Message { get; set; }

    }
}
