﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowLib.Model
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid StructDivisionId { get; set; }
        public StructDivision StructDivision { get; set; }
        public bool IsHead { get; set; }

        public List<EmployeeRole> EmployeeRoles { get; set; }
    }
}
