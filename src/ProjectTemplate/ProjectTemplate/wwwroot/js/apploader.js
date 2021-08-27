const homePage = () => loadModule('/Vue/Load/home.vue', options);
const project_list = () => loadModule('/Vue/Load/project_list.vue', options);
const project_detail = () => loadModule('/Vue/Load/project_details.vue', options);

const options = {
    moduleCache: {
        vue: Vue
    },
    async getFile(url) {

        const res = await fetch(url);
        if (!res.ok)
            throw Object.assign(new Error(res.statusText + ' ' + url), { res });
        return {
            getContentData: asBinary => asBinary ? res.arrayBuffer() : res.text(),
        }
    },
    addStyle(textContent) {

        const style = Object.assign(document.createElement('style'), { textContent });
        const ref = document.head.getElementsByTagName('style')[0] || null;
        document.head.insertBefore(style, ref);
    },
};

const { loadModule } = window['vue3-sfc-loader'];

const routes = [
    { path: '/', component: homePage},
    { path: '/projects', component: project_list },
    { path: '/projects/:id', component: project_detail }
];

// 3. Create the router instance and pass the `routes` option
// You can pass in additional options here, but let's
// keep it simple for now.
const router = VueRouter.createRouter({
    // 4. Provide the history implementation to use. We are using the hash history for simplicity here.
    history: VueRouter.createWebHashHistory(),
    routes, // short for `routes: routes`
});

// 5. Create and mount the root instance.
const app = Vue.createApp({});
// Make sure to _use_ the router instance to make the
// whole app router-aware.

app.use(router);
app.mount('#app');