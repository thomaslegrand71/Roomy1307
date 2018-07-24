﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roomy.Controllers
{
    public class BaseController : Controller
    {
        protected void DisplayMessage(string message, MessageType type)
        {
            TempData["Message"] = message;
            switch (type)
            {
                case MessageType.SUCCESS:
                    TempData["MessageType"] = "success";
                    break;
                case MessageType.WARNING:
                    TempData["MessageType"] = "warning";
                    break;
                case MessageType.ERROR:
                    TempData["MessageType"] = "danger";
                    break;
            }
        }

    }

    public enum MessageType
    {
        SUCCESS,
        WARNING,
        ERROR
    }
}