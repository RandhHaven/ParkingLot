namespace EstacionamientoEntity.Entitys
{
    using System;

    [Serializable]
    public class CarBase : EntityBaseClass
    {
        #region Properties

        public int IdAuto { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public string Empleado { get; set; }

        public string Patente { get; set; }

        #endregion
    }
}
