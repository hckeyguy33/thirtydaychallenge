#!/bin/bash

docker rmi tdpc/coffeebase
docker build -t tdpc/coffeebase .
