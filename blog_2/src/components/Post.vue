<template>
    <div id="conteinerPrincipal">
        <div id="contentImg">
            <img class="col-md-12" id="ImagemContainer" v-bind:src="imagem" />
        </div>
        <div class="bg-light" id="contentTxt">
            <div class="" id="textos">
                <h3 class="text-justify text-danger" id="titulo">
                    <b>{{titulo}}</b>
                </h3>
                <p class="text-justify text-truncate" id="texto">
                    {{texto}}
                </p>
                 <router-link class="text-danger" to="PagPost.vue">
                   Leia mais
                </router-link>
            </div>
        </div>
    </div>
</template>

<script>

    export default {
        name: 'PostBlog',
        props: {
            img: String,
            ttl: String,
            txt: String
        },
        data() {
            return {
                imagem: this.img,
                titulo: this.ttl,
                texto: this.txt
            }

        }
    }

</script>


<style scoped>

    #conteinerPrincipal {
    }

    #contentImg {
        background-size: 10vh contain;
    }

    #ImagemContainer {
        min-width: 100vh;
        max-height: 30vh;
        object-fit: cover;
    }

    #contentTxt {

    }

    #textos{
        margin-left: 10vh;
        margin-right: 10vh;
        padding-bottom: 2vh;
    }
    #titulo {
        padding-top: 2vh;
    }
</style>
