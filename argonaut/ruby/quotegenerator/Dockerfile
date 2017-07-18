from library/ubuntu

RUN apt-get update
RUN apt-get install ruby-full -y
RUN apt-get install git-core curl zlib1g-dev build-essential libssl-dev libreadline-dev libyaml-dev libsqlite3-dev sqlite3 libxml2-dev libxslt1-dev libcurl4-openssl-dev python-software-properties libffi-dev nodejs -y 



RUN apt-get install nano -y
#RUN rails new quotegenerator

RUN useradd argonaut

RUN mkdir /quotegenerator
COPY code /opt
COPY entrypoint.sh /
RUN chown argonaut:argonaut /entrypoint.sh
RUN chown argonaut:argonaut -R /quotegenerator
RUN mkdir /home/argonaut
RUN chown argonaut:argonaut /home/argonaut

RUN gem install rails
RUN gem install bundler

RUN rails --version
RUN chown argonaut: -R /var/lib/gems
RUN chown argonaut: -R /usr/local/bin

USER argonaut

#CMD ["ruby","/opt/helloworld.rb"]
#CMD ["/blog/bin/rails","server"]

ENTRYPOINT /entrypoint.sh
