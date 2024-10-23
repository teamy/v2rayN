﻿namespace ServiceLib.Models
{
    [Serializable]
    public class ClashProxyModel
    {
        public string? name { get; set; }

        public string? type { get; set; }

        public string? now { get; set; }

        public int delay { get; set; }

        public string? delayName { get; set; }

        public bool IsActive { get; set; }
    }
}