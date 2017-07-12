#!/bin/bash

docker rmi tdpc/rubybase
docker build -t tdpc/rubybase .
