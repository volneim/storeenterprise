FROM mcr.microsoft.com/mssql/rhel/server:2019-CU1-rhel-8
USER root
SHELL ["/bin/bash", "-c"]
ENV TZ=America/Sao_Paulo
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone
RUN mkdir -p /usr/work

WORKDIR /usr/work
COPY . /usr/work/

EXPOSE 1433

CMD /bin/bash ./entrypoint.sh