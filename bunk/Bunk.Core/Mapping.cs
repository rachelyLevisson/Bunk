using AutoMapper;
using Bunk.Core.DTOs_Model;
using Bunk.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunk.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer,CustomerDTO>().ReverseMap();
        }
    }
}
