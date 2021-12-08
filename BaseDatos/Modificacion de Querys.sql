
---- Agregar Columna en distritos ------------------------------------
ALTER TABLE m_distritos ADD COLUMN cod_zona character(8) 
-------------------------------------------------------------------------------------

---surco
select * from m_distritos where des_dis like '%SURCO%'

update m_distritos set cod_zona='ZONA 01' where cod_dis='L33'

--- La Molina
select * from m_distritos where des_dis like '%MOLINA%'

update m_distritos set cod_zona='ZONA 02' where cod_dis='L12'

--- San Borja, Surquillo
select * from m_distritos where des_dis like '%BORJA%'
select * from m_distritos where des_dis like '%SURQUILLO%'

update m_distritos set cod_zona='ZONA 03' where cod_dis='L41'
update m_distritos set cod_zona='ZONA 03' where cod_dis='L34'

---Miraflores, San Isidro, 
select * from m_distritos where des_dis like '%MIRAFLORES%'
select * from m_distritos where des_dis like '%ISIDRO%'

update m_distritos set cod_zona='ZONA 04' where cod_dis like '%L18%'
update m_distritos set cod_zona='ZONA 04' where cod_dis like '%L27%'

---Barranco, Chorrillos, /// SJM, VMT, VES
select * from m_distritos where des_dis like '%BARRANCO%'
select * from m_distritos where des_dis like '%CHORRILLOS%'
select * from m_distritos where des_dis like '%MIRAFLORES%'
select * from m_distritos where des_dis like '%TRIUNFO%'
select * from m_distritos where des_dis like '%SALVADOR%'

update m_distritos set cod_zona='ZONA 05' where cod_dis like '%L04%'
update m_distritos set cod_zona='ZONA 05' where cod_dis like '%L09%'
update m_distritos set cod_zona='ZONA 05' where cod_dis like '%L29%'
update m_distritos set cod_zona='ZONA 05' where cod_dis like '%L35%'
update m_distritos set cod_zona='ZONA 05' where cod_dis like '%L42%'

-- Ate, Sta. Anita, Agustino, La Victoria, San Luis /// Chosica, Lurigancho Chaclacayo
select * from m_distritos where des_dis like '%ATE%'
select * from m_distritos where des_dis like '%ANITA%'
select * from m_distritos where des_dis like '%AGUSTINO%'
select * from m_distritos where des_dis like '%VICTORIA%'
select * from m_distritos where des_dis like '%LUIS%'
select * from m_distritos where des_dis like '%CHOSICA%'
select * from m_distritos where des_dis like '%LURIGANCHO%'
select * from m_distritos where des_dis like '%CHACLAC%'

update m_distritos set cod_zona='ZONA 06' where cod_dis='L03'
update m_distritos set cod_zona='ZONA 06' where cod_dis='L43'
update m_distritos set cod_zona='ZONA 06' where cod_dis='L10'
update m_distritos set cod_zona='ZONA 06' where cod_dis='L13'
update m_distritos set cod_zona='ZONA 06' where cod_dis='L30'
update m_distritos set cod_zona='ZONA 06' where cod_dis='L44'
update m_distritos set cod_zona='ZONA 06' where cod_dis='L15'
update m_distritos set cod_zona='ZONA 06' where cod_dis='L08'

-- San Miguel, Madalena----
select * from m_distritos where des_dis like '%MIGUEL%'
select * from m_distritos where des_dis like '%MAGDALENA%'

update m_distritos set cod_zona='ZONA 07' where cod_dis='L32'
update m_distritos set cod_zona='ZONA 07' where cod_dis='L17'

-- P.Libre, J.M, Lince, Breña ----
select * from m_distritos where des_dis like '%LIBRE%'
select * from m_distritos where des_dis like '%LINCE%'
select * from m_distritos where des_dis like '%BRENA%'
select * from m_distritos where des_dis like '%MARIA%'

update m_distritos set cod_zona='ZONA 08' where cod_dis='L21'
update m_distritos set cod_zona='ZONA 08' where cod_dis='L14'
update m_distritos set cod_zona='ZONA 08' where cod_dis='L05'
update m_distritos set cod_zona='ZONA 08' where cod_dis='L11'

-- Callao, Bellavista, La Punta, La Perla, Ventanilla
select * from m_distritos where des_dis like '%CALLAO%'
select * from m_distritos where des_dis like '%BELLAVIS%'
select * from m_distritos where des_dis like '%PUNTA%'
select * from m_distritos where des_dis like '%PERLA%'
select * from m_distritos where des_dis like '%VENTANILL%'

update m_distritos set cod_zona='ZONA 09' where cod_dis='C01'
update m_distritos set cod_zona='ZONA 09' where cod_dis='C02'
update m_distritos set cod_zona='ZONA 09' where cod_dis='C05'
update m_distritos set cod_zona='ZONA 09' where cod_dis='C04'
update m_distritos set cod_zona='ZONA 09' where cod_dis='C06'

-- SM.P, Lima /// Pte Piedra Ancon
select * from m_distritos where des_dis like '%MARTIN%'
select * from m_distritos where des_dis like '%LIMA%'
select * from m_distritos where des_dis like '%PIEDRA%'
select * from m_distritos where des_dis like '%ANCON%'
-------------------
update m_distritos set cod_zona='ZONA 10' where cod_dis='L31'
update m_distritos set cod_zona='ZONA 10' where cod_dis='L01'
update m_distritos set cod_zona='ZONA 10' where cod_dis='L22'
update m_distritos set cod_zona='ZONA 10' where cod_dis='L02'


-- Los Olivos, Comas, Independiencia, Rimac/// SJL, Carabayllo
select * from m_distritos where des_dis like '%OLIVOS%'
select * from m_distritos where des_dis like '%COMAS%'
select * from m_distritos where des_dis like '%INDEPENDENCI%'
select * from m_distritos where des_dis like '%RIMAC%'
select * from m_distritos where des_dis like '%LURIGANCH%'
select * from m_distritos where des_dis like '%CARABAYLLO%'
-------------------
update m_distritos set cod_zona='ZONA 11' where cod_dis='L39'
update m_distritos set cod_zona='ZONA 11' where cod_dis='L07'
update m_distritos set cod_zona='ZONA 11' where cod_dis='L28'
update m_distritos set cod_zona='ZONA 11' where cod_dis='L25'
update m_distritos set cod_zona='ZONA 11' where cod_dis='L36'
update m_distritos set cod_zona='ZONA 11' where cod_dis='L06'

SELECT * FROM M_DISTRITOS  where cod_zona='ZONA 6'







''------------- tabla historico
create table historico_prog_doctorxturno(
cod_asig integer NOT NULL,
nom_usu character(15),
fecha_creacion date,
hora_creacion time without time zone,
ip_agente character(25),
CONSTRAINT historico_prog_doctorxturno_pkey PRIMARY KEY (cod_asig)
);