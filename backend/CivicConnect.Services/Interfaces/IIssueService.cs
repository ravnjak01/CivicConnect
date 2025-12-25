using CivicConnect.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivicConnect.Services.Interfaces
{
    public interface IIssueService
    {
        Task<int> CreateAsync(CreateIssueDTO dto);
    }
}
