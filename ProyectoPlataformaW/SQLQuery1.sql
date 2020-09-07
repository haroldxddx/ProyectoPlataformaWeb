select*from Foro
select*from Actividad


--select froro con where de actividad 
select Foro.Titulo, Foro.Descripcion ,Foro.Imagen,Foro.Tipo,Foro.Archivo,Actividad.FechaInicio,Actividad.FechaFinal from Foro
inner join Actividad on
foro.IdActividad=Actividad.IdActividad 
where Actividad.IdActividad=23




--select comentarios 

select Participacion.IdParticipacion,Participacion.Fecha,Participacion.Comentario,Estudiante.Nombres,Estudiante.Apellidos from Participacion
inner join Estudiante on
Participacion.IdEstudiante=Estudiante.IdEstudiante










