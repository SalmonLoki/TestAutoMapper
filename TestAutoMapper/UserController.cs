using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TestAutoMapper
{
    public class UserController
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IActionResult> Edit(string id)
        {
            var model = _mapper.Map<UserDTO>(user);
        }
    }
}
