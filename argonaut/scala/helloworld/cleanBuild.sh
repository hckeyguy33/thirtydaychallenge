#!/bin/bash

docker rmi tdpc/scalabase
docker build -t tdpc/scalabase .
