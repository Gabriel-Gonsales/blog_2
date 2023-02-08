import Vue from 'vue'
import App from './App.vue'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue';
import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap-vue/dist/bootstrap-vue.css';
import VueRouter from 'vue-router';
import PagPost from './PagPost.vue';

Vue.use(VueRouter);
Vue.use(BootstrapVue);
Vue.use(IconsPlugin);

Vue.config.productionTip = false

const router = new VueRouter({
    routes: [
        {
            path: '/PagPost',
            component: PagPost
            }
        ]

    })

new Vue({
    router,
    render: h => h(App),
}).$mount('#app')