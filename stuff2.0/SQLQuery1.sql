/****** Script para el comando SelectTopNRows de SSMS  ******/

/*SELECT TOP 1000 [id]
      ,[nombre]
      ,[apellido]
      ,[edad]
  FROM [Padron].[dbo].[Personas]*/
  DELETE FROM Padron.dbo.Personas
  WHERE id = 6

  SELECT  id,nombre,apellido,edad
  /*SELECT * el asterisco tomaa todos los campos*/
  FROM Padron.dbo.Personas
 

  /*UPDATE Padron.dbo.Personas
  SET	nombre = 'Martin',
		apellido = 'Gonzalez',
		edad = 20
  WHERE id = 1*/

  /*INSERT INTO Padron.dbo.Personas
  (nombre,apellido,edad)
  values
  ('Ricardo','Perez',54)*/
  
  /*WHERE edad = 74 OR id = 2 criterio en donde quiero que muestre
   uno con 74 años y al id 2
  ORDER BY edad DESC ordene de forma descendente la edad */