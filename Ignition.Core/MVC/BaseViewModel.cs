﻿using System.Collections.Generic;
using Ignition.Core.Models;

namespace Ignition.Core.Mvc
{
    public class BaseViewModel
    {
        private List<string> ErrorMessages { get; } = new List<string>();
        public string[] Errors => ErrorMessages.ToArray();
        public virtual string ViewPath { get; set; }
        public IPage ContextPage { get; set; }
        public string ParentPlaceholderName { get; set; }
        public bool UseWrapper { get; set; }
    }
}