﻿using Abp.Application.Services.Dto;

namespace MyEmployee.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

