#!/bin/bash
	aux=$(date %D %H)
	dbexport isu /Coware/aux/
	
# crontab -l, crontab -e