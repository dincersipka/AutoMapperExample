using AutoMapper;
using AutoMapperExample.DTO;
using AutoMapperExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _UserService;

    private readonly IMapper _Mapper;

    public UserController(UserService UserService, IMapper Mapper)
    {
        _UserService = UserService;
        _Mapper = Mapper;
    }

    [HttpGet]
    public List<UserDTO> Get()
    {
        List<UserDTO> Users = _Mapper.Map<List<UserDTO>>(_UserService.GetAll()); 

        return Users;
    }
}
