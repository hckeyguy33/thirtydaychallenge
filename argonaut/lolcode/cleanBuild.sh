#!/bin/bash

docker rmi tdpc/lolbase
docker build -t tdpc/lolbase .
