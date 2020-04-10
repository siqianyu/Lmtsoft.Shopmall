using System;

namespace Lmtsoft.Shopmall.Repository
{
    public class RspResult
    {
        public int Code { get; set; }
        public int Status { get; set; }
        public string ServiceName { get; set; }
        public string Msg { get; set; }
        public object Data { get; set; }
    }
}
