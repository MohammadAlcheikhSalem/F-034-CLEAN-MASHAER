<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <link href="bootstrap/css/bootstrap.css" rel="stylesheet"/>
  <link rel="stylesheet" href="css/csssite.css" type="text/css" />
  <link rel="stylesheet" href="css/menu.css" type="text/css" />
  <title>Hackathon</title>
 

  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <link rel="stylesheet" href="bower_components/bootstrap/dist/css/bootstrap.min.css">
 
  <link rel="stylesheet" href="bower_components/font-awesome/css/font-awesome.min.css">

  <link rel="stylesheet" href="bower_components/Ionicons/css/ionicons.min.css">

  <link rel="stylesheet" href="dist/css/AdminLTE.min.css">

  <link rel="stylesheet" href="dist/css/skins/skin-blue.min.css">

 
  <link rel="stylesheet"
        href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">

</head>

<body class="hold-transition skin-blue sidebar-mini">
<div class="wrapper">

  <!-- Main Header -->
  <header class="main-header">
  <?php include("head.php"); ?>
  </header>
  <!-- Left side column. contains the logo and sidebar -->
  

  <?php include("lefetbar.php"); ?>
  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    <!-- Content Header (Page header) -->
   
  <?php include("page_societe.php"); ?>
  </div>
  <!-- /.content-wrapper -->

  <!-- Main Footer -->
  <?php include("footer.php"); ?>

  <!-- Control Sidebar  -->
   
    <!--pour glisse la bar a gauche  -->
<aside class="control-sidebar control-sidebar-dark">
  <?php include("bardroite.php"); ?>
  </aside>
  <!-- /.control-sidebar -->
  <!-- Add the sidebar's background. This div must be placed
  immediately after the control sidebar -->
  <div class="control-sidebar-bg"></div>
</div>
<!-- ./wrapper -->

<!-- REQUIRED JS SCRIPTS -->

<!-- jQuery 3 -->
<<script src="bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- AdminLTE App -->
<script src="dist/js/adminlte.min.js"></script>

<!-- Optionally, you can add Slimscroll and FastClick plugins.
     Both of these plugins are recommended to enhance the
     user experience. -->
</body>
</html>
