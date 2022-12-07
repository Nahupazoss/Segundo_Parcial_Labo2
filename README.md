# Segundo_Parcial_Labo2
Segundo Parcial Laboratorio 2

Profesor: Maximiliano Neiner 
Profesor: Facundo Rocha
Alumno: Nahuel Rodrigo Pazos
Curso: 2A

La eleccion de mi parcial fue hacer el juego de la generala en el cual podemos registrarnos(a la hora de registrarnos de manera automatica somos cargados a la base de datos) como jugadores para luego poder iniciar sesion y poder entrar al menu principal de la aplicacion,en este menu principal encontraremos un boton de ayuda, un boton el cual nos mostrara todas nuestras estadisticas propias del jugador y cuantos jugadores hay registrados en la app,un boton que nos mostrara el historial de partidas propias.

En caso de no querer registrarnos tenemos la opcion de ingresar como invitado en el cual solo podremos acceder a lo que es simular/jugar partidas ya sea 1 o mas de una y las podremos jugar a la vez. 

# Diagrama de clases
![image](https://user-images.githubusercontent.com/98673588/206077280-c6ab9e65-3586-4aff-8623-e5307b1e610b.png)

# Unit Testing
Lo utilice para testear codigo que podria llegar a generar problemas.

![image](https://user-images.githubusercontent.com/98673588/206078262-fbb4c8a0-f407-4267-b709-dc596e9ee010.png)

# SQL
Genere una base de datos la cual poseee dos tablas, una de ellas sera utilizada para el registro de jugadoresPersona los cuales podemos agregar,modificar y eliminar.La otra de ellas sera utilizada para el historial de partidas que se simularan.
![image](https://user-images.githubusercontent.com/98673588/206077741-5b9ebd81-f9ad-43be-a003-81988b3d5398.png)

# Task
Utilize tasks para las partidas, cada partida que se crea es una task y esto es para que se ejecute en segundo plano automáticamente y el flujo de ejecución del programa no se bloqueé.

![image](https://user-images.githubusercontent.com/98673588/206078554-c79662b1-41c3-460f-9584-9a21fb20d7bc.png)

# Manejo de Excepciones
Donde mas utilize es en la clase AccesoDatos y AccesoDatosPartida, la cual se encarga de trabajar con la base de datos y en cada parte de codigo que hago manejo de cualquier exepcion que se pueda producir.
ejemplo:
  public bool ProbarConexion()
  {
      bool rta = true;
      try
      {
          this.conexion.Open();
      }
      catch (Exception)
      {
          rta = false;
      }
      finally
      {
          if (this.conexion.State == ConnectionState.Open)
          {
              this.conexion.Close();
          }
      }
      return rta;
  }



