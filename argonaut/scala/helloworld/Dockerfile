from library/ubuntu

RUN apt-get update -y
RUN apt-get install openjdk-8-jdk openjdk-8-jdk -y

RUN echo "deb https://dl.bintray.com/sbt/debian /" | tee -a /etc/apt/sources.list.d/sbt.list
RUN apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv 2EE0EA64E40A89B84B2DF73499E82A75642AC823
RUN apt-get install apt-transport-https -y
RUN apt-get update -y
RUN apt-get install sbt -y

COPY code /opt
COPY entrypoint.sh /

WORKDIR /opt
RUN sbt update
RUN sbt compile

ENTRYPOINT /entrypoint.sh
