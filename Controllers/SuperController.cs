﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoN2.DAO;
using ProjetoN2.Models;

namespace ProjetoN2.Controllers
{
    public abstract class SuperController<T> : Controller where T : SuperViewModel
    {
        protected SuperDAO<T> DAO { get; set; }
        protected string IndexViewName { get; set; } = "Index";
        protected string FormViewName { get; set; } = "Form";

        public virtual IActionResult Index()
        {
            try
            {
                var modelList = DAO.SelectAll();
                return View(IndexViewName, modelList);
            }
            catch (System.Exception e)
            {
                return View("Error", new ErrorViewModel(e.ToString()));
            }
        }
        public virtual void PrepareView()
        {
            return;
        }

        public virtual IActionResult Create()
        {
            try
            {
                PrepareView();
                return View(FormViewName);
            }
            catch (System.Exception e)
            {
                return View("Error", new ErrorViewModel(e.ToString()));
            }
        }

        public virtual IActionResult Update(int id)
        {
            try
            {
                var model = DAO.SelectById(id);
                if(model == null)
                {
                    return RedirectToAction(IndexViewName);
                }
                PrepareView();
                return View(FormViewName, model);
            }
            catch (System.Exception e)
            {
                return View("Error", new ErrorViewModel(e.ToString()));
            }
        }
        public virtual IActionResult Delete(int id)
        {
            try
            {
                DAO.Delete(id);
                return RedirectToAction(IndexViewName);
            }
            catch (System.Exception e)
            {
                return View("Error", new ErrorViewModel(e.ToString()));
            }
        }

        public virtual IActionResult Save(T model)
        {
            try
            {
                ValidateModel(model);
                if(!ModelState.IsValid)
                {
                    PrepareView();
                    return View(FormViewName, model);
                }

                if(model.Id == 0)
                {
                    DAO.Insert(model);
                }
                else
                {
                    DAO.Update(model);
                }
                return RedirectToAction(IndexViewName);
            }
            catch (System.Exception e)
            {
                return View("Error", new ErrorViewModel(e.ToString()));
            }
        }

        protected abstract void ValidateModel(T model);
    }
}
