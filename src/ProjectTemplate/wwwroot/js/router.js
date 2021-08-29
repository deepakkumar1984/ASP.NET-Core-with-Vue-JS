const options = {
    moduleCache: {
        vue: Vue
    },
    async getFile(path) {
        const res = await fetch("/Vue/Load?path=Components/" + path);
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

//Load the vue components
const homePage = () => loadModule('home.vue', options);
const project_list = () => loadModule('project/list.vue', options);
const project_detail = () => loadModule('project/details.vue', options);

const { loadModule } = window['vue3-sfc-loader'];

//Define the routes
const routes = [
    { path: '/', component: homePage },
    { path: '/projects', component: project_list },
    { path: '/projects/:id', component: project_detail }
];

// Create the router instance and pass the `routes` option
// You can pass in additional options here, but let's
// keep it simple for now.
const router = VueRouter.createRouter({
    // 4. Provide the history implementation to use. We are using the hash history for simplicity here.
    history: VueRouter.createWebHashHistory(),
    routes, // short for `routes: routes`
});