﻿using System.Collections.Generic;
using UPTEAM.Domain.Entities;

namespace UPTEAM.Domain.RepositoryInterfaces
{
    public interface ISprintRepository: IRepositoryBase<tb_sprint>
    {
        IEnumerable<tb_sprint> GetSprintsByProject(int idt_projeto);
    }
}
