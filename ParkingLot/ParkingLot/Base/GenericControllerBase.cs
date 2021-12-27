namespace ParkingNet.Base
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using ParkingLot.Models.Areas.Shared;
    using System;
    using System.Collections.Generic;

    public abstract class GenericControllerBase<T, TUIService, VM> : Controller
        where VM : ViewModel, new()
    {
        #region Properties

        private VM model;

        protected VM Model
        {
            get
            {
                if (model == null)
                    this.InitializeModel();

                return model;
            }
            private set
            {
                this.model = value;
            }
        }

        protected TUIService UIService { get; private set; }

        protected abstract string Title { get; }

        #endregion

        #region Builds
        protected GenericControllerBase(ILogger<T> _logger, TUIService uiService, VM model)
        {
            this.model = model;
        }
        #endregion        

        #region Initialization Methods
        public virtual void OnInitialize(ILogger<T> logger) { }

        protected virtual void InitializeBehavior()
        {
        }

        protected virtual void InitializeTempDataValues()
        {
        }

        private void SetTitle()
        {
            this.ViewBag.Title = this.Title;
        }

        protected virtual void InitializeModel()
        {
            this.Model = new VM();
        }

        protected string PageTempDataToken
        {
            get
            {
                if (String.IsNullOrEmpty(this.Model.PageTempDataToken))
                {
                    //Para la funcion de descargar archivo el PageTempDataToken se envia en el Form
                    this.Model.PageTempDataToken = !String.IsNullOrWhiteSpace(this.HttpContext.Request.Headers["PageTempDataToken"]) ?
                                                    this.HttpContext.Request.Headers["PageTempDataToken"] : this.HttpContext.Request.Form["PageTempDataToken"];
                }

                return this.Model.PageTempDataToken;
            }
        }

        #endregion

        #region TempData Methods

        protected void RemoveTempData(string key)
        {
            TempData.Remove(this.PageTempDataToken + key);
        }

        protected void SetTempData(string key, object value)
        {
            TempData[this.PageTempDataToken + key] = value;
        }

        protected T GetTempData(string key)
        {
            return (T)TempData.Peek(this.PageTempDataToken + key);
        }

        protected T GetTempData(string key, string externalToken)
        {
            return (T)TempData.Peek(externalToken + key);
        }

        protected T GetTempDataAndDispose(string key)
        {
            return this.GetTempDataAndDispose(key, false);
        }

        protected T GetTempDataAndDispose(string key, bool safeCast)
        {
            var value = TempData[this.PageTempDataToken + key];

            if (safeCast) value = Convert.ChangeType(value, typeof(T));

            return (T)value;
        }

        protected Boolean TempDataContains(string key)
        {
            return TempData.ContainsKey(this.PageTempDataToken + key);
        }

        protected Boolean TempDataContains(string key, string externalToken)
        {
            return TempData.ContainsKey(externalToken + key);
        }      

        #endregion

        #region Private Methods

        private void CopyPreviousPageTempDataAndClean(string previousPageTempDataToken)
        {
            var keysToSaveAndDelete = new Dictionary<string, object>();
            foreach (var key in TempData.Keys)
            {
                if (key.Contains(previousPageTempDataToken))
                {
                    keysToSaveAndDelete.Add(key, TempData[key]);
                }
            }

            foreach (var key in keysToSaveAndDelete.Keys)
            {
                this.SetTempData(key.Replace(previousPageTempDataToken, String.Empty), keysToSaveAndDelete[key]);
                TempData.Remove(key);
            }
        }

        #endregion
    }
}
