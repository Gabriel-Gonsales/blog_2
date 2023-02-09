<template>
    <div>
        <div class="bg-light" id="postG">
            <div id="contentImg">
                <img class="col-md-12" id="ImagemContainer" :src="imagem" />
            </div>
            <div class="" id="textos">
                <h3 class="text-danger" id="titulo">
                    <b>{{titulo}}</b>
                </h3>
                <p id="texto">
                    {{texto}}
                </p>
            </div>
        </div>
        <div class="bg-light">
            <div id="coments" class="col-md-8">
                <h2 class="text-danger">
                    <b>Deixe seu comentário</b>
                </h2>
                <form id="formulario">
                    <input v-model="nome" id="name" placeholder="Seu nome" class="col-md-12" type="text" />
                    <br /><br />
                    <textarea v-model="comentario" id="coment" placeholder="Deixe aqui seu comentário" class="col-md-12"></textarea>
                    <div class="d-flex justify-content-end">
                        <button type="submit" class="btn btn-danger col-md-4">Submit</button>
                    </div>
                </form>
                <br />
                <p class="text-danger">
                    <b class="text-uppercase">{{nome}}</b> em {{data}}
                </p>
                <p class="text-break text-justify">
                    {{comentario}}
                </p>
            </div>
        </div>

    </div>

</template>

<script>

    export default {
        name: 'PostForm',
        props: {
            img: String,
            ttl: String,
            txt: String
        },
        data() {
            return {
                imagem: this.img,
                titulo: this.ttl,
                texto: this.txt,
                comentario: 'Deixe aqui seu comentário',
                nome: 'Seu nome',
                data: '08/02/2023'
            }

        }
    }

</script>


<style scoped>

    #ImagemContainer {
        min-width: 100vh;
    }

    #textos {
        margin-left: 10vh;
        margin-right: 10vh;
        margin-top: 2vh;
        text-align: justify;
    }

    #postG{
        padding-bottom: 2vh;
        margin-bottom: 2vh;
    }

    #coments {
        margin-left: 18vh;
        padding-top: 2vh;
        text-align: justify;
        margin-bottom: 20vh;
        padding-bottom: 10vh;
    }


    #name{
        height: 5vh;
    }
    #coment{
        height: 15vh;
    }

    .btn {
        --bs-btn-border-radius: 0rem;
    }
</style>
