using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Application.DTOs;
using Client.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Client.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IApplicationServiceUser _applicationServiceUser;


        public UserController(IApplicationServiceUser ApplicationServiceUser)
        {
            _applicationServiceUser = ApplicationServiceUser;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceUser.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            return Ok(_applicationServiceUser.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] UserDTO userDTO)
        {
            try
            {
                if (userDTO == null)
                    return NotFound();

                _applicationServiceUser.Add(userDTO);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] UserDTO userDTO)
        {
            try
            {
                if (userDTO == null)
                    return NotFound();

                _applicationServiceUser.Update(userDTO);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete([FromQuery] string id)
        {
            try
            {
                if (id == null)
                    return BadRequest();

                _applicationServiceUser.Deactivate(id);
                return Ok("Cliente desativado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}