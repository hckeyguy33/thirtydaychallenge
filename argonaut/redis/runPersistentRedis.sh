docker stop tdpcredis
docker rm tdpcredis
docker run -p 6379:6379 -v tdpcredisvol:/data --name tdpcredis -d redis redis-server --appendonly yes 
#--volumes-from tdpcredisvol
#docker run --name tdpcredis --volumes-from tdpcredisvol -d redis redis-server --appendonly yes 
