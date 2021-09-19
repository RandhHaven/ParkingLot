namespace EstacionamientoNetCore
{
    using EstacionamientoEntity.Entitys;
    using System.Collections.Generic;

    public interface ISistemaEstacionamientoCore
    {
        List<CarBase> GetListadoAutos();
        List<EmployeeBase> GetListadoEmpleados();
    }
}