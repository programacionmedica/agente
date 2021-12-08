---- Doctores por especialidades---------------------
select m.cod_doc,m.nom_doc,m.activi,e.cod_esp,esp.nom_esp
from m_doctores  as m,m_espcxdoctor as e,m_especialidades as esp
where m.cod_doc=e.cod_doc and e.cod_esp=esp.cod_esp and
m.activi=true and e.cod_esp='026'
---------------------------------------------------------------------------------

------------------ TABLA PROGRAMACION DE TURNOS ----------------------------------
--- drop table t_prog_doctorxturno 
drop table t_prog_doctorxturno 
CREATE TABLE t_prog_doctorxturno
(
   cod_asig integer NOT NULL,
  cod_doc character(6) NOT NULL,
  nom_doc character(50),
  horini_asig_doc time without time zone,
  horfin_asig_doc time without time zone,
  des_doc character(100),
  fecini_asig date,
  turno character(1),
  cod_esp character(3),
  zona character(10),
  cod_dis character(40),
  tipo_mot character(1),
  cod_mot character(4),
  nom_mot character(40),
  horini_asig_mot time without time zone,
  horfin_asig_mot time without time zone,
  estado_prog character(1),
  asig_activo boolean,
  nom_usu character(15)
 )
WITH (
  OIDS=TRUE
);
ALTER TABLE t_prog_doctorxturno
  OWNER TO postgres;
--------------------------------------- Query ------------------------------------------------------------------
Select * from t_prog_doctorxturno
--delete  from t_prog_doctorxturno

select DISTINCT(cod_zona) from m_distritos order by cod_zona asc
SELECT des_dis,cod_zona,cod_dis from m_distritos where cod_zona='ZONA 9'


select cod_asig,nom_doc,fecini_asig,des_doc,turno,horini_asig_doc,horfin_asig_doc,zona,esp.nom_esp,horini_asig_mot,horfin_asig_mot,estado_prog from t_prog_doctorxturno,m_especialidades as esp where t_prog_doctorxturno.cod_esp=esp.cod_esp AND t_prog_doctorxturno.cod_esp='005' order by fecini_asig asc
select * from m_especialidades 
--------------------------------
Select * from t_prog_doctorxturno where cod_asig =4

select cod_asig,nom_doc,to_char(fecini_asig,'yyyy-MM-dd')AS FECHA,des_doc,turno,horini_asig_doc,horfin_asig_doc,zona,esp.nom_esp,horini_asig_mot,horfin_asig_mot,estado_prog 
from t_prog_doctorxturno,m_especialidades as esp where t_prog_doctorxturno.cod_esp=esp.cod_esp AND t_prog_doctorxturno.fecini_asig between '2013-06-02' and '2013-06-02'






