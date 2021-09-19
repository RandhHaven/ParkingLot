namespace WebApiServiceEstacionamiento.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using WebApiServiceEstacionamiento.Entities.Parking;
    using Services.EmployeeServices;
    using System.Threading.Tasks;
    using AutoMapper;

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : WebApiControllers<EmployeeController>
    {
        #region Properties
        public IEmployeeService _IEmployeeService { get; set; }
        private readonly ILogger<EmployeeController> _logger;
        private readonly IMapper _mapper;
        #endregion

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService _IEmployeeService, IMapper _mapper) : base(logger, _IEmployeeService, _mapper)
        {
            this._IEmployeeService = _IEmployeeService ?? throw new ArgumentNullException(nameof(_IEmployeeService));
            this._logger = logger  ?? throw new ArgumentNullException(nameof(logger));
            this._mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
        }

        // GET: api/Employee
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _IEmployeeService.GetEmployees();

            return Ok(employees);
        }

        // GET: api/Empleado/5
        [HttpGet("{id}", Name = "GetEmployee")]
        public async Task<IActionResult> GetEmployee(Int64 id)
        {
            var employees = await _IEmployeeService.GetEmployeeById(id);

            return Ok(employees);
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee unEmpleado)
        {
            if (ModelState.IsValid)
            {
                return new CreatedAtRouteResult("GetEmpleado", new { id = unEmpleado.EmployeeId }, unEmpleado);
            }
            return BadRequest(ModelState);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
