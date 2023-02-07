<template>
    <div id="App">
        <div id="blog-posts-events-demo">
            <div :style="{ fontSize: postFontSize + 'em' }">
                <BlogPost v-for="post in posts"
                           v-bind:key="post.id"
                           v-bind:post="post"
                           v-on:enlarge-text="postFontSize += 0.1"></BlogPost>
            </div>
        </div>      
    </div>
</template>

<script>

    export default {
        name: 'BlogPost',
        props: ['post'],
        template: `
            <div class="BlogPost">
                <h3>{{ post.title }}</h3>
                <button v-on:click="$emit('enlarge-text')">
                  Enlarge text
                </button>
                <div v-html="post.content"></div>
            </div>
            `
    }

</script>


<style scoped>
    h3 {
      margin: 40px 0 0;
    }
    ul {
      list-style-type: none;
      padding: 0;
    }
    li {
      display: inline-block;
      margin: 0 10px;
    }
    a {
      color: #42b983;
    }
    #banner {
        margin-bottom: 12px;
        max-height: 20vh;
        padding-top: 13vh;
        padding-bottom: 8vh;
        background-image: radial-gradient(#5347b5,#2ddde0);
    }
    #post {
        margin-bottom: 12px;
        min-height: 40vh;
        padding-top: 0vh;
    }

    #titulo_banner{
        color: white;
    }

    #post-img {
        max-height: 20vh;
    }
</style>
