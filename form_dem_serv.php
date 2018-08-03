<?php
include("connexion_bdd.php");

$type="";
$quantite="";


if(isset($_POST['envoyer']))
{
  
  $type=mysqli_real_escape_string($id,$_POST["type"]);
  $quantite=mysqli_real_escape_string($id,$_POST["quantite"]);

  include("class/evenement.php");
  $evt= new service();
  $a=$evt->service_deche($type,$quantite);
  if(! $a){
    //header('Location:ag.php');
   echo"erreur";
  }
 
}

?>

   </br></br></br>

    <section class="content container-fluid">
        
        <div class="d-flex justify-content-center align-items-center container ">  <div class="row ">
    <h1 align="right"> <font color="LimeGreen"> استمارة خاصة بالطلبات </font></h1> 
      <div class="box box-success">
            
 <form role="form" class="formulair" method="post" action="" id="formul" name="formul" enctype="multipart/form-data">

<div class="form-group">
                  <label> اختيار نوع النفايات </label> 
                  <div class="input-group">
                  <div class="input-group-addon">
                    <i class="fa fa-toggle-down"></i>
                  </div>      
                  <select class="form-control" style="width: 100%;" name="type" id="type" required autofocus>
        
                  <option value="1">   بلاستك  </option>
                  <option value="2">   المنيوم </option>
                  <option value="3">   كرتون  </option>
                  <option value="4">   بقايا الاغذية  </option>
                  </select>
                </div>
                  </div>

             <div class="form-group">
                <label>الكمية</label>
                <div class="input-group">
                <div class="input-group-addon">
                    <i class="glyphicon glyphicon-shopping-cart"></i>
                </div>
                  <input type="text" class="form-control" value="<?= $quantite ?>" id="quantite" name="quantite" placeholder="الكمية" required autofocus>
                </div>
            </div>

  <div class="box-footer">
                <button type="submit" class="btn btn-success" id="envoyer" name="envoyer">ارسال</button>   
                <button type="reset"  class="btn btn-success" id="annuler" name="annuler">الغاء</button>
              </div>
            </form>
          </div>

</div>
</div>

 
    </section>


