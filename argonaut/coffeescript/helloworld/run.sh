#!/bin/bash

docker rm coffeehw
docker run -p 80:80 \
	-p 8081:8081 \
	--name coffeehw \
	-it tdpc/coffeebase
