﻿using Glass.Mapper.Sc.Configuration.Attributes;
using Ignition.Core.Models;

namespace Ignition.Data.Fields
{
    [SitecoreType(TemplateId = "{0F38D202-D47C-4E9A-93E5-3B535AB63CF0}")]
    public interface IRichContent1 : IModelBase
    {
        [SitecoreField(FieldId = "{A3513117-630A-4830-86C0-A2F15164BE04}")]
        string RichText1 { get; set; }
    }
}