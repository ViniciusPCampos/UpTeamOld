﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPTEAM.AutoMapper.Parses.Interfaces;
using UPTEAM.Domain.Entities;
using UPTEAM.Models;

namespace UPTEAM.AutoMapper.Parses
{
    public class TarefaModelToTbTarefaParse : ParseBase<TarefaModel,tb_tarefa>, ITarefaModelToTbTarefaParse
    {
    }
}
