#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 2c6a85c8-75b6-47ae-8427-fc14da1db674 -t
    fi
    cd ../
fi

docker-compose up -d
