<template>
    <b-container class="col-md-12">
        <div id="coments" class="">
            <br />
            <p class="text-danger">
                <b class="text-uppercase">{{nome}}</b> em {{DS[0]}} às {{DS[1]}}
            </p>
            <p class="text-break text-justify">
                {{comentario}}
            </p>
        </div>
    </b-container>
</template>

<script>

    export default {
        name: 'ComentariosPost',
        props: {
            cmt: String,
            name: String,
            date: String
        },
        data() {
            return {
                comentario: this.cmt,
                nome: this.name,
                data: this.date,
                DS: []
            }

        },
        methods: {
            async dataSplit(){
                this.DS = this.data.split("T");
            }
        },
        created() {
            this.dataSplit()
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
