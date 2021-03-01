using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cpa1.Models;
using Microsoft.IdentityModel.Protocols;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;

namespace Cpa1.Controllers
{


    public class structureController : Controller
    {




        public JsonResult check(int code)
        {
            lstructure verif = new lstructure();
            structuse str = new structuse();
            str = verif.verifier(code);
            if (str.codeuse == true)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }



        }






        public IActionResult Lstruct()
        {
            lstructure liste = new lstructure();
            List<structure> structures = liste.Structures.ToList();
            return View(structures);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection formcollection)
        {
            structure str = new structure();
            str.code = Convert.ToInt32(formcollection["code"]);
            str.abr = formcollection["abr"].ToString();
            str.desig = formcollection["desig"].ToString();
            str.adr = formcollection["adr"].ToString();
            str.telephone = (formcollection["telephone"]).ToString();
            str.fax = (formcollection["fax"]).ToString();
            str.IDattaché = Convert.ToInt32(formcollection["idattaché"]);
            str.IDpersonne = Convert.ToInt32(formcollection["idpersonne"]);
            lstructure liste = new lstructure();
            liste.addstructure(str);



            return RedirectToAction("Lstruct");
        }
       
        [HttpGet]
        public IActionResult Edit(int id)
        {
            lstructure str = new lstructure();
            structure structures = str.Structures.Single(emp => emp.code == id);
            return View(structures);
        }
      
        [HttpPost]
        public IActionResult Edit(IFormCollection formcollection,int id)
        {

           
            structure str = new structure();
            str.code = Convert.ToInt32(formcollection["code"]);     
            str.abr = formcollection["abr"].ToString();
            str.desig = formcollection["desig"].ToString();
            str.adr = formcollection["adr"].ToString();
            str.telephone = (formcollection["telephone"]).ToString();
            str.fax = (formcollection["fax"]).ToString();
            str.IDattaché = Convert.ToInt32(formcollection["IDattaché"]);
            str.IDpersonne = Convert.ToInt32(formcollection["idpersonne"]);
          
            lstructure liste = new lstructure();
            liste.modifystructure(str,id);
            


            return RedirectToAction("Lstruct");

        }



        public IActionResult Details(int id)
        {
            lstructure str = new lstructure();
            structure structures = str.Structures.Single(emp => emp.code == id);
            return View(structures);
        }




        /*     public IActionResult Delete(int id)
             {
                 lstructure str = new lstructure();
                 structure structures = str.Structures.Single(emp => emp.code == id);


                 return View(structures);
             }*/
        /* public IActionResult DeleteOK(int id)
         {
             string connectionstring = "Server=DESKTOP;Database=structure;Trusted_Connection=True;";
             using (SqlConnection con = new SqlConnection(connectionstring))
             {
                 SqlCommand cmd = new SqlCommand("Delete", con);
                 cmd.CommandType = System.Data.CommandType.StoredProcedure;

                 SqlParameter paramcode = new SqlParameter();
                 paramcode.ParameterName = "@code";
                 paramcode.Value = id;
                 cmd.Parameters.Add(paramcode);



                 con.Open();
                 cmd.ExecuteNonQuery();
             }


             return RedirectToAction("Lstruct");
         }*/

/*  function Usercheck()
  {

  $("#Status").html("Checking...");
  $.post("@Url.Action("check","structure")",
      { code: $("#code").valueOf() },

 function(data)
 if (data == 0)
      {
      $("#Status").html('<font color="Green">Available</font>');
      }

      else
      {
   $("#Status").html('<font color="Red">NotAvailable</font>');
      }
  }*/


/*<script type="text/javascript">
$(document).ready(function () {

$('#code').keyup(function () {
  var code = $(this).val();
  $.ajax({
      url: '(structure,Edit)',
      method: 'post',
      data: { code:code },
      dataType: 'json'
      success: function (data) {
          var divElement = $('#Status');
          if (data.codeuse) {
              divElement.text(code + 'est pris');
              divElement.css('color', 'red');
          }
          else {
              divElement.text(code + 'est non pris');
              divElement.css('color', 'green');

          }
      },
      error: function (err) { alert(err); }
  });

});
});
</script>*/

}
}
 