# Variáveis
IMAGE_NAME := imagem-api-dotnet
DOCKER_COMPOSE := Docker-compose

# Comandos
build:
	$(DOCKER_COMPOSE) build

run:
	$(DOCKER_COMPOSE) up -d

stop:
	$(DOCKER_COMPOSE) down

restart: stop run

.PHONY: build run stop restart
