# Como criar e enviar um repositório para o GitHub?


### 1 - Abrir a pasta do projeto no console.

### 2 - Inicializar o repositório git:
```
    git init
```

### 3 - Configurar nome e email:
```
    git config user.name "Lucas Anjos"
    git config user.email "oargus.g@gmail.com"
```

### 4 - Criar o primeiro commit

```
    git add .
    git commit -am "Primeiro commit"
```

### 5 - Criar o repositório no GitHub

### 6 - Adicionar o *remote* no repositório local

```
    git remote add origin https://github.com/olucassantos/CartoesVisitas.git
```

### 7 - Fazer o push do repositório
```
    git push -u origin master
```
O -u é apenas no commit de criação.