{ DATABASE isu  delimiter | }

grant dba to "developer";
grant dba to "sestevez";
grant dba to "gesquibel";
grant dba to "cgalvan";











{ TABLE "cgalvan".cooperativa row size = 4 number of columns = 1 index size = 9 }
{ unload file name = coope00100.unl number of rows = 0 }

create table "cgalvan".cooperativa 
  (
    serie serial not null 
  );

revoke all on "cgalvan".cooperativa from "public" as "cgalvan";

{ TABLE "cgalvan".retira row size = 22 number of columns = 4 index size = 35 }
{ unload file name = retir00101.unl number of rows = 0 }

create table "cgalvan".retira 
  (
    fecha_retira date not null ,
    cantidad decimal(16) not null ,
    serie_coop integer not null ,
    num_tanque integer not null ,
    primary key (fecha_retira,serie_coop,num_tanque)  constraint "cgalvan".retira
  );

revoke all on "cgalvan".retira from "public" as "cgalvan";

{ TABLE "sestevez".animal row size = 42 number of columns = 7 index size = 9 }
{ unload file name = anima00103.unl number of rows = 2 }

create table "sestevez".animal 
  (
    numero integer not null ,
    raza char(20) not null ,
    lugar integer not null ,
    activo smallint not null ,
    nacimiento date not null ,
    progenitor_hembra integer,
    progenitor_macho integer,
    primary key (numero)  constraint "sestevez".numero
  );

revoke all on "sestevez".animal from "public" as "sestevez";

{ TABLE "cgalvan".almacena row size = 41 number of columns = 5 index size = 70 }
{ unload file name = almac00104.unl number of rows = 0 }

create table "cgalvan".almacena 
  (
    fecha date not null ,
    num_serie integer not null ,
    tipo char(20) not null ,
    cantidad decimal(16) not null ,
    hora datetime hour to minute not null ,
    primary key (tipo,num_serie,fecha,hora)  constraint "sestevez".almacena_pk
  );

revoke all on "cgalvan".almacena from "public" as "cgalvan";

{ TABLE "cgalvan".leche row size = 20 number of columns = 1 index size = 25 }
{ unload file name = leche00105.unl number of rows = 0 }

create table "cgalvan".leche 
  (
    tipo char(20) not null ,
    primary key (tipo)  constraint "cgalvan".leche
  );

revoke all on "cgalvan".leche from "public" as "cgalvan";

{ TABLE "gesquibel".proporciona row size = 16 number of columns = 4 index size = 
              35 }
{ unload file name = propo00106.unl number of rows = 0 }

create table "gesquibel".proporciona 
  (
    num integer not null ,
    serie integer not null ,
    cantidad integer not null ,
    fecha date not null ,
    primary key (num,serie,fecha)  constraint "sestevez".proporciona
  );

revoke all on "gesquibel".proporciona from "public" as "gesquibel";

{ TABLE "sestevez".cria row size = 22 number of columns = 5 index size = 26 }
{ unload file name = cria_00107.unl number of rows = 0 }

create table "sestevez".cria 
  (
    numero_cria integer not null ,
    fecha date not null ,
    numero_vaca integer not null ,
    numero_macho integer not null ,
    sexo char(6) not null ,
    primary key (numero_cria)  constraint "sestevez".num_cria
  );

revoke all on "sestevez".cria from "public" as "sestevez";

{ TABLE "gesquibel".tiene row size = 8 number of columns = 2 index size = 31 }
{ unload file name = tiene00108.unl number of rows = 0 }

create table "gesquibel".tiene 
  (
    ci integer not null ,
    serie integer not null ,
    primary key (ci,serie)  constraint "gesquibel".tiene
  );

revoke all on "gesquibel".tiene from "public" as "gesquibel";

{ TABLE "sestevez".campo_de_recria row size = 4 number of columns = 1 index size 
              = 9 }
{ unload file name = campo00109.unl number of rows = 0 }

create table "sestevez".campo_de_recria 
  (
    num_camp_re integer not null ,
    primary key (num_camp_re)  constraint "sestevez".num_ca_re_pk
  );

revoke all on "sestevez".campo_de_recria from "public" as "sestevez";

{ TABLE "sestevez".va row size = 12 number of columns = 3 index size = 18 }
{ unload file name = va___00110.unl number of rows = 0 }

create table "sestevez".va 
  (
    numero_cria integer not null ,
    num_camp_re integer not null ,
    fecha date not null ,
    primary key (numero_cria)  constraint "sestevez".num_cria_va_pk
  );

revoke all on "sestevez".va from "public" as "sestevez";

{ TABLE "gesquibel".se_da row size = 19 number of columns = 5 index size = 38 }
{ unload file name = se_da00111.unl number of rows = 0 }

create table "gesquibel".se_da 
  (
    num_alimento integer not null ,
    num_animal integer not null ,
    cantidad integer not null ,
    fecha date not null ,
    hora datetime hour to minute not null ,
    primary key (num_alimento,num_animal,fecha,hora)  constraint "sestevez".se_da
  );

revoke all on "gesquibel".se_da from "public" as "gesquibel";

{ TABLE "sestevez".retorna row size = 12 number of columns = 3 index size = 18 }
{ unload file name = retor00112.unl number of rows = 0 }

create table "sestevez".retorna 
  (
    numero_animal integer not null ,
    fecha_vuelta date not null ,
    num_camp_re integer not null ,
    primary key (numero_animal)  constraint "sestevez".num_ani_ret_pk
  );

revoke all on "sestevez".retorna from "public" as "sestevez";

{ TABLE "gesquibel".alimento row size = 55 number of columns = 2 index size = 9 }
{ unload file name = alime00113.unl number of rows = 0 }

create table "gesquibel".alimento 
  (
    num serial not null ,
    tipo varchar(50,1) not null ,
    primary key (num)  constraint "gesquibel".num_alimento
  );

revoke all on "gesquibel".alimento from "public" as "gesquibel";

{ TABLE "gesquibel".persona row size = 194 number of columns = 7 index size = 9 }
{ unload file name = perso00114.unl number of rows = 0 }

create table "gesquibel".persona 
  (
    ci integer not null ,
    nacimiento date not null ,
    cargo varchar(50,1) not null ,
    nombre varchar(50,1) not null ,
    sexo varchar(50,1) not null ,
    login varchar(30,5) not null ,
    activo smallint not null ,
    primary key (ci)  constraint "gesquibel".ci_personal
  );

revoke all on "gesquibel".persona from "public" as "gesquibel";

{ TABLE "gesquibel".personatel row size = 8 number of columns = 2 index size = 22 
              }
{ unload file name = perso00116.unl number of rows = 0 }

create table "gesquibel".personatel 
  (
    ci integer not null ,
    telefono integer not null ,
    primary key (ci,telefono)  constraint "gesquibel".ci_telefono
  );

revoke all on "gesquibel".personatel from "public" as "gesquibel";

{ TABLE "cgalvan".hembra row size = 4 number of columns = 1 index size = 9 }
{ unload file name = hembr00117.unl number of rows = 0 }

create table "cgalvan".hembra 
  (
    id_hembra integer not null ,
    primary key (id_hembra)  constraint "cgalvan".hembra
  );

revoke all on "cgalvan".hembra from "public" as "cgalvan";

{ TABLE "sestevez".macho row size = 8 number of columns = 2 index size = 9 }
{ unload file name = macho00118.unl number of rows = 0 }

create table "sestevez".macho 
  (
    id_macho integer not null ,
    castrado integer not null ,
    primary key (id_macho)  constraint "sestevez".id_macho_pk
  );

revoke all on "sestevez".macho from "public" as "sestevez";

{ TABLE "gesquibel".pasa row size = 16 number of columns = 4 index size = 31 }
{ unload file name = pasa_00119.unl number of rows = 0 }

create table "gesquibel".pasa 
  (
    id_hembra integer not null ,
    num_estado integer not null ,
    fecha_inicio date not null ,
    fecha_fin date not null ,
    primary key (id_hembra,num_estado)  constraint "gesquibel".pasa_r
  );

revoke all on "gesquibel".pasa from "public" as "gesquibel";

{ TABLE "cgalvan".produce row size = 71 number of columns = 11 index size = 70 }
{ unload file name = produ00120.unl number of rows = 0 }

create table "cgalvan".produce 
  (
    fecha_produce date not null ,
    hora_ordenie datetime hour to minute not null ,
    tipo_leche char(20) not null ,
    num_lote integer not null ,
    cantidad decimal(16) not null ,
    recuento_bacteriano integer not null ,
    grasa decimal(16) not null ,
    proteina integer not null ,
    celulas_somaticas integer not null ,
    urea integer not null ,
    id_hembra integer not null ,
    primary key (hora_ordenie,id_hembra,tipo_leche,fecha_produce)  constraint "cgalvan".produce
  );

revoke all on "cgalvan".produce from "public" as "cgalvan";

{ TABLE "sestevez".vuelve row size = 12 number of columns = 3 index size = 18 }
{ unload file name = vuelv00121.unl number of rows = 0 }

create table "sestevez".vuelve 
  (
    id_hembra integer not null ,
    num_camp_re integer not null ,
    fecha_vuelta date not null ,
    primary key (id_hembra)  constraint "sestevez".id_hem_vuelve_pk
  );

revoke all on "sestevez".vuelve from "public" as "sestevez";

{ TABLE "gesquibel".estado row size = 55 number of columns = 2 index size = 9 }
{ unload file name = estad00122.unl number of rows = 0 }

create table "gesquibel".estado 
  (
    num serial not null ,
    nombre varchar(50,1) not null 
  );

revoke all on "gesquibel".estado from "public" as "gesquibel";

{ TABLE "sestevez".hay row size = 8 number of columns = 2 index size = 18 }
{ unload file name = hay__00123.unl number of rows = 0 }

create table "sestevez".hay 
  (
    numero_animal integer not null ,
    serie_tambo integer not null ,
    primary key (numero_animal)  constraint "sestevez".hay_pk
  );

revoke all on "sestevez".hay from "public" as "sestevez";

{ TABLE "sestevez".evento row size = 12 number of columns = 3 index size = 35 }
{ unload file name = event00125.unl number of rows = 0 }

create table "sestevez".evento 
  (
    id_hembra integer not null ,
    id_macho integer not null ,
    fecha date not null ,
    primary key (id_hembra,id_macho,fecha)  constraint "sestevez".evento_pk
  );

revoke all on "sestevez".evento from "public" as "sestevez";

{ TABLE "cgalvan".tanque row size = 14 number of columns = 2 index size = 9 }
{ unload file name = tanqu00127.unl number of rows = 0 }

create table "cgalvan".tanque 
  (
    num_serie integer not null ,
    capacidad decimal(16) not null ,
    primary key (num_serie)  constraint "sestevez".tanque_pk
  );

revoke all on "cgalvan".tanque from "public" as "cgalvan";

{ TABLE "sestevez".posee row size = 8 number of columns = 2 index size = 18 }
{ unload file name = posee00129.unl number of rows = 0 }

create table "sestevez".posee 
  (
    serie_tambo integer not null ,
    serie_tanque integer not null ,
    primary key (serie_tanque)  constraint "sestevez".posee_pk
  );

revoke all on "sestevez".posee from "public" as "sestevez";

{ TABLE "gesquibel".tambo row size = 63 number of columns = 4 index size = 9 }
{ unload file name = tambo00130.unl number of rows = 0 }

create table "gesquibel".tambo 
  (
    serie serial not null ,
    establecimiento varchar(50,1) not null ,
    hectareas integer not null ,
    ganado_max integer not null 
  );

revoke all on "gesquibel".tambo from "public" as "gesquibel";

{ TABLE "sestevez".ordenie row size = 10 number of columns = 3 index size = 9 }
{ unload file name = orden00131.unl number of rows = 0 }

create table "sestevez".ordenie 
  (
    numero_ordenie integer not null ,
    hora_inicio datetime hour to minute not null ,
    hora_fin datetime hour to minute not null ,
    primary key (numero_ordenie)  constraint "sestevez".ordenie_pk
  );

revoke all on "sestevez".ordenie from "public" as "sestevez";

{ TABLE "sestevez".supervisa row size = 8 number of columns = 2 index size = 31 }
{ unload file name = super00132.unl number of rows = 0 }

create table "sestevez".supervisa 
  (
    ci integer not null ,
    num_ordenie integer not null ,
    primary key (num_ordenie,ci)  constraint "sestevez".supervisa_pk
  );

revoke all on "sestevez".supervisa from "public" as "sestevez";

{ TABLE "sestevez".controla row size = 123 number of columns = 5 index size = 35 
              }
{ unload file name = contr00133.unl number of rows = 0 }

create table "sestevez".controla 
  (
    num_animal integer not null ,
    ci_personal integer not null ,
    peso decimal(16) not null ,
    vacuna varchar(100,1) not null ,
    fecha date not null ,
    primary key (num_animal,ci_personal,fecha)  constraint "sestevez".controla_pk
  );

revoke all on "sestevez".controla from "public" as "sestevez";




grant select on "cgalvan".cooperativa to "isu_adm_est" as "cgalvan";
grant update on "cgalvan".cooperativa to "isu_adm_est" as "cgalvan";
grant insert on "cgalvan".cooperativa to "isu_adm_est" as "cgalvan";
grant select on "cgalvan".cooperativa to "isu_adm_sis" as "cgalvan";
grant update on "cgalvan".cooperativa to "isu_adm_sis" as "cgalvan";
grant insert on "cgalvan".cooperativa to "isu_adm_sis" as "cgalvan";
grant delete on "cgalvan".cooperativa to "isu_adm_sis" as "cgalvan";
grant select on "cgalvan".cooperativa to "isu_auxiliar" as "cgalvan";
grant update on "cgalvan".cooperativa to "isu_auxiliar" as "cgalvan";
grant insert on "cgalvan".cooperativa to "isu_auxiliar" as "cgalvan";
grant select on "cgalvan".cooperativa to "isu_gerente" as "cgalvan";
grant update on "cgalvan".cooperativa to "isu_gerente" as "cgalvan";
grant insert on "cgalvan".cooperativa to "isu_gerente" as "cgalvan";
grant select on "cgalvan".cooperativa to "gesquibel" as "cgalvan";
grant update on "cgalvan".cooperativa to "gesquibel" as "cgalvan";
grant insert on "cgalvan".cooperativa to "gesquibel" as "cgalvan";
grant select on "cgalvan".cooperativa to "sestevez" as "cgalvan";
grant update on "cgalvan".cooperativa to "sestevez" as "cgalvan";
grant insert on "cgalvan".cooperativa to "sestevez" as "cgalvan";
grant select on "cgalvan".retira to "isu_adm_est" as "cgalvan";
grant update on "cgalvan".retira to "isu_adm_est" as "cgalvan";
grant insert on "cgalvan".retira to "isu_adm_est" as "cgalvan";
grant select on "cgalvan".retira to "gesquibel" as "cgalvan";
grant update on "cgalvan".retira to "gesquibel" as "cgalvan";
grant insert on "cgalvan".retira to "gesquibel" as "cgalvan";
grant select on "cgalvan".retira to "isu_adm_sis" as "cgalvan";
grant update on "cgalvan".retira to "isu_adm_sis" as "cgalvan";
grant insert on "cgalvan".retira to "isu_adm_sis" as "cgalvan";
grant delete on "cgalvan".retira to "isu_adm_sis" as "cgalvan";
grant select on "cgalvan".retira to "sestevez" as "cgalvan";
grant update on "cgalvan".retira to "sestevez" as "cgalvan";
grant insert on "cgalvan".retira to "sestevez" as "cgalvan";
grant select on "cgalvan".retira to "isu_auxiliar" as "cgalvan";
grant update on "cgalvan".retira to "isu_auxiliar" as "cgalvan";
grant insert on "cgalvan".retira to "isu_auxiliar" as "cgalvan";
grant select on "cgalvan".retira to "isu_gerente" as "cgalvan";
grant update on "cgalvan".retira to "isu_gerente" as "cgalvan";
grant insert on "cgalvan".retira to "isu_gerente" as "cgalvan";
grant select on "sestevez".animal to "isu_adm_est" as "sestevez";
grant update on "sestevez".animal to "isu_adm_est" as "sestevez";
grant insert on "sestevez".animal to "isu_adm_est" as "sestevez";
grant delete on "sestevez".animal to "isu_adm_est" as "sestevez";
grant select on "sestevez".animal to "isu_auxiliar" as "sestevez";
grant update on "sestevez".animal to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".animal to "isu_auxiliar" as "sestevez";
grant select on "sestevez".animal to "isu_adm_sis" as "sestevez";
grant update on "sestevez".animal to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".animal to "isu_adm_sis" as "sestevez";
grant delete on "sestevez".animal to "isu_adm_sis" as "sestevez";
grant select on "sestevez".animal to "isu_gerent" as "sestevez";
grant update on "sestevez".animal to "isu_gerent" as "sestevez";
grant insert on "sestevez".animal to "isu_gerent" as "sestevez";
grant delete on "sestevez".animal to "isu_gerent" as "sestevez";
grant select on "sestevez".animal to "cgalvan" as "sestevez";
grant update on "sestevez".animal to "cgalvan" as "sestevez";
grant insert on "sestevez".animal to "cgalvan" as "sestevez";
grant delete on "sestevez".animal to "cgalvan" as "sestevez";
grant alter on "sestevez".animal to "cgalvan" as "sestevez";
grant select on "sestevez".animal to "gesquibel" as "sestevez";
grant update on "sestevez".animal to "gesquibel" as "sestevez";
grant insert on "sestevez".animal to "gesquibel" as "sestevez";
grant delete on "sestevez".animal to "gesquibel" as "sestevez";
grant alter on "sestevez".animal to "gesquibel" as "sestevez";
grant select on "cgalvan".almacena to "isu_gerente" as "cgalvan";
grant update on "cgalvan".almacena to "isu_gerente" as "cgalvan";
grant insert on "cgalvan".almacena to "isu_gerente" as "cgalvan";
grant select on "cgalvan".almacena to "sestevez" as "cgalvan";
grant update on "cgalvan".almacena to "sestevez" as "cgalvan";
grant insert on "cgalvan".almacena to "sestevez" as "cgalvan";
grant select on "cgalvan".almacena to "isu_auxiliar" as "cgalvan";
grant update on "cgalvan".almacena to "isu_auxiliar" as "cgalvan";
grant insert on "cgalvan".almacena to "isu_auxiliar" as "cgalvan";
grant select on "cgalvan".almacena to "gesquibel" as "cgalvan";
grant update on "cgalvan".almacena to "gesquibel" as "cgalvan";
grant insert on "cgalvan".almacena to "gesquibel" as "cgalvan";
grant select on "cgalvan".almacena to "isu_adm_sis" as "cgalvan";
grant update on "cgalvan".almacena to "isu_adm_sis" as "cgalvan";
grant insert on "cgalvan".almacena to "isu_adm_sis" as "cgalvan";
grant delete on "cgalvan".almacena to "isu_adm_sis" as "cgalvan";
grant select on "cgalvan".almacena to "isu_adm_est" as "cgalvan";
grant update on "cgalvan".almacena to "isu_adm_est" as "cgalvan";
grant insert on "cgalvan".almacena to "isu_adm_est" as "cgalvan";
grant select on "cgalvan".leche to "sestevez" as "cgalvan";
grant update on "cgalvan".leche to "sestevez" as "cgalvan";
grant insert on "cgalvan".leche to "sestevez" as "cgalvan";
grant select on "cgalvan".leche to "isu_adm_est" as "cgalvan";
grant update on "cgalvan".leche to "isu_adm_est" as "cgalvan";
grant insert on "cgalvan".leche to "isu_adm_est" as "cgalvan";
grant select on "cgalvan".leche to "isu_adm_sis" as "cgalvan";
grant update on "cgalvan".leche to "isu_adm_sis" as "cgalvan";
grant insert on "cgalvan".leche to "isu_adm_sis" as "cgalvan";
grant delete on "cgalvan".leche to "isu_adm_sis" as "cgalvan";
grant select on "cgalvan".leche to "isu_auxiliar" as "cgalvan";
grant update on "cgalvan".leche to "isu_auxiliar" as "cgalvan";
grant insert on "cgalvan".leche to "isu_auxiliar" as "cgalvan";
grant select on "cgalvan".leche to "isu_gerente" as "cgalvan";
grant update on "cgalvan".leche to "isu_gerente" as "cgalvan";
grant insert on "cgalvan".leche to "isu_gerente" as "cgalvan";
grant select on "cgalvan".leche to "gesquibel" as "cgalvan";
grant update on "cgalvan".leche to "gesquibel" as "cgalvan";
grant insert on "cgalvan".leche to "gesquibel" as "cgalvan";
grant select on "gesquibel".proporciona to "isu_adm_sis" as "gesquibel";
grant update on "gesquibel".proporciona to "isu_adm_sis" as "gesquibel";
grant insert on "gesquibel".proporciona to "isu_adm_sis" as "gesquibel";
grant delete on "gesquibel".proporciona to "isu_adm_sis" as "gesquibel";
grant select on "gesquibel".proporciona to "isu_adm_est" as "gesquibel";
grant update on "gesquibel".proporciona to "isu_adm_est" as "gesquibel";
grant insert on "gesquibel".proporciona to "isu_adm_est" as "gesquibel";
grant delete on "gesquibel".proporciona to "isu_adm_est" as "gesquibel";
grant select on "gesquibel".proporciona to "sestevez" as "gesquibel";
grant update on "gesquibel".proporciona to "sestevez" as "gesquibel";
grant insert on "gesquibel".proporciona to "sestevez" as "gesquibel";
grant delete on "gesquibel".proporciona to "sestevez" as "gesquibel";
grant index on "gesquibel".proporciona to "sestevez" as "gesquibel";
grant alter on "gesquibel".proporciona to "sestevez" as "gesquibel";
grant references on "gesquibel".proporciona to "sestevez" as "gesquibel";
grant select on "gesquibel".proporciona to "isu_auxiliar" as "gesquibel";
grant select on "gesquibel".proporciona to "isu_gerente" as "gesquibel";
grant update on "gesquibel".proporciona to "isu_gerente" as "gesquibel";
grant insert on "gesquibel".proporciona to "isu_gerente" as "gesquibel";
grant delete on "gesquibel".proporciona to "isu_gerente" as "gesquibel";
grant select on "gesquibel".proporciona to "cgalvan" as "gesquibel";
grant update on "gesquibel".proporciona to "cgalvan" as "gesquibel";
grant insert on "gesquibel".proporciona to "cgalvan" as "gesquibel";
grant delete on "gesquibel".proporciona to "cgalvan" as "gesquibel";
grant index on "gesquibel".proporciona to "cgalvan" as "gesquibel";
grant alter on "gesquibel".proporciona to "cgalvan" as "gesquibel";
grant references on "gesquibel".proporciona to "cgalvan" as "gesquibel";
grant select on "sestevez".cria to "cgalvan" as "sestevez";
grant update on "sestevez".cria to "cgalvan" as "sestevez";
grant insert on "sestevez".cria to "cgalvan" as "sestevez";
grant delete on "sestevez".cria to "cgalvan" as "sestevez";
grant alter on "sestevez".cria to "cgalvan" as "sestevez";
grant select on "sestevez".cria to "gesquibel" as "sestevez";
grant update on "sestevez".cria to "gesquibel" as "sestevez";
grant insert on "sestevez".cria to "gesquibel" as "sestevez";
grant delete on "sestevez".cria to "gesquibel" as "sestevez";
grant alter on "sestevez".cria to "gesquibel" as "sestevez";
grant select on "sestevez".cria to "isu_gerent" as "sestevez";
grant update on "sestevez".cria to "isu_gerent" as "sestevez";
grant insert on "sestevez".cria to "isu_gerent" as "sestevez";
grant delete on "sestevez".cria to "isu_gerent" as "sestevez";
grant select on "sestevez".cria to "isu_auxiliar" as "sestevez";
grant update on "sestevez".cria to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".cria to "isu_auxiliar" as "sestevez";
grant select on "sestevez".cria to "isu_adm_est" as "sestevez";
grant update on "sestevez".cria to "isu_adm_est" as "sestevez";
grant insert on "sestevez".cria to "isu_adm_est" as "sestevez";
grant delete on "sestevez".cria to "isu_adm_est" as "sestevez";
grant select on "sestevez".cria to "isu_adm_sis" as "sestevez";
grant update on "sestevez".cria to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".cria to "isu_adm_sis" as "sestevez";
grant delete on "sestevez".cria to "isu_adm_sis" as "sestevez";
grant select on "gesquibel".tiene to "cgalvan" as "gesquibel";
grant update on "gesquibel".tiene to "cgalvan" as "gesquibel";
grant insert on "gesquibel".tiene to "cgalvan" as "gesquibel";
grant delete on "gesquibel".tiene to "cgalvan" as "gesquibel";
grant index on "gesquibel".tiene to "cgalvan" as "gesquibel";
grant alter on "gesquibel".tiene to "cgalvan" as "gesquibel";
grant references on "gesquibel".tiene to "cgalvan" as "gesquibel";
grant select on "gesquibel".tiene to "isu_gerente" as "gesquibel";
grant select on "gesquibel".tiene to "sestevez" as "gesquibel";
grant update on "gesquibel".tiene to "sestevez" as "gesquibel";
grant insert on "gesquibel".tiene to "sestevez" as "gesquibel";
grant delete on "gesquibel".tiene to "sestevez" as "gesquibel";
grant index on "gesquibel".tiene to "sestevez" as "gesquibel";
grant alter on "gesquibel".tiene to "sestevez" as "gesquibel";
grant references on "gesquibel".tiene to "sestevez" as "gesquibel";
grant select on "gesquibel".tiene to "isu_adm_sis" as "gesquibel";
grant update on "gesquibel".tiene to "isu_adm_sis" as "gesquibel";
grant insert on "gesquibel".tiene to "isu_adm_sis" as "gesquibel";
grant delete on "gesquibel".tiene to "isu_adm_sis" as "gesquibel";
grant select on "gesquibel".tiene to "isu_adm_est" as "gesquibel";
grant select on "sestevez".campo_de_recria to "isu_auxiliar" as "sestevez";
grant update on "sestevez".campo_de_recria to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".campo_de_recria to "isu_auxiliar" as "sestevez";
grant select on "sestevez".campo_de_recria to "isu_gerent" as "sestevez";
grant update on "sestevez".campo_de_recria to "isu_gerent" as "sestevez";
grant insert on "sestevez".campo_de_recria to "isu_gerent" as "sestevez";
grant delete on "sestevez".campo_de_recria to "isu_gerent" as "sestevez";
grant select on "sestevez".campo_de_recria to "isu_adm_sis" as "sestevez";
grant update on "sestevez".campo_de_recria to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".campo_de_recria to "isu_adm_sis" as "sestevez";
grant delete on "sestevez".campo_de_recria to "isu_adm_sis" as "sestevez";
grant select on "sestevez".campo_de_recria to "cgalvan" as "sestevez";
grant update on "sestevez".campo_de_recria to "cgalvan" as "sestevez";
grant insert on "sestevez".campo_de_recria to "cgalvan" as "sestevez";
grant delete on "sestevez".campo_de_recria to "cgalvan" as "sestevez";
grant alter on "sestevez".campo_de_recria to "cgalvan" as "sestevez";
grant select on "sestevez".campo_de_recria to "isu_adm_est" as "sestevez";
grant update on "sestevez".campo_de_recria to "isu_adm_est" as "sestevez";
grant insert on "sestevez".campo_de_recria to "isu_adm_est" as "sestevez";
grant delete on "sestevez".campo_de_recria to "isu_adm_est" as "sestevez";
grant select on "sestevez".campo_de_recria to "gesquibel" as "sestevez";
grant update on "sestevez".campo_de_recria to "gesquibel" as "sestevez";
grant insert on "sestevez".campo_de_recria to "gesquibel" as "sestevez";
grant delete on "sestevez".campo_de_recria to "gesquibel" as "sestevez";
grant alter on "sestevez".campo_de_recria to "gesquibel" as "sestevez";
grant select on "sestevez".va to "isu_adm_est" as "sestevez";
grant update on "sestevez".va to "isu_adm_est" as "sestevez";
grant insert on "sestevez".va to "isu_adm_est" as "sestevez";
grant delete on "sestevez".va to "isu_adm_est" as "sestevez";
grant select on "sestevez".va to "isu_auxiliar" as "sestevez";
grant update on "sestevez".va to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".va to "isu_auxiliar" as "sestevez";
grant select on "sestevez".va to "isu_adm_sis" as "sestevez";
grant update on "sestevez".va to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".va to "isu_adm_sis" as "sestevez";
grant delete on "sestevez".va to "isu_adm_sis" as "sestevez";
grant select on "sestevez".va to "isu_gerent" as "sestevez";
grant update on "sestevez".va to "isu_gerent" as "sestevez";
grant insert on "sestevez".va to "isu_gerent" as "sestevez";
grant delete on "sestevez".va to "isu_gerent" as "sestevez";
grant select on "sestevez".va to "cgalvan" as "sestevez";
grant update on "sestevez".va to "cgalvan" as "sestevez";
grant insert on "sestevez".va to "cgalvan" as "sestevez";
grant delete on "sestevez".va to "cgalvan" as "sestevez";
grant alter on "sestevez".va to "cgalvan" as "sestevez";
grant select on "sestevez".va to "gesquibel" as "sestevez";
grant update on "sestevez".va to "gesquibel" as "sestevez";
grant insert on "sestevez".va to "gesquibel" as "sestevez";
grant delete on "sestevez".va to "gesquibel" as "sestevez";
grant alter on "sestevez".va to "gesquibel" as "sestevez";
grant select on "gesquibel".se_da to "sestevez" as "gesquibel";
grant update on "gesquibel".se_da to "sestevez" as "gesquibel";
grant insert on "gesquibel".se_da to "sestevez" as "gesquibel";
grant delete on "gesquibel".se_da to "sestevez" as "gesquibel";
grant index on "gesquibel".se_da to "sestevez" as "gesquibel";
grant alter on "gesquibel".se_da to "sestevez" as "gesquibel";
grant references on "gesquibel".se_da to "sestevez" as "gesquibel";
grant select on "gesquibel".se_da to "isu_gerente" as "gesquibel";
grant update on "gesquibel".se_da to "isu_gerente" as "gesquibel";
grant insert on "gesquibel".se_da to "isu_gerente" as "gesquibel";
grant delete on "gesquibel".se_da to "isu_gerente" as "gesquibel";
grant select on "gesquibel".se_da to "isu_auxiliar" as "gesquibel";
grant update on "gesquibel".se_da to "isu_auxiliar" as "gesquibel";
grant insert on "gesquibel".se_da to "isu_auxiliar" as "gesquibel";
grant select on "gesquibel".se_da to "cgalvan" as "gesquibel";
grant update on "gesquibel".se_da to "cgalvan" as "gesquibel";
grant insert on "gesquibel".se_da to "cgalvan" as "gesquibel";
grant delete on "gesquibel".se_da to "cgalvan" as "gesquibel";
grant index on "gesquibel".se_da to "cgalvan" as "gesquibel";
grant alter on "gesquibel".se_da to "cgalvan" as "gesquibel";
grant references on "gesquibel".se_da to "cgalvan" as "gesquibel";
grant select on "gesquibel".se_da to "isu_adm_sis" as "gesquibel";
grant update on "gesquibel".se_da to "isu_adm_sis" as "gesquibel";
grant insert on "gesquibel".se_da to "isu_adm_sis" as "gesquibel";
grant delete on "gesquibel".se_da to "isu_adm_sis" as "gesquibel";
grant select on "gesquibel".se_da to "isu_adm_est" as "gesquibel";
grant update on "gesquibel".se_da to "isu_adm_est" as "gesquibel";
grant insert on "gesquibel".se_da to "isu_adm_est" as "gesquibel";
grant delete on "gesquibel".se_da to "isu_adm_est" as "gesquibel";
grant select on "sestevez".retorna to "isu_adm_est" as "sestevez";
grant update on "sestevez".retorna to "isu_adm_est" as "sestevez";
grant insert on "sestevez".retorna to "isu_adm_est" as "sestevez";
grant delete on "sestevez".retorna to "isu_adm_est" as "sestevez";
grant select on "sestevez".retorna to "gesquibel" as "sestevez";
grant update on "sestevez".retorna to "gesquibel" as "sestevez";
grant insert on "sestevez".retorna to "gesquibel" as "sestevez";
grant delete on "sestevez".retorna to "gesquibel" as "sestevez";
grant alter on "sestevez".retorna to "gesquibel" as "sestevez";
grant select on "sestevez".retorna to "cgalvan" as "sestevez";
grant update on "sestevez".retorna to "cgalvan" as "sestevez";
grant insert on "sestevez".retorna to "cgalvan" as "sestevez";
grant delete on "sestevez".retorna to "cgalvan" as "sestevez";
grant alter on "sestevez".retorna to "cgalvan" as "sestevez";
grant select on "sestevez".retorna to "isu_gerent" as "sestevez";
grant update on "sestevez".retorna to "isu_gerent" as "sestevez";
grant insert on "sestevez".retorna to "isu_gerent" as "sestevez";
grant delete on "sestevez".retorna to "isu_gerent" as "sestevez";
grant select on "sestevez".retorna to "isu_auxiliar" as "sestevez";
grant update on "sestevez".retorna to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".retorna to "isu_auxiliar" as "sestevez";
grant select on "sestevez".retorna to "isu_adm_sis" as "sestevez";
grant update on "sestevez".retorna to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".retorna to "isu_adm_sis" as "sestevez";
grant delete on "sestevez".retorna to "isu_adm_sis" as "sestevez";
grant select on "gesquibel".alimento to "isu_adm_sis" as "gesquibel";
grant update on "gesquibel".alimento to "isu_adm_sis" as "gesquibel";
grant insert on "gesquibel".alimento to "isu_adm_sis" as "gesquibel";
grant delete on "gesquibel".alimento to "isu_adm_sis" as "gesquibel";
grant select on "gesquibel".alimento to "isu_adm_est" as "gesquibel";
grant update on "gesquibel".alimento to "isu_adm_est" as "gesquibel";
grant insert on "gesquibel".alimento to "isu_adm_est" as "gesquibel";
grant delete on "gesquibel".alimento to "isu_adm_est" as "gesquibel";
grant select on "gesquibel".alimento to "isu_auxiliar" as "gesquibel";
grant update on "gesquibel".alimento to "isu_auxiliar" as "gesquibel";
grant insert on "gesquibel".alimento to "isu_auxiliar" as "gesquibel";
grant select on "gesquibel".alimento to "cgalvan" as "gesquibel";
grant update on "gesquibel".alimento to "cgalvan" as "gesquibel";
grant insert on "gesquibel".alimento to "cgalvan" as "gesquibel";
grant delete on "gesquibel".alimento to "cgalvan" as "gesquibel";
grant index on "gesquibel".alimento to "cgalvan" as "gesquibel";
grant alter on "gesquibel".alimento to "cgalvan" as "gesquibel";
grant references on "gesquibel".alimento to "cgalvan" as "gesquibel";
grant select on "gesquibel".alimento to "isu_gerente" as "gesquibel";
grant update on "gesquibel".alimento to "isu_gerente" as "gesquibel";
grant insert on "gesquibel".alimento to "isu_gerente" as "gesquibel";
grant delete on "gesquibel".alimento to "isu_gerente" as "gesquibel";
grant select on "gesquibel".alimento to "sestevez" as "gesquibel";
grant update on "gesquibel".alimento to "sestevez" as "gesquibel";
grant insert on "gesquibel".alimento to "sestevez" as "gesquibel";
grant delete on "gesquibel".alimento to "sestevez" as "gesquibel";
grant index on "gesquibel".alimento to "sestevez" as "gesquibel";
grant alter on "gesquibel".alimento to "sestevez" as "gesquibel";
grant references on "gesquibel".alimento to "sestevez" as "gesquibel";
grant select on "gesquibel".persona to "isu_adm_est" as "gesquibel";
grant select on "gesquibel".persona to "isu_gerente" as "gesquibel";
grant select on "gesquibel".persona to "isu_adm_sis" as "gesquibel";
grant update on "gesquibel".persona to "isu_adm_sis" as "gesquibel";
grant insert on "gesquibel".persona to "isu_adm_sis" as "gesquibel";
grant delete on "gesquibel".persona to "isu_adm_sis" as "gesquibel";
grant select on "gesquibel".persona to "sestevez" as "gesquibel";
grant update on "gesquibel".persona to "sestevez" as "gesquibel";
grant insert on "gesquibel".persona to "sestevez" as "gesquibel";
grant delete on "gesquibel".persona to "sestevez" as "gesquibel";
grant index on "gesquibel".persona to "sestevez" as "gesquibel";
grant alter on "gesquibel".persona to "sestevez" as "gesquibel";
grant references on "gesquibel".persona to "sestevez" as "gesquibel";
grant select on "gesquibel".persona to "cgalvan" as "gesquibel";
grant update on "gesquibel".persona to "cgalvan" as "gesquibel";
grant insert on "gesquibel".persona to "cgalvan" as "gesquibel";
grant delete on "gesquibel".persona to "cgalvan" as "gesquibel";
grant index on "gesquibel".persona to "cgalvan" as "gesquibel";
grant alter on "gesquibel".persona to "cgalvan" as "gesquibel";
grant references on "gesquibel".persona to "cgalvan" as "gesquibel";
grant select on "gesquibel".personatel to "isu_gerente" as "gesquibel";
grant select on "gesquibel".personatel to "sestevez" as "gesquibel";
grant update on "gesquibel".personatel to "sestevez" as "gesquibel";
grant insert on "gesquibel".personatel to "sestevez" as "gesquibel";
grant delete on "gesquibel".personatel to "sestevez" as "gesquibel";
grant index on "gesquibel".personatel to "sestevez" as "gesquibel";
grant alter on "gesquibel".personatel to "sestevez" as "gesquibel";
grant references on "gesquibel".personatel to "sestevez" as "gesquibel";
grant select on "gesquibel".personatel to "isu_adm_sis" as "gesquibel";
grant update on "gesquibel".personatel to "isu_adm_sis" as "gesquibel";
grant insert on "gesquibel".personatel to "isu_adm_sis" as "gesquibel";
grant delete on "gesquibel".personatel to "isu_adm_sis" as "gesquibel";
grant select on "gesquibel".personatel to "cgalvan" as "gesquibel";
grant update on "gesquibel".personatel to "cgalvan" as "gesquibel";
grant insert on "gesquibel".personatel to "cgalvan" as "gesquibel";
grant delete on "gesquibel".personatel to "cgalvan" as "gesquibel";
grant index on "gesquibel".personatel to "cgalvan" as "gesquibel";
grant alter on "gesquibel".personatel to "cgalvan" as "gesquibel";
grant references on "gesquibel".personatel to "cgalvan" as "gesquibel";
grant select on "gesquibel".personatel to "isu_adm_est" as "gesquibel";
grant select on "cgalvan".hembra to "gesquibel" as "cgalvan";
grant update on "cgalvan".hembra to "gesquibel" as "cgalvan";
grant insert on "cgalvan".hembra to "gesquibel" as "cgalvan";
grant select on "cgalvan".hembra to "isu_adm_est" as "cgalvan";
grant update on "cgalvan".hembra to "isu_adm_est" as "cgalvan";
grant insert on "cgalvan".hembra to "isu_adm_est" as "cgalvan";
grant select on "cgalvan".hembra to "isu_auxialiar" as "cgalvan";
grant update on "cgalvan".hembra to "isu_auxialiar" as "cgalvan";
grant insert on "cgalvan".hembra to "isu_auxialiar" as "cgalvan";
grant select on "cgalvan".hembra to "isu_adm_sis" as "cgalvan";
grant update on "cgalvan".hembra to "isu_adm_sis" as "cgalvan";
grant insert on "cgalvan".hembra to "isu_adm_sis" as "cgalvan";
grant delete on "cgalvan".hembra to "isu_adm_sis" as "cgalvan";
grant select on "cgalvan".hembra to "sestevez" as "cgalvan";
grant update on "cgalvan".hembra to "sestevez" as "cgalvan";
grant insert on "cgalvan".hembra to "sestevez" as "cgalvan";
grant select on "cgalvan".hembra to "isu_gerente" as "cgalvan";
grant update on "cgalvan".hembra to "isu_gerente" as "cgalvan";
grant insert on "cgalvan".hembra to "isu_gerente" as "cgalvan";
grant select on "sestevez".macho to "isu_auxiliar" as "sestevez";
grant update on "sestevez".macho to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".macho to "isu_auxiliar" as "sestevez";
grant select on "sestevez".macho to "isu_gerent" as "sestevez";
grant update on "sestevez".macho to "isu_gerent" as "sestevez";
grant insert on "sestevez".macho to "isu_gerent" as "sestevez";
grant delete on "sestevez".macho to "isu_gerent" as "sestevez";
grant select on "sestevez".macho to "isu_adm_sis" as "sestevez";
grant update on "sestevez".macho to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".macho to "isu_adm_sis" as "sestevez";
grant delete on "sestevez".macho to "isu_adm_sis" as "sestevez";
grant select on "sestevez".macho to "cgalvan" as "sestevez";
grant update on "sestevez".macho to "cgalvan" as "sestevez";
grant insert on "sestevez".macho to "cgalvan" as "sestevez";
grant delete on "sestevez".macho to "cgalvan" as "sestevez";
grant alter on "sestevez".macho to "cgalvan" as "sestevez";
grant select on "sestevez".macho to "isu_adm_est" as "sestevez";
grant update on "sestevez".macho to "isu_adm_est" as "sestevez";
grant insert on "sestevez".macho to "isu_adm_est" as "sestevez";
grant delete on "sestevez".macho to "isu_adm_est" as "sestevez";
grant select on "sestevez".macho to "gesquibel" as "sestevez";
grant update on "sestevez".macho to "gesquibel" as "sestevez";
grant insert on "sestevez".macho to "gesquibel" as "sestevez";
grant delete on "sestevez".macho to "gesquibel" as "sestevez";
grant alter on "sestevez".macho to "gesquibel" as "sestevez";
grant select on "gesquibel".pasa to "isu_gerente" as "gesquibel";
grant update on "gesquibel".pasa to "isu_gerente" as "gesquibel";
grant insert on "gesquibel".pasa to "isu_gerente" as "gesquibel";
grant delete on "gesquibel".pasa to "isu_gerente" as "gesquibel";
grant select on "gesquibel".pasa to "sestevez" as "gesquibel";
grant update on "gesquibel".pasa to "sestevez" as "gesquibel";
grant insert on "gesquibel".pasa to "sestevez" as "gesquibel";
grant delete on "gesquibel".pasa to "sestevez" as "gesquibel";
grant index on "gesquibel".pasa to "sestevez" as "gesquibel";
grant alter on "gesquibel".pasa to "sestevez" as "gesquibel";
grant references on "gesquibel".pasa to "sestevez" as "gesquibel";
grant select on "gesquibel".pasa to "isu_adm_sis" as "gesquibel";
grant update on "gesquibel".pasa to "isu_adm_sis" as "gesquibel";
grant insert on "gesquibel".pasa to "isu_adm_sis" as "gesquibel";
grant delete on "gesquibel".pasa to "isu_adm_sis" as "gesquibel";
grant select on "gesquibel".pasa to "cgalvan" as "gesquibel";
grant update on "gesquibel".pasa to "cgalvan" as "gesquibel";
grant insert on "gesquibel".pasa to "cgalvan" as "gesquibel";
grant delete on "gesquibel".pasa to "cgalvan" as "gesquibel";
grant index on "gesquibel".pasa to "cgalvan" as "gesquibel";
grant alter on "gesquibel".pasa to "cgalvan" as "gesquibel";
grant references on "gesquibel".pasa to "cgalvan" as "gesquibel";
grant select on "gesquibel".pasa to "isu_adm_est" as "gesquibel";
grant update on "gesquibel".pasa to "isu_adm_est" as "gesquibel";
grant insert on "gesquibel".pasa to "isu_adm_est" as "gesquibel";
grant delete on "gesquibel".pasa to "isu_adm_est" as "gesquibel";
grant select on "gesquibel".pasa to "isu_auxiliar" as "gesquibel";
grant update on "gesquibel".pasa to "isu_auxiliar" as "gesquibel";
grant insert on "gesquibel".pasa to "isu_auxiliar" as "gesquibel";
grant select on "cgalvan".produce to "isu_auxiliar" as "cgalvan";
grant update on "cgalvan".produce to "isu_auxiliar" as "cgalvan";
grant insert on "cgalvan".produce to "isu_auxiliar" as "cgalvan";
grant select on "cgalvan".produce to "sestevez" as "cgalvan";
grant update on "cgalvan".produce to "sestevez" as "cgalvan";
grant insert on "cgalvan".produce to "sestevez" as "cgalvan";
grant select on "cgalvan".produce to "gesquibel" as "cgalvan";
grant update on "cgalvan".produce to "gesquibel" as "cgalvan";
grant insert on "cgalvan".produce to "gesquibel" as "cgalvan";
grant select on "cgalvan".produce to "isu_gerente" as "cgalvan";
grant update on "cgalvan".produce to "isu_gerente" as "cgalvan";
grant insert on "cgalvan".produce to "isu_gerente" as "cgalvan";
grant select on "cgalvan".produce to "isu_adm_est" as "cgalvan";
grant update on "cgalvan".produce to "isu_adm_est" as "cgalvan";
grant insert on "cgalvan".produce to "isu_adm_est" as "cgalvan";
grant select on "cgalvan".produce to "isu_adm_sis" as "cgalvan";
grant update on "cgalvan".produce to "isu_adm_sis" as "cgalvan";
grant insert on "cgalvan".produce to "isu_adm_sis" as "cgalvan";
grant delete on "cgalvan".produce to "isu_adm_sis" as "cgalvan";
grant select on "sestevez".vuelve to "isu_adm_est" as "sestevez";
grant update on "sestevez".vuelve to "isu_adm_est" as "sestevez";
grant insert on "sestevez".vuelve to "isu_adm_est" as "sestevez";
grant delete on "sestevez".vuelve to "isu_adm_est" as "sestevez";
grant select on "sestevez".vuelve to "isu_auxiliar" as "sestevez";
grant update on "sestevez".vuelve to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".vuelve to "isu_auxiliar" as "sestevez";
grant select on "sestevez".vuelve to "isu_adm_sis" as "sestevez";
grant update on "sestevez".vuelve to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".vuelve to "isu_adm_sis" as "sestevez";
grant delete on "sestevez".vuelve to "isu_adm_sis" as "sestevez";
grant select on "sestevez".vuelve to "isu_gerent" as "sestevez";
grant update on "sestevez".vuelve to "isu_gerent" as "sestevez";
grant insert on "sestevez".vuelve to "isu_gerent" as "sestevez";
grant delete on "sestevez".vuelve to "isu_gerent" as "sestevez";
grant select on "sestevez".vuelve to "cgalvan" as "sestevez";
grant update on "sestevez".vuelve to "cgalvan" as "sestevez";
grant insert on "sestevez".vuelve to "cgalvan" as "sestevez";
grant delete on "sestevez".vuelve to "cgalvan" as "sestevez";
grant alter on "sestevez".vuelve to "cgalvan" as "sestevez";
grant select on "sestevez".vuelve to "gesquibel" as "sestevez";
grant update on "sestevez".vuelve to "gesquibel" as "sestevez";
grant insert on "sestevez".vuelve to "gesquibel" as "sestevez";
grant delete on "sestevez".vuelve to "gesquibel" as "sestevez";
grant alter on "sestevez".vuelve to "gesquibel" as "sestevez";
grant select on "gesquibel".estado to "sestevez" as "gesquibel";
grant update on "gesquibel".estado to "sestevez" as "gesquibel";
grant insert on "gesquibel".estado to "sestevez" as "gesquibel";
grant delete on "gesquibel".estado to "sestevez" as "gesquibel";
grant index on "gesquibel".estado to "sestevez" as "gesquibel";
grant alter on "gesquibel".estado to "sestevez" as "gesquibel";
grant references on "gesquibel".estado to "sestevez" as "gesquibel";
grant select on "gesquibel".estado to "isu_adm_est" as "gesquibel";
grant update on "gesquibel".estado to "isu_adm_est" as "gesquibel";
grant insert on "gesquibel".estado to "isu_adm_est" as "gesquibel";
grant delete on "gesquibel".estado to "isu_adm_est" as "gesquibel";
grant select on "gesquibel".estado to "isu_adm_sis" as "gesquibel";
grant update on "gesquibel".estado to "isu_adm_sis" as "gesquibel";
grant insert on "gesquibel".estado to "isu_adm_sis" as "gesquibel";
grant delete on "gesquibel".estado to "isu_adm_sis" as "gesquibel";
grant select on "gesquibel".estado to "isu_auxiliar" as "gesquibel";
grant update on "gesquibel".estado to "isu_auxiliar" as "gesquibel";
grant insert on "gesquibel".estado to "isu_auxiliar" as "gesquibel";
grant select on "gesquibel".estado to "isu_gerente" as "gesquibel";
grant update on "gesquibel".estado to "isu_gerente" as "gesquibel";
grant insert on "gesquibel".estado to "isu_gerente" as "gesquibel";
grant delete on "gesquibel".estado to "isu_gerente" as "gesquibel";
grant select on "gesquibel".estado to "cgalvan" as "gesquibel";
grant update on "gesquibel".estado to "cgalvan" as "gesquibel";
grant insert on "gesquibel".estado to "cgalvan" as "gesquibel";
grant delete on "gesquibel".estado to "cgalvan" as "gesquibel";
grant index on "gesquibel".estado to "cgalvan" as "gesquibel";
grant alter on "gesquibel".estado to "cgalvan" as "gesquibel";
grant references on "gesquibel".estado to "cgalvan" as "gesquibel";
grant select on "sestevez".hay to "isu_gerent" as "sestevez";
grant update on "sestevez".hay to "isu_gerent" as "sestevez";
grant insert on "sestevez".hay to "isu_gerent" as "sestevez";
grant delete on "sestevez".hay to "isu_gerent" as "sestevez";
grant select on "sestevez".hay to "cgalvan" as "sestevez";
grant update on "sestevez".hay to "cgalvan" as "sestevez";
grant insert on "sestevez".hay to "cgalvan" as "sestevez";
grant delete on "sestevez".hay to "cgalvan" as "sestevez";
grant alter on "sestevez".hay to "cgalvan" as "sestevez";
grant select on "sestevez".hay to "isu_auxiliar" as "sestevez";
grant update on "sestevez".hay to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".hay to "isu_auxiliar" as "sestevez";
grant delete on "sestevez".hay to "isu_auxiliar" as "sestevez";
grant select on "sestevez".hay to "isu_adm_sis" as "sestevez";
grant update on "sestevez".hay to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".hay to "isu_adm_sis" as "sestevez";
grant delete on "sestevez".hay to "isu_adm_sis" as "sestevez";
grant select on "sestevez".hay to "isu_adm_est" as "sestevez";
grant update on "sestevez".hay to "isu_adm_est" as "sestevez";
grant insert on "sestevez".hay to "isu_adm_est" as "sestevez";
grant delete on "sestevez".hay to "isu_adm_est" as "sestevez";
grant select on "sestevez".hay to "gesquibel" as "sestevez";
grant update on "sestevez".hay to "gesquibel" as "sestevez";
grant insert on "sestevez".hay to "gesquibel" as "sestevez";
grant delete on "sestevez".hay to "gesquibel" as "sestevez";
grant alter on "sestevez".hay to "gesquibel" as "sestevez";
grant select on "sestevez".evento to "isu_auxiliar" as "sestevez";
grant update on "sestevez".evento to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".evento to "isu_auxiliar" as "sestevez";
grant delete on "sestevez".evento to "isu_auxiliar" as "sestevez";
grant select on "sestevez".evento to "isu_amd_sis" as "sestevez";
grant update on "sestevez".evento to "isu_amd_sis" as "sestevez";
grant insert on "sestevez".evento to "isu_amd_sis" as "sestevez";
grant delete on "sestevez".evento to "isu_amd_sis" as "sestevez";
grant select on "sestevez".evento to "isu_gerent" as "sestevez";
grant update on "sestevez".evento to "isu_gerent" as "sestevez";
grant insert on "sestevez".evento to "isu_gerent" as "sestevez";
grant delete on "sestevez".evento to "isu_gerent" as "sestevez";
grant select on "sestevez".evento to "gesquibel" as "sestevez";
grant update on "sestevez".evento to "gesquibel" as "sestevez";
grant insert on "sestevez".evento to "gesquibel" as "sestevez";
grant delete on "sestevez".evento to "gesquibel" as "sestevez";
grant alter on "sestevez".evento to "gesquibel" as "sestevez";
grant select on "sestevez".evento to "isu_adm_est" as "sestevez";
grant update on "sestevez".evento to "isu_adm_est" as "sestevez";
grant insert on "sestevez".evento to "isu_adm_est" as "sestevez";
grant delete on "sestevez".evento to "isu_adm_est" as "sestevez";
grant select on "sestevez".evento to "cgalvan" as "sestevez";
grant update on "sestevez".evento to "cgalvan" as "sestevez";
grant insert on "sestevez".evento to "cgalvan" as "sestevez";
grant delete on "sestevez".evento to "cgalvan" as "sestevez";
grant alter on "sestevez".evento to "cgalvan" as "sestevez";
grant select on "cgalvan".tanque to "isu_adm_est" as "cgalvan";
grant update on "cgalvan".tanque to "isu_adm_est" as "cgalvan";
grant insert on "cgalvan".tanque to "isu_adm_est" as "cgalvan";
grant select on "cgalvan".tanque to "isu_adm_sis" as "cgalvan";
grant update on "cgalvan".tanque to "isu_adm_sis" as "cgalvan";
grant insert on "cgalvan".tanque to "isu_adm_sis" as "cgalvan";
grant delete on "cgalvan".tanque to "isu_adm_sis" as "cgalvan";
grant select on "cgalvan".tanque to "gesquibel" as "cgalvan";
grant update on "cgalvan".tanque to "gesquibel" as "cgalvan";
grant insert on "cgalvan".tanque to "gesquibel" as "cgalvan";
grant select on "cgalvan".tanque to "isu_gerente" as "cgalvan";
grant update on "cgalvan".tanque to "isu_gerente" as "cgalvan";
grant insert on "cgalvan".tanque to "isu_gerente" as "cgalvan";
grant select on "cgalvan".tanque to "isu_auxiliar" as "cgalvan";
grant update on "cgalvan".tanque to "isu_auxiliar" as "cgalvan";
grant insert on "cgalvan".tanque to "isu_auxiliar" as "cgalvan";
grant select on "cgalvan".tanque to "sestevez" as "cgalvan";
grant update on "cgalvan".tanque to "sestevez" as "cgalvan";
grant insert on "cgalvan".tanque to "sestevez" as "cgalvan";
grant select on "sestevez".posee to "cgalvan" as "sestevez";
grant update on "sestevez".posee to "cgalvan" as "sestevez";
grant insert on "sestevez".posee to "cgalvan" as "sestevez";
grant delete on "sestevez".posee to "cgalvan" as "sestevez";
grant index on "sestevez".posee to "cgalvan" as "sestevez";
grant alter on "sestevez".posee to "cgalvan" as "sestevez";
grant references on "sestevez".posee to "cgalvan" as "sestevez";
grant select on "sestevez".posee to "isu_gerent" as "sestevez";
grant update on "sestevez".posee to "isu_gerent" as "sestevez";
grant insert on "sestevez".posee to "isu_gerent" as "sestevez";
grant select on "sestevez".posee to "isu_adm_sis" as "sestevez";
grant update on "sestevez".posee to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".posee to "isu_adm_sis" as "sestevez";
grant delete on "sestevez".posee to "isu_adm_sis" as "sestevez";
grant select on "sestevez".posee to "isu_adm_est" as "sestevez";
grant update on "sestevez".posee to "isu_adm_est" as "sestevez";
grant insert on "sestevez".posee to "isu_adm_est" as "sestevez";
grant delete on "sestevez".posee to "isu_adm_est" as "sestevez";
grant select on "sestevez".posee to "gesquibel" as "sestevez";
grant update on "sestevez".posee to "gesquibel" as "sestevez";
grant insert on "sestevez".posee to "gesquibel" as "sestevez";
grant delete on "sestevez".posee to "gesquibel" as "sestevez";
grant index on "sestevez".posee to "gesquibel" as "sestevez";
grant alter on "sestevez".posee to "gesquibel" as "sestevez";
grant references on "sestevez".posee to "gesquibel" as "sestevez";
grant select on "gesquibel".tambo to "cgalvan" as "gesquibel";
grant update on "gesquibel".tambo to "cgalvan" as "gesquibel";
grant insert on "gesquibel".tambo to "cgalvan" as "gesquibel";
grant delete on "gesquibel".tambo to "cgalvan" as "gesquibel";
grant index on "gesquibel".tambo to "cgalvan" as "gesquibel";
grant alter on "gesquibel".tambo to "cgalvan" as "gesquibel";
grant references on "gesquibel".tambo to "cgalvan" as "gesquibel";
grant select on "gesquibel".tambo to "sestevez" as "gesquibel";
grant update on "gesquibel".tambo to "sestevez" as "gesquibel";
grant insert on "gesquibel".tambo to "sestevez" as "gesquibel";
grant delete on "gesquibel".tambo to "sestevez" as "gesquibel";
grant index on "gesquibel".tambo to "sestevez" as "gesquibel";
grant alter on "gesquibel".tambo to "sestevez" as "gesquibel";
grant references on "gesquibel".tambo to "sestevez" as "gesquibel";
grant select on "gesquibel".tambo to "isu_adm_est" as "gesquibel";
grant update on "gesquibel".tambo to "isu_adm_est" as "gesquibel";
grant insert on "gesquibel".tambo to "isu_adm_est" as "gesquibel";
grant delete on "gesquibel".tambo to "isu_adm_est" as "gesquibel";
grant select on "gesquibel".tambo to "isu_gerente" as "gesquibel";
grant update on "gesquibel".tambo to "isu_gerente" as "gesquibel";
grant insert on "gesquibel".tambo to "isu_gerente" as "gesquibel";
grant delete on "gesquibel".tambo to "isu_gerente" as "gesquibel";
grant select on "gesquibel".tambo to "isu_adm_sis" as "gesquibel";
grant update on "gesquibel".tambo to "isu_adm_sis" as "gesquibel";
grant insert on "gesquibel".tambo to "isu_adm_sis" as "gesquibel";
grant delete on "gesquibel".tambo to "isu_adm_sis" as "gesquibel";
grant select on "sestevez".ordenie to "isu_gerent" as "sestevez";
grant update on "sestevez".ordenie to "isu_gerent" as "sestevez";
grant insert on "sestevez".ordenie to "isu_gerent" as "sestevez";
grant select on "sestevez".ordenie to "gesquibel" as "sestevez";
grant update on "sestevez".ordenie to "gesquibel" as "sestevez";
grant insert on "sestevez".ordenie to "gesquibel" as "sestevez";
grant delete on "sestevez".ordenie to "gesquibel" as "sestevez";
grant index on "sestevez".ordenie to "gesquibel" as "sestevez";
grant alter on "sestevez".ordenie to "gesquibel" as "sestevez";
grant references on "sestevez".ordenie to "gesquibel" as "sestevez";
grant select on "sestevez".ordenie to "isu_adm_est" as "sestevez";
grant update on "sestevez".ordenie to "isu_adm_est" as "sestevez";
grant insert on "sestevez".ordenie to "isu_adm_est" as "sestevez";
grant select on "sestevez".ordenie to "isu_adm_sis" as "sestevez";
grant update on "sestevez".ordenie to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".ordenie to "isu_adm_sis" as "sestevez";
grant select on "sestevez".ordenie to "isu_auxiliar" as "sestevez";
grant update on "sestevez".ordenie to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".ordenie to "isu_auxiliar" as "sestevez";
grant select on "sestevez".ordenie to "cgalvan" as "sestevez";
grant update on "sestevez".ordenie to "cgalvan" as "sestevez";
grant insert on "sestevez".ordenie to "cgalvan" as "sestevez";
grant delete on "sestevez".ordenie to "cgalvan" as "sestevez";
grant index on "sestevez".ordenie to "cgalvan" as "sestevez";
grant alter on "sestevez".ordenie to "cgalvan" as "sestevez";
grant references on "sestevez".ordenie to "cgalvan" as "sestevez";
grant select on "sestevez".supervisa to "cgalvan" as "sestevez";
grant update on "sestevez".supervisa to "cgalvan" as "sestevez";
grant insert on "sestevez".supervisa to "cgalvan" as "sestevez";
grant delete on "sestevez".supervisa to "cgalvan" as "sestevez";
grant index on "sestevez".supervisa to "cgalvan" as "sestevez";
grant alter on "sestevez".supervisa to "cgalvan" as "sestevez";
grant references on "sestevez".supervisa to "cgalvan" as "sestevez";
grant select on "sestevez".supervisa to "isu_gerent" as "sestevez";
grant update on "sestevez".supervisa to "isu_gerent" as "sestevez";
grant insert on "sestevez".supervisa to "isu_gerent" as "sestevez";
grant select on "sestevez".supervisa to "gesquibel" as "sestevez";
grant update on "sestevez".supervisa to "gesquibel" as "sestevez";
grant insert on "sestevez".supervisa to "gesquibel" as "sestevez";
grant delete on "sestevez".supervisa to "gesquibel" as "sestevez";
grant index on "sestevez".supervisa to "gesquibel" as "sestevez";
grant alter on "sestevez".supervisa to "gesquibel" as "sestevez";
grant references on "sestevez".supervisa to "gesquibel" as "sestevez";
grant select on "sestevez".supervisa to "isu_adm_est" as "sestevez";
grant update on "sestevez".supervisa to "isu_adm_est" as "sestevez";
grant insert on "sestevez".supervisa to "isu_adm_est" as "sestevez";
grant select on "sestevez".supervisa to "isu_adm_sis" as "sestevez";
grant update on "sestevez".supervisa to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".supervisa to "isu_adm_sis" as "sestevez";
grant select on "sestevez".supervisa to "isu_auxiliar" as "sestevez";
grant update on "sestevez".supervisa to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".supervisa to "isu_auxiliar" as "sestevez";
grant select on "sestevez".controla to "gesquibel" as "sestevez";
grant update on "sestevez".controla to "gesquibel" as "sestevez";
grant insert on "sestevez".controla to "gesquibel" as "sestevez";
grant delete on "sestevez".controla to "gesquibel" as "sestevez";
grant alter on "sestevez".controla to "gesquibel" as "sestevez";
grant select on "sestevez".controla to "cgalvan" as "sestevez";
grant update on "sestevez".controla to "cgalvan" as "sestevez";
grant insert on "sestevez".controla to "cgalvan" as "sestevez";
grant delete on "sestevez".controla to "cgalvan" as "sestevez";
grant alter on "sestevez".controla to "cgalvan" as "sestevez";
grant select on "sestevez".controla to "isu_adm_est" as "sestevez";
grant update on "sestevez".controla to "isu_adm_est" as "sestevez";
grant insert on "sestevez".controla to "isu_adm_est" as "sestevez";
grant delete on "sestevez".controla to "isu_adm_est" as "sestevez";
grant select on "sestevez".controla to "isu_gerent" as "sestevez";
grant update on "sestevez".controla to "isu_gerent" as "sestevez";
grant insert on "sestevez".controla to "isu_gerent" as "sestevez";
grant delete on "sestevez".controla to "isu_gerent" as "sestevez";
grant select on "sestevez".controla to "isu_adm_sis" as "sestevez";
grant update on "sestevez".controla to "isu_adm_sis" as "sestevez";
grant insert on "sestevez".controla to "isu_adm_sis" as "sestevez";
grant delete on "sestevez".controla to "isu_adm_sis" as "sestevez";
grant select on "sestevez".controla to "isu_auxiliar" as "sestevez";
grant update on "sestevez".controla to "isu_auxiliar" as "sestevez";
grant insert on "sestevez".controla to "isu_auxiliar" as "sestevez";
grant delete on "sestevez".controla to "isu_auxiliar" as "sestevez";















revoke usage on language SPL from public ;

grant usage on language SPL to public ;





create unique index "cgalvan".ix105_1 on "cgalvan".cooperativa 
    (serie) using btree ;
alter table "cgalvan".cooperativa add constraint primary key 
    (serie) constraint "cgalvan".cooperativa  ;
create unique index "cgalvan".ix107_3 on "cgalvan".retira (serie_coop) 
    using btree ;
create unique index "gesquibel".ix132_1 on "gesquibel".estado 
    (num) using btree ;
alter table "gesquibel".estado add constraint primary key (num) 
    constraint "sestevez".estado_pk  ;
create unique index "sestevez".ix136_2 on "sestevez".hay (serie_tambo) 
    using btree ;
create unique index "gesquibel".ix106_1 on "gesquibel".tambo (serie) 
    using btree ;
alter table "gesquibel".tambo add constraint primary key (serie) 
    constraint "sestevez".tambo_pk  ;



alter table "cgalvan".retira add constraint (foreign key (serie_coop) 
    references "cgalvan".cooperativa  on delete cascade constraint 
    "sestevez".retira_coop_fk);
alter table "sestevez".posee add constraint (foreign key (serie_tanque) 
    references "cgalvan".tanque  on delete cascade constraint 
    "sestevez".posee_tanque_fk);
alter table "cgalvan".almacena add constraint (foreign key (tipo) 
    references "cgalvan".leche  on delete cascade constraint "sestevez"
    .almacena_tipo_fk);
alter table "gesquibel".tiene add constraint (foreign key (serie) 
    references "gesquibel".tambo  on delete cascade constraint 
    "sestevez".tiene_tam_fk);
alter table "gesquibel".personatel add constraint (foreign key 
    (ci) references "gesquibel".persona  on delete cascade constraint 
    "gesquibel".ci_telefono_r);
alter table "gesquibel".se_da add constraint (foreign key (num_animal) 
    references "sestevez".animal  on delete cascade constraint 
    "gesquibel".num_animal_r);
alter table "gesquibel".se_da add constraint (foreign key (num_alimento) 
    references "gesquibel".alimento  on delete cascade constraint 
    "gesquibel".alimento_r);
alter table "sestevez".retorna add constraint (foreign key (numero_animal) 
    references "sestevez".animal  on delete cascade constraint 
    "sestevez".num_ani_ret_fk);
alter table "gesquibel".proporciona add constraint (foreign key 
    (num) references "gesquibel".alimento  on delete cascade constraint 
    "sestevez".prop_ali_fk);
alter table "sestevez".macho add constraint (foreign key (id_macho) 
    references "sestevez".animal  on delete cascade constraint 
    "sestevez".id_macho_fk);
alter table "cgalvan".produce add constraint (foreign key (tipo_leche) 
    references "cgalvan".leche  constraint "cgalvan".leche_pro);
    
alter table "cgalvan".produce add constraint (foreign key (id_hembra) 
    references "cgalvan".hembra  on delete cascade constraint 
    "cgalvan".hembra_pro);
alter table "sestevez".retorna add constraint (foreign key (num_camp_re) 
    references "sestevez".campo_de_recria  on delete cascade constraint 
    "sestevez".num_camp_re_fk);
alter table "gesquibel".pasa add constraint (foreign key (id_hembra) 
    references "cgalvan".hembra  on delete cascade constraint 
    "sestevez".pasa_hem_fk);
alter table "sestevez".va add constraint (foreign key (num_camp_re) 
    references "sestevez".campo_de_recria  on delete cascade constraint 
    "sestevez".num_camp_va_fk);
alter table "sestevez".vuelve add constraint (foreign key (id_hembra) 
    references "cgalvan".hembra  on delete cascade constraint 
    "sestevez".id_hem_vuelve_fk);
alter table "sestevez".vuelve add constraint (foreign key (num_camp_re) 
    references "sestevez".campo_de_recria  on delete cascade constraint 
    "sestevez".num_camp_vu_fk);
alter table "sestevez".hay add constraint (foreign key (numero_animal) 
    references "sestevez".animal  on delete cascade constraint 
    "sestevez".hay_num_fk);
alter table "sestevez".posee add constraint (foreign key (serie_tambo) 
    references "gesquibel".tambo  on delete cascade constraint 
    "sestevez".posee_tambo_fk);
alter table "cgalvan".hembra add constraint (foreign key (id_hembra) 
    references "sestevez".animal  on delete cascade constraint 
    "cgalvan".idhembra_fk);
alter table "sestevez".cria add constraint (foreign key (numero_vaca,
    numero_macho,fecha) references "sestevez".evento  on delete 
    cascade constraint "sestevez".cria_fk);
alter table "sestevez".controla add constraint (foreign key (num_animal) 
    references "sestevez".animal  on delete cascade constraint 
    "sestevez".controla_num_fk);
alter table "sestevez".controla add constraint (foreign key (ci_personal) 
    references "gesquibel".persona  on delete cascade constraint 
    "sestevez".controla_ci_fk);
alter table "sestevez".evento add constraint (foreign key (id_hembra) 
    references "cgalvan".hembra  on delete cascade constraint 
    "sestevez".evento_h_fk);
alter table "sestevez".evento add constraint (foreign key (id_macho) 
    references "sestevez".macho  on delete cascade constraint 
    "sestevez".evento_m_fk);
alter table "sestevez".va add constraint (foreign key (numero_cria) 
    references "sestevez".cria  on delete cascade constraint "sestevez"
    .num_cria_va_fk);
alter table "cgalvan".retira add constraint (foreign key (num_tanque) 
    references "cgalvan".tanque  on delete cascade constraint 
    "sestevez".retira_tan_fk);
alter table "cgalvan".almacena add constraint (foreign key (num_serie) 
    references "cgalvan".tanque  on delete cascade constraint 
    "sestevez".almacena_tan_fk);
alter table "gesquibel".proporciona add constraint (foreign key 
    (serie) references "gesquibel".tambo  on delete cascade constraint 
    "sestevez".prop_tam_fk);
alter table "gesquibel".tiene add constraint (foreign key (ci) 
    references "gesquibel".persona  on delete cascade constraint 
    "sestevez".tiene_pers_fk);
alter table "sestevez".supervisa add constraint (foreign key 
    (ci) references "gesquibel".persona  on delete cascade constraint 
    "sestevez".super_ci_fk);
alter table "sestevez".supervisa add constraint (foreign key 
    (num_ordenie) references "sestevez".ordenie  on delete cascade 
    constraint "sestevez".super_num_fk);
alter table "gesquibel".pasa add constraint (foreign key (num_estado) 
    references "gesquibel".estado  on delete cascade constraint 
    "sestevez".pasa_num_fk);







 


