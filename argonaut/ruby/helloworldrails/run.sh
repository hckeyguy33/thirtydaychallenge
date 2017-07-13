#!/bin/bash

docker rm rubyrailshw
docker run -p 3000:3000 --name rubyrailshw -dit tdpc/rubyrailsbase
