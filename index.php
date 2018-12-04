<?php
	error_reporting(0);
	$conectar=mysqli_connect("localhost","root");
	mysqli_select_db($conectar,"anime");
	mysqli_set_charset($conectar,'utf8');
	$nom= $_POST['busq'];
?>
<!DOCTYPE html>
<html lang="es">
<head>
	<title>Pagina Muestra</title>
	<meta charset="utf-8">
	 <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
	<link rel="shortcut icon" type="image/png" href="https://www.instant-gaming.com/favicon.ico">
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="css/esyiles.css">
	<script src="js/jquery.js"></script>
	<script src="js/bootstrap.min.js"></script>
</head>
<body>
	<header>
		<nav class="navbar navbar-expand-lg navbar-dark ">
			<a href="index.php" class="navbar-brand p-0 m-0"><h3>Lista de Animes</h3></a>
			<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navegacion" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
				<span class="navbar-toggler-icon"></span>
			</button>
			<div class="collapse navbar-collapse mi_nav mt-5" id="navegacion">
				<ul class="navbar-nav mr-auto">
					<li class="nav-item active lead"><a href="index.php" class="nav-link">Inicio</a></li>
					<li class="nav-item lead"><a href="inserta.html" class="nav-link">insertar</a></li>
					<!-- Desplegable Menu comentoado -->
					<!--<li class="nav-item dropdown">
						<a href="#" class="nav-link dropdown-toggle" id="#desplegable" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Mas</a>
						<div class="dropdown-menu" aria-labelledby="desplegable">
							<a href="#" class="dropdown-item">Conocenos</a>
							<a href="#" class="dropdown-item">Contactanos</a>
						</div>
					</li>-->
				</ul>
				<form class="form-inline" action="busq.php" method="POST" name="formu_busq">
					<input type="search" class="form-control mr-sm-2" name="busq" placeholder="Buscar" aria-label="Search">
					<button class="btn btn-primary" type="submit">Buscar</button>
				</form>
			</div>
		</nav>
	</header>
	</div>
		<div class="main container  mi_contenedor">
			<div class="w-100 p-3 texto_caja01">
				<span class="aling-middle">
					<h2>Esto es la pagina de animes 4.0</h2>
						<p class="col-10 w-100 p-3 ">
							Esto es la nueva pagina de animes 4.0
						</p>
				</span>
			</div>
			<nav>
				<div class="nav nav-tabs" role="tablist">
					<a class="nav-item nav-link" id="nav-inicio-tab" data-toggle="tab" href="#nav-inicio" role="tab" aria-controls="nav-inicio" aria-selected="false" style="color: #fff;">Inicio</a>

					<a class="nav-item nav-link" id="nav-todo-tab" data-toggle="tab" href="#nav-todo" role="tab" aria-controls="nav-todo" aria-selected="false" style="color: #fff;">Todo</a>

					<a class="nav-item nav-link" id="nav-ver-tab" data-toggle="tab" href="#nav-ver" role="tab" aria-controls="nav-ver" aria-selected="false" style="color: #fff;">Ver</a>

					<a class="nav-item nav-link" id="nav-terminado-tab" data-toggle="tab" href="#nav-terminado" role="tab" aria-controls="nav-terminado" aria-selected="false" style="color: #fff;">Terminado</a>

					<a class="nav-item nav-link" id="nav-proximamente-tab" data-toggle="tab" href="#nav-proximamente" role="tab" aria-controls="nav-proximamente" aria-selected="false" style="color: #fff;">Proximamente</a>

					<a class="nav-item nav-link" id="nav-proceso-tab" data-toggle="tab" href="#nav-proceso" role="tab" aria-controls="nav-proceso" aria-selected="false" style="color: #fff;">en proceso</a>
				</div>
			</nav>
			<div class="tab-content" id="nav-tabContent">
				<div class="tab-pane fade" id="nav-inicio" role="tabpanel" aria-labelledby="nav-inicio-tab">
					<span class="aling-middle">
						<h2>Pagina de lista Animes</h2>
						<p class="justify">Esto es una pagina donde puedes subir, eliminar y modificar animes a tu gusto, esta aun en su version de prueba 4.0 pero segun valla pasando el tiempo la ire mejorando y abriendo espacios personales para el usuario.</p>
					</span>
				</div>
				<div class="tab-pane fade" id="nav-todo" role="tabpanel" aria-labelledby="nav-todo-tab">
					<?php
						$consulta= "SELECT * FROM animesver";
						$result=mysqli_query($conectar, $consulta);
						while($fila=mysqli_fetch_array($result)){
					?>
						<div class="card col-sm-6 ml-5 mt-5 clearfix" style="width: 18rem; height: 35rem;">
							 <a href="pagina.php?nom=<?php echo $fila['animes']?>" title="<?php echo $fila['animes']?>"><img class="card-img-top" alt="card image cap" src="data:imge/jpg;base64,<?php echo base64_encode($fila['Imagenes'])?>"/></a>
							 <div class="card-body">
							 	<h5 class="card-title"><?php echo $fila['animes']?></h5>
							 	<p class="card-txt"><small><b><?php echo $fila['Estado']?></b></small></p>
							 	<a href="delete.php?nom=<?php echo $fila['animes']?>" class="btn btn-primary">Eliminar</a>
							 </div>
						</div>
					<?php
						}
					?>
				</div>
				<div class="tab-pane fade" id="nav-ver" role="tabpanel" aria-labelledby="nav-ver-tab">
					<?php
						$consulta= "SELECT * FROM animesver WHERE Estado ='ver cuanto antes'";
						$result=mysqli_query($conectar, $consulta);
						while($fila=mysqli_fetch_array($result)){
					?>
					<div class="card col-sm-6 ml-5 mt-5 clearfix" style="width: 18rem; height: 35rem;">
						 <a href="pagina.php?nom=<?php echo $fila['animes']?>" title="<?php echo $fila['animes']?>"><img class="card-img-top" alt="card image cap" src="data:imge/jpg;base64,<?php echo base64_encode($fila['Imagenes'])?>"/></a>
						 <div class="card-body">
						 	<h5 class="card-title"><?php echo $fila['animes']?></h5>
						 	<p class="card-txt"><small><b><?php echo $fila['Estado']?></b></small></p>
						 	<a href="delete.php?nom=<?php echo $fila['animes']?>" class="btn btn-primary">Eliminar</a>
						 </div>
					</div>
					<?php
						}
					?>
				</div>
				<div class="tab-pane fade" id="nav-terminado" role="tabpanel" aria-labelledby="nav-terminado-tab">
					<?php
						$consulta= "SELECT * FROM animesver WHERE Estado ='terminado'";
						$result=mysqli_query($conectar, $consulta);
						while($fila=mysqli_fetch_array($result)){
					?>
					<div class="card col-sm-6 ml-5 mt-5 clearfix" style="width: 18rem; height: 35rem;">
						 <a href="pagina.php?nom=<?php echo $fila['animes']?>" title="<?php echo $fila['animes']?>"><img class="card-img-top" alt="card image cap" src="data:imge/jpg;base64,<?php echo base64_encode($fila['Imagenes'])?>"/></a>
						 <div class="card-body">
						 	<h5 class="card-title"><?php echo $fila['animes']?></h5>
						 	<p class="card-txt"><small><b><?php echo $fila['Estado']?></b></small></p>
						 	<a href="delete.php?nom=<?php echo $fila['animes']?>" class="btn btn-primary">Eliminar</a>
						 </div>
					</div>
					<?php
						}
					?>
				</div>
				<div class="tab-pane fade" id="nav-proximamente" role="tabpanel" aria-labelledby="nav-proximamente-tab">
					<?php
						$consulta= "SELECT * FROM animesver WHERE (Estado ='proximamente');";
						$result=mysqli_query($conectar, $consulta);
						while($fila=mysqli_fetch_array($result)){
					?>
					<div class="card col-sm-6 ml-5 mt-5 clearfix" style="width: 18rem; height: 35rem;">
						 <a href="pagina.php?nom=<?php echo $fila['animes']?>" title="<?php echo $fila['animes']?>"><img class="card-img-top" alt="card image cap" src="data:imge/jpg;base64,<?php echo base64_encode($fila['Imagenes'])?>"/></a>
						 <div class="card-body">
						 	<h5 class="card-title"><?php echo $fila['animes']?></h5>
						 	<p class="card-txt"><small><b><?php echo $fila['Estado']?></b></small></p>
						 	<a href="delete.php?nom=<?php echo $fila['animes']?>" class="btn btn-primary">Eliminar</a>
						 </div>
					</div>
					<?php
						}
					?>
				</div>
				<div class="tab-pane fade" id="nav-proceso" role="tabpanel" aria-labelledby="nav-proceso-tab">
					<?php
						$consulta= "SELECT * FROM animesver WHERE (Estado ='en proceso');";
						$result=mysqli_query($conectar, $consulta);
						while($fila=mysqli_fetch_array($result)){
					?>
					<div class="card col-sm-6 ml-5 mt-5 clearfix" style="width: 18rem; height: 35rem;">
						 <a href="pagina.php?nom=<?php echo $fila['animes']?>" title="<?php echo $fila['animes']?>"><img class="card-img-top" alt="card image cap" src="data:imge/jpg;base64,<?php echo base64_encode($fila['Imagenes'])?>"/></a>
						 <div class="card-body">
						 	<h5 class="card-title"><?php echo $fila['animes']?></h5>
						 	<p class="card-txt"><small><b><?php echo $fila['Estado']?></b></small></p>
						 	<a href="delete.php?nom=<?php echo $fila['animes']?>" class="btn btn-primary">Eliminar</a>
						 </div>
					</div>
					<?php
						}
					?>
				</div>
			</div>
		</div>
</body>
</html>