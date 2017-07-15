from library/ubuntu

RUN apt-get update
RUN apt-get install make nano less -y
RUN apt-get install libfile-find-object-perl -y

COPY language /opt/lang
RUN cd /opt/lang;tar -xzvf L*
WORKDIR /opt/lang/Lingua-Shakespeare-1.00
RUN perl Makefile.PL
RUN make
RUN make test
RUN make install

COPY code /opt

CMD ["perl","/opt/helloworld.ws"]


