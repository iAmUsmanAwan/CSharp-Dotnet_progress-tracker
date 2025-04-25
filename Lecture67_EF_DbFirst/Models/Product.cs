using System;
using System.Collections.Generic;

namespace Lecture67_EF_DbFirst.Models;

public partial class Product
// we will not edit these files, as they are auto-generated, instead we will create a partial class in the Models folder
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
