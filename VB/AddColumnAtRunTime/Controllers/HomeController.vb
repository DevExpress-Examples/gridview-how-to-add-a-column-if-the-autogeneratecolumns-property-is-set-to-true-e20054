Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DisplayDetailInPopupWindow.Models

Namespace DisplayDetailInPopupWindow.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		<HttpPost> _
		Public Function GridAction() As PartialViewResult
			Return PartialView("GridPartial", CustomerRepository.GetCustomers())
		End Function
	End Class
End Namespace
