RESULADOS.PHP
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Resultados de Datos</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
   <div class="dive2">
    <h1>Resultados</h1>
    <center>
        <img src="Felicidades.gif" alt="Felicidades.gif">
        <br>
        <?php
        $nombre = $_POST['Name'];
           echo '<p><b>Nombre:</b> '.$nombre.'</p>';

           $edad= $_POST['Edad'];
           echo '<p><b>Edad:</b> '.$edad.'</p>';

           $ciudad = $_POST['Ciudad'];
           echo '<p><b>Ciudad:</b> '.$ciudad.'</p>';

           $fecha_nac = $_POST['Nac'];
           echo '<p><b>Fecha de Nacimiento:</b> '.$fecha_nac.'</p>';

           $pasatiempo = $_POST['Hobby'];
           echo '<p><b>Pasatiempo:</b> '.$pasatiempo.'</p>';
        ?>
    </center>
    <h2>¡Bien Hecho!</h2>
    <div id="popUpOverlay"></div>
          <div id="popUpBox">
          <div id="box">
                 <i class="fas fa=question=circle fa-5x"></i>
                   <h1>¿volder a ingresar datos?</h1>
            <div id="closeModal"></div>
        </div>
    </div>
    <center>
        <button onclick="Alert.render('You look very pretty today.')" class="btn">¡Volver a ingresar!</button>
        <script src="app.js"></script>
        </center>
    </center>
</body>
</html>
