﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.QueryBuilder;

namespace EJ2MVCSampleBrowser.Controllers.QueryBuilder
{
    public partial class QueryBuilderController : Controller
    {
        // GET= DefaultFunctionalities
        public ActionResult Grid()
        {
            QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "or",
                Rules = new List<QueryBuilderRules>()
                {
                    new QueryBuilderRules { Label="Category", Field="Category", Type="string", Operator="equal", Value = "Laptop" }
                }
            };

            ViewBag.rule = rule;
            ViewBag.dataSource = QueryBuilderData.hardwareData;
            return View();
        }
    }
}