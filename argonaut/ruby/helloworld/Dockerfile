from library/ubuntu

RUN apt-get update
RUN apt-get install ruby-full -y

COPY code /opt

CMD ["ruby","/opt/helloworld.rb"]
