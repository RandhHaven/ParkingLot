namespace ParkingLot.Models.Areas.Shared
{
    using System;
    using System.Collections.Generic;

    public class ResultViewModel
    {
        /// <summary>
        /// Lista de Elementos.
        /// </summary>
        public List<Object> List
        {
            get;
            set;
        }

        /// <summary>
        /// Lista de objetos seleccionados.
        /// </summary>
        public Object SelectedItems
        {
            get;
            set;
        }

        /// <summary>
        /// Indica si la grilla esta habilitada o deshabilitada.
        /// </summary>
        public Boolean EnableGrid { get; set; }
    }

    public class ResultViewModel<TItem> : ResultViewModel
        where TItem : ResultItemViewModel
    {
        public new List<TItem> List { get; set; }

        public ResultViewModel()
        {
            this.List = new List<TItem>();
        }
    }
}