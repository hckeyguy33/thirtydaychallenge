#!/bin/bash

docker rmi tdpc/rubyrailsbase
docker build -t tdpc/rubyrailsbase .
