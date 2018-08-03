<?php 
include("connexion_bdd.php");
include("class/evenement.php");
$v_pre="";

if(isset($_POST["valide"])){
	$v_pre=mysqli_real_escape_string($id,$_POST["o"]);
	$v_re=mysqli_real_escape_string($id,$_POST["ip"]);

if($v_pre="yes"){
	$o=new demande();
		$a=$o->valide_haja(1,1);
}else  	
{$a=1;$b=0; 
	$requet=" UPDATE `contenaire` SET   `vu`='$a' and `valide`='$b' WHERE `id_cont`='$v_re' ";
	    $result=$id->query($requet);
$a=$o->valide_haja($a,$b);

}
if($a)
header('Location:satradmin.php'); else   echo"prblm";
}
?>
 <section class="content-header">
      <h1>
 <?php  include("connexion_bdd.php");?>
        <small></small>
      </h1>
      <ol class="breadcrumb">
        <li><h1>  طلبات غير معمولة </h1></li>
        <li class="active"></li>
      </ol>
    </section>

    <!-- Main content -->
    <section class="content container-fluid">
</br></br></br></br></br>
     <div class="box-body table-responsive no-padding">
              <table class="table table-hover">
                <tr>
                  <th>طلب</th>
                  <th>صورة</th>
                  <th>مكان</th>
                  <th> صحة البلاغ</th>
                  <th>ارسال</th>      
                </tr>
                
				<?php 
				    $requet = "select * from contenaire ";
	
	                $result =$id->query($requet);
				
				foreach ( $result as $pos) {
				
				
				
				?><tr>
				<form action="" method="post">
				<input type="hidden"  name="ip">
                  <td><?=$pos['id_cont']?> </td>
                  <td ><img width="40px" height="40px"  src="<?=$pos['chemin']?>">
				 </td>
                  <td>      <?=$pos['reference']?></td>
            
                  <td>
				  <label class="checkbox-inline"><input type="radio" value="no" id="val" name="o"> لا</label>
                  <label class="checkbox-inline"><input type="radio" value ="yes" name="o"> نعم  </label>
				  
				  </td>
			
				      <td> <button type="submit" name="valide" id="valide" class="label label-success"><b>  تفعيل  </b ></span></td>
					  
				</form> </tr>
				<?php } ?>
               </table>

    </section>
    <!-- /.content -->