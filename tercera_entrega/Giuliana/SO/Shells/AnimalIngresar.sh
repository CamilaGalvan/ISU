#!/bin/bash
tput setab 7
tput setaf 0
op=0
DnNum=0
while [ $op -ne 3 ]
do
	clear
	tput cup 1 3 ; echo "I. S." ; tput cup 1 8; tput setaf 4 ; echo " U. insumos y soporte al usuario"; tput setaf 0
	tput cup 3 3 ; echo "Numero: "
	tput cup 4 3 ; echo "Sexo: " 
	tput cup 5 3 ; echo "Nacimiento: " 
	tput cup 6 3 ; echo "Lugar actual: " 
	tput cup 7 3 ; echo "Raza: " 
	tput cup 8 3 ; echo "Division: " 
	tput cup 9 3 ; echo "Num. Progenitor hembra"
	tput cup 10 3 ; echo "Num. Progenitor macho"
	while [DnNum -eq 0]
	do
		tput cup 3 11 ; read num
		busqueda=$(grep "^$num:" BaseAnimal.txt)
		if [ -z $busqueda  ]  #si no existe el usuario se peude crear
		tput cup 4 9 ; read sexo
		tput cup 5 15 ; read nac
		tput cup 6 17 ; read lug
		tput cup 7 9 ; read raza
		tput cup 8 13 ; read div
		tput cup 9 28 ; read numh
		tput cup 10 27 ; read numm
		echo "$num:$sexo:$nac:$lug:$raza:$div" >> BaseAnimal.txt
		echo "$num:$numh:$numm" >> BaseAnimalG.txt
		fi
	then
	done
	
done

