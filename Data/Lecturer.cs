using System;
using System.Collections.Generic;

namespace TestApp.Data;

public partial class Lecturer
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;
}
