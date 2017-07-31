from library/ubuntu

RUN apt-get update -y
RUN apt-get upgrade -y

RUN apt-get install nodejs npm -y
RUN apt-get install nginx -y
RUN apt-get install rsyslog -y
RUN npm install --global coffee-script
#COPY lang /opt/lang
#WORKDIR /opt/lang
#RUN tar -xzvf node-v0.6.6.tar.gz
RUN ln -s /usr/bin/nodejs /usr/bin/node

COPY code /opt
WORKDIR /opt
RUN coffee --compile --output js/ coffee/

COPY nginx /etc/nginx/conf.d
COPY entrypoint.sh /

WORKDIR /opt

ENTRYPOINT /entrypoint.sh
