docker network create fiovana_v2 --label=fiovana_v2
docker-compose -f containers/rabbitmq.yml up -d
docker-compose -f containers/redis.yml up -d
exit $LASTEXITCODE
