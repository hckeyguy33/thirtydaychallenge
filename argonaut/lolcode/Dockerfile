from library/ubuntu

RUN sed -i 's/.*xenial-security/#&/' /etc/apt/sources.list

RUN apt-get update -y
RUN apt-get install make nano less -y

RUN apt-get install cmake g++ doxygen -y

COPY language/lci /opt/lang
WORKDIR /opt/lang
RUN cmake .
RUN make && make install

COPY code /opt
COPY entrypoint.sh /opt

WORKDIR /opt
ENTRYPOINT /opt/entrypoint.sh


