#!/bin/bash

docker stop tdpcredis
docker rm tdpcredis
docker run -v tdpcredisvol:/data --name tdpcredis -d redis redis-server --appendonly yes 
#--volumes-from tdpcredisvol
#docker run --name tdpcredis --volumes-from tdpcredisvol -d redis redis-server --appendonly yes 
