<<<<<<< HEAD
﻿using System;

namespace TalebElm.Domain.Entities;
=======
﻿namespace TalebElm.Domain.Entities;
>>>>>>> 5c6b99ebb1db6d9729c8bbe1cf902451b4c539a4

public class User : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime JoinedAt { get; set; }
}