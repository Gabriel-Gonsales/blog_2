<template>
    <div>
        <div class="bg-light" id="postG">
            <div id="contentImg">
                <img class="col-12" id="ImagemContainer" :src="imagem" />
            </div>
            <b-container class="col-md-10">
                <div class="" id="textos">
                    <h3 class="text-danger" id="titulo">
                        <b>{{titulo}}</b>
                    </h3>
                    <p id="texto">
                        {{texto}}
                    </p>
                </div>
            </b-container>
        </div>
        <div class="bg-light">
            <b-container class="col-md-10">
                <div id="coments" class="">
                    <h2 class="text-danger">
                        <b>Deixe seu comentário</b>
                    </h2>
                    <form class="" id="formulario" @submit="createComment()">
                        <input v-model="nome" id="name" placeholder="Seu nome" class="col-12 col-sm-12 col-md-12" type="text" />
                        <br /><br />
                        <textarea v-model="comentario" id="coment" placeholder="Deixe aqui seu comentário" class="col-12 col-sm-12 col-md-12"></textarea>
                        <div class="d-flex justify-content-around">
                            <button type="submit" class="btn btn-danger col-md-4">Submit</button>
                        </div>
                    </form>
                    <br />
                    <ComentariosPost v-for="(comment) in comments"
                                     :key="comment.id"
                                     :cmt="comment.content"
                                     :name="comment.personName"
                                     :date="comment.postDate"
                                     class="post"></ComentariosPost>
                </div>
            </b-container>
        </div>

    </div>

</template>

<script>
    import ComentariosPost from './CommentBox.vue'

    export default {
        name: 'PostForm',
        components: {
            ComentariosPost
        },
        props: {
            id: String,
            img: String,
            ttl: String,
            txt: String,
            cmt: String
        },
        data() {
            return {
                comments: [],
                pId: this.id,
                imagem: this.img,
                titulo: this.ttl,
                texto: this.txt,
                comentario: '',
                nome: '',
                data: ''
            }
        },
        methods: {

            async makePostRequest() {
                const axios = require('axios');
                const response = await axios("https://localhost:51427/api/Post/v1");
                const data = response.data;
                console.log(data);
                console.log(data[0]);
                this.posts = data;
            },
            async makeCommentRequest() {
                const axios = require('axios');
                const response = await axios("https://localhost:51427/api/Comment/v1/findByPostId?Id=" + this.pId);
                const data = response.data;
                console.log(data);
                console.log(data[0]);
                this.comments = data;
            },
            async createComment() {
                console.log("Criou!")

                const data = {
                    content: this.comentario,
                    PersonName: this.nome,
                    postDate: new Date(),
                    postId: this.pId
                }
                const dataJSON = JSON.stringify(data);
                console.log(dataJSON);
                const response = await fetch("https://localhost:51427/api/Comment/v1", {
                    method: "POST",
                    headers: { "Content-Type": "application/json" },
                    body: dataJSON
                });
                const res = await response.json();
                console.log(res);
                this.makeCommentRequest();

                this.nome = '';
                this.comentario = '';
            }
        },
        created() {
            this.makePostRequest()
            this.makeCommentRequest()
        }
    }

</script>


<style scoped>

    #ImagemContainer {
        min-width: 50vw;
    }

    #textos {
        margin-top: 2vh;
        text-align: justify;
    }

    #formulario{
        margin-top: 2vh;
    }

    #postG{
        padding-bottom: 2vh;
        margin-bottom: 1vh;
    }

    #coments {
        padding-top: 2vh;
        text-align: justify;
        margin-bottom: 10vh;
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
