The redis cache store is as follows.

1) Docker volume persist information (tdpcredisvol) 
	docker volume create tdpcredisvol
2) Key is a year from 0-2017 (or current year)
3) Value is a text string from http://numbersapi.com/




QuoteImporter

1) Install pip & virtualenv 
	apt-get install python-pip virtualenv

2) Create the virtualenv
	cd redis; ./createPy3ENV.sh  

3) Source virtualenv
	source py3env/bin/activate

TBD on way forward

Example Currently
python getQOD.py --web=http://numbersapi.com --return=json --year=201

This will push to the redis store if the value ("year") doesn't exist, otherwise it will output the cached value


