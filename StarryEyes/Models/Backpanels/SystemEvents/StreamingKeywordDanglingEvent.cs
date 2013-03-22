﻿
namespace StarryEyes.Models.Backpanels.SystemEvents
{
    public sealed class StreamingKeywordDanglingEvent : SystemEventBase
    {
        public override SystemEventKind Kind
        {
            get { return SystemEventKind.Error; }
        }

        public override string Detail
        {
            get { return "trackキーワードが多すぎるため、受信されないキーワードがあります。"; }
        }

        public override string Id
        {
            get { return "CONMNGR_TRACK_DANGLING"; }
        }
    }
}