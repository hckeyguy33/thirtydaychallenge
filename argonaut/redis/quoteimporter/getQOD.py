import requests
import json
import sys
import getopt
import redis

errorFound=None

try:
	options, remainder = getopt.getopt(sys.argv[1:],'o:v', ['web=','year=','return='])
except Exception as e:
	print (e)
	errorFound = e
	print ("Exception: "+str(errorFound))

website=None
year=None
returnType=None

for opt, arg in options:
	if opt in ('-web','--web'):
		website = arg
	elif opt in ('-year','--year'):
		year = arg
	elif opt in ('-return','--return'):
		returnType = arg

if errorFound is not None or website is None or returnType is None or returnType != 'json':
	print ('--web= or -web= with site to pull quote, note this only works from http://numbersapi.com/ currently')
	print ('--return= or -return= with site to pull quote, note this only works from http://numbersapi.com/ currently')
	print ('--year= or -year= empty will return random, any out of bounds will return random')
	if errorFound is not None:
		print ('Exception'+errorFound)

	sys.exit(1)

if year is None:
	year = 'random'
elif int(year) < 0 or int(year) > 2017:
	year = 'random'

#http://numbersapi.com/1/year?json

webfinal=website+'/'+year+'?'+returnType

r = requests.get(webfinal)
quote=''
quoteNum=-1
if r.status_code == 200:
	jsonQOD = json.loads(r.text)
	quote=jsonQOD['text']
	quoteNum=jsonQOD['number']
else:
	print ("Web return status_code: "+str(r.status_code))
	sys.exit(1)

r_server = redis.Redis('localhost')
cacheQuote = r_server.get(quoteNum)

if cacheQuote is None:
	r_server.set(quoteNum,quote)
	print("Storing Quote: "+quote + " for number " + str(quoteNum))
else:
	print("Cached Quote: "+str(cacheQuote))
