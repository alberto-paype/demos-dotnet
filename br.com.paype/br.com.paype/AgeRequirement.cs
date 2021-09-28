using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.paype
{
    public class AgeRequirement : IAuthorizationRequirement
    {

        public AgeRequirement(int age)
        {
            Age = age;
        }


        public int Age { get; set; }
    }
}
