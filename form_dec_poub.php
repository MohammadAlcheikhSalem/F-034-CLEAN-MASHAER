<?php
include("connexion_bdd.php");
$reference="";

if(isset($_POST['envoyer']))
{
  

  $reference=mysqli_real_escape_string($id,$_POST["reference"]);


  if(isset($_FILES['avatar'])AND !empty($_FILES['avatar']['name'])){
     
     
     $max=2097152;$extentionvalide=array('jpg','jpeg','gif','png');
     
     if($_FILES['avatar']['size']<=$max){
       $extentionupload=strtolower(substr(strrchr($_FILES['avatar']['name'],'.'),1));
       if(in_array( $extentionupload,$extentionvalide)){
         $chemin="images/"."photo.".$extentionupload;
         $resio=move_uploaded_file($_FILES['avatar']["tmp_name"],$chemin);      
                       
                 }
                
       }else {
         $iserror=true;
             $errormsg="extention n'est pas valider";
       }
       
       
           }else {
         $iserror=true;
             $errormsg="votre photo ne doit pas de passe  2Mo";
       }



  include("class/evenement.php");
  $evt= new demande();
  $a=$evt->ajtdeche($reference,$chemin);
  if($a){
header('Location:info_sucess.php');
  }
 
}

?>

    </br></br>
    <section class="content container-fluid">
        <div class="d-flex justify-content-center align-items-center container ">  <div class="row ">
 <h3 align="right"> <font color="LimeGreen">تبليغ عن نفايات متراكمة  </font></h3>
      <div class="box box-success">
            
 <form role="form" class="formulair" method="post" action="" id="formul" name="formul" enctype="multipart/form-data">
 
                    
            <div class="form-group">
                <label>رقم الحاوية</label>
                <div class="input-group">
                <div class="input-group-addon">
                    <i class="fa fa-trash-o"></i>
                </div>
              
                 <input type="text" class="form-control" value="<?=$reference ?>" 
                 id="reference" name="reference" placeholder="رقم الحاوية" required autofocus>

                </div>
            </div>
          
                <div class="form-group">
                  <label > تحميل الصور </label>
                   <div class="input-group">
                <div class="input-group-addon">
                    <i class="glyphicon glyphicon-picture"></i>
                </div>

                  <button type="button" class="btn btn-success">
                    <input type="file" name="avatar" id ="avatar" class="upload"></button>
                </div>

               
              </div>
            
              <div class="box-footer">
                <button type="submit" class="btn btn-success" id="envoyer" name="envoyer">ارسال</button>   
                <button type="reset"  class="btn btn-success" id="annuler" name="annuler">الغاء</button>
              </div>
            </form></h2>
          </div>

</div>
</div>

 
    </section>


