using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FieldServiceT.Models
{
    public class SystemUser
    {
        public string SystemUserId { get; set; }
        public string FullName { get; set; }

        public SystemUser()
        {
        }

      
    }
}
