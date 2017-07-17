#!/bin/bash

docker rm rubyquote
#docker run -p 3000:3000 --name rubyquote -dit tdpc/rubyrailsbase
docker run -v /home/argonaut/gitlab/thirtydaychallenge/argonaut/ruby/quotegenerator/build:/quotegenerator -e BASHSTART=1 -p 3000:3000 --name rubyquote -it tdpc/rubyrailsbase /bin/bash
