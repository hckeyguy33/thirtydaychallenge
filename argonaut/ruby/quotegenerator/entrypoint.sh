#!/bin/bash

cd /quotegenerator

if [ $BASHSTART -eq 1 ];
then
	bundle install
	/bin/bash
else
	./bin/rails server
fi
