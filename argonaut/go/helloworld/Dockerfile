from library/ubuntu

RUN apt-get update -y
RUN apt-get upgrade -y

COPY lang /opt/lang
WORKDIR /opt/lang
RUN tar -xzvf go*
RUN mv /opt/lang/go /usr/local
ENV GOPATH=/opt
ENV PATH=$PATH:/usr/local/go/bin:$GOPATH/bin

COPY code /opt
RUN go install hello

COPY entrypoint.sh /

WORKDIR /opt

ENTRYPOINT /entrypoint.sh
