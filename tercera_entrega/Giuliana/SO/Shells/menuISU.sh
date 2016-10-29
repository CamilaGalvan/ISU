#!/bin/bash
tput setab 7
tput setaf 0
op=0
while [ $op -ne 3 ]
do
	clear
	tput cup 1 3 ; echo "I. S." ; tput cup 1 8; tput setaf 4 ; echo " U. insumos y soporte al usuario"; tput setaf 0
	#tput cup 3 3 ; echo "1) Ordeñe"
	tput cup 4 3 ; echo "2) Animales" 
	tput cup 5 3 ; echo "3) Personal"
	#tput cup 6 3 ; echo "4) Tambo" 
	tput cup 7 3 ; echo "5) Salir"
	tput cup 8 3 ; echo "Opcion: "
	tput cup 8 12; read op
	case $op in
		#1)  . menuordenie.sh ;;
		2)  . AnimaleMenu.sh ;;
		3)  . menuUsuario.sh  ;; 
		#4)  . menuTambo.sh ;;
		5)  ;;
		*) tput cup 2 3; tput setaf 1; read  -p "Dato no valido" aux ; tput setaf 0 	;;
	esac
done

