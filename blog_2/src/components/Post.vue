﻿<template>
    <div id="conteinerPrincipal">
        <router-link class="" :to="{name: 'PagPostId',params: {id:idPost}}">
            <div id="contentImg">
                <img class="col-12" id="ImagemContainer" :src="imagem" />
            </div>
        </router-link>

        <div class="bg-light" id="contentTxt">
            <div class="" id="textos">
                <h3 class="text-justify text-danger" id="titulo">
                    <b>{{titulo}}</b>
                </h3>
                <p class="text-justify text-truncate" id="texto">
                    {{texto}}
                </p>
                <router-link class="text-danger" :to="{name: 'PagPostId',params: {id:idPost}}">
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
            idp: Number,
            img: String,
            ttl: String,
            txt: String
        },
        data() {
            return {
                idPost: parseInt(this.idp) - 1,
                imagem: "https://localhost:51427/UploadDir/" + this.img,
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
        min-width: 50vw;
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
