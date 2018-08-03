<?php

$_SESSION["membre"] = "";
$_SESSION["membreid"] = "";

include("connexion_bdd.php");
$pseudo="";
$mdp="";
if(isset($_POST['envoyer']))
{
  

  $pseudo=mysqli_real_escape_string($id,$_POST["pseudo"]);
  $mdp=mysqli_real_escape_string($id,$_POST["pwd"]);

  include("class/evenement.php");

  $evt= new connecte();
  $a=$evt->connecter($pseudo,$mdp);
  
  if($a){
    header("Location: form_page_soc.php");
  }
  else{

      header("Location: formulaire_connexion.php");
  }


   }
  
 



?>



</br></br></br></br>
    <section class="content container-fluid">
        <div class="d-flex justify-content-center align-items-center container ">  <div class="row ">
           <h1 align="right"> <font color="LimeGreen"> استمارة الدخول الى الموقع </font></h1>
      <div class="box box-success">
            
 <form role="form" class="formulair" method="post" action="" id="formul" name="formul" enctype="multipart/form-data">
 
                    
            <div class="form-group">
                <label>البريد الالكتروني</label>
                <div class="input-group">
                <div class="input-group-addon">
                    <i class="fa fa-at"></i>
                </div>
              
                 <input type="text" class="form-control" 
                 id="pseudo" name="pseudo" placeholder="البريد الالكتروني" required autofocus>

                </div>
            </div>

             <div class="form-group">
                <label>الرقم السري</label>
                <div class="input-group">
                <div class="input-group-addon">
                    <i class="fa fa-unlock-alt"></i>
                </div>
                  <input type="password" class="form-control" id="pwd" name="pwd" placeholder="الرقم السري" required autofocus>
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

          
