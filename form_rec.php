<?php
include("connexion_bdd.php");

$nom_soc="";
$add="";
$registre="";
$type_soc="";
$email="";
$mdp="";
$mdp2="";
$telephone="";

if(isset($_POST['envoyer']))
{
  $nom_soc=mysqli_real_escape_string($id,$_POST["nom_soc"]);
  $add=mysqli_real_escape_string($id,$_POST["lieu"]);
  $registre=mysqli_real_escape_string($id,$_POST["registre"]);
  $type_soc=mysqli_real_escape_string($id,$_POST["type"]);
  $email=mysqli_real_escape_string($id,$_POST["email"]);
  $mdp=mysqli_real_escape_string($id,$_POST["pwd"]);
  $mdp2=mysqli_real_escape_string($id,$_POST["pwd2"]);
  $telephone=mysqli_real_escape_string($id,$_POST["telephone"]);
  
  if ($mdp!=$mdp2) {
    
  echo"<center>le Mot de passe n'est pas compatible </br></center>";
  die("<html><center><a href='formulaire_rec.php' style='font-family:Verdana; color:white; text-decoration:none;'>  Revenir !!! </a> </center></html>");
  
  }  
 

   include("class/evenement.php");
  $evt= new inscription();
  $a=$evt->insc_soc($nom_soc,$add,$registre,$type_soc,$email,$mdp,$telephone);
  if($a){
   header('Location:insc_sucss.php');
  }
 
}

?>  
    <!-- Main content -->
  

 <?php /*include("head2.php"); */?>
    
    <section class="content container-fluid">
        
        <div class="d-flex justify-content-center align-items-center container ">  <div class="row ">
    <h1 align="right"> <font color="LimeGreen"> استمارة خاصة بالشركات </font></h1> 
      <div class="box box-success">
            
 <form role="form" class="formulair" method="post" action="" id="formul" name="formul" enctype="multipart/form-data">
 
            
             <div class="form-group">
                <label>اسم الشركة</label>
                <div class="input-group">
                <div class="input-group-addon">
                    <i class="fa fa-bank"></i>
                </div>
                  <input type="text" class="form-control" id="nom_soc" name="nom_soc" placeholder="اسم الشركة" required autofocus>
                </div>
            </div>

             <div class="form-group">
                <label>العنوان</label>
                <div class="input-group">
                <div class="input-group-addon">
                    <i class="fa fa-home"></i>
                </div>
                  <input type="text" class="form-control" id="lieu" name="lieu" placeholder="العنوان" required autofocus>
                </div>
            </div>

             <div class="form-group">
                <label>رقم السجل التجاري</label>
                <div class="input-group">
                <div class="input-group-addon">
                    <i class="fa fa-address-card"></i>
                </div>
                  <input type="text" class="form-control" id="registre" name="registre" placeholder="رقم السجل التجاري" required autofocus>
                </div>
            </div>

            <div class="form-group">
                  <label> نوع الشركة </label> 
                  <div class="input-group">
                  <div class="input-group-addon">
                    <i class="fa fa-toggle-down"></i>
                  </div>      
                  <select class="form-control" style="width: 100%;" name="type" id="type" required autofocus>
        
                  <option value="1">   شركة تنظيف  </option>
                  <option value="2">   شركة اعادة تدوير النفايات </option>
                  
                  </select>
                </div>
                  </div>



             <div class="form-group">
                <label>البريد الالكتروني</label>
                <div class="input-group">
                <div class="input-group-addon">
                    <i class="fa fa-at"></i>
                </div>
                  <input type="text" class="form-control" id="email" name="email" placeholder="البريد الالكتروني" required autofocus>
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

            <div class="form-group">
                <label>تاكيد الرقم السري</label>
                <div class="input-group">
                <div class="input-group-addon">
                    <i class="fa fa-unlock-alt"></i>
                </div>
                  <input type="password" class="form-control" id="pwd2" name="pwd2" placeholder="تاكيد الرقم السري" required autofocus>
                </div>
            </div>


             <div class="form-group">
                <label>رقم الهاتف</label>
                <div class="input-group">
                <div class="input-group-addon">
                    <i class="fa fa-mobile-phone"></i>
                </div>
                  <input type="text" class="form-control" id="telephone" name="telephone" placeholder="رقم الهاتف" required autofocus>
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


