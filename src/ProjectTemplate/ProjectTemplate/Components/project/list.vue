<template>
    <table class="table">
        <thead>
            <tr>
                <th>Name</th>
                <th>Start</th>
                <th>End</th>
                <th>Owner</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <tr class="datatable-row" v-for="item in list">
                <td data-field="Name" class="datatable-cell">{{item.name}}</td>
                <td data-field="Email" class="datatable-cell">{{item.startDate}}</td>
                <td data-field="Mobile" class="datatable-cell">{{item.endDate}}</td>
                <td data-field="Update On" class="datatable-cell">{{item.owner}}</td>
                <td class="datatable-cell">
                    <a :href="'#/projects/' + item.id" class="btn btn-sm btn-clean btn-icon mr-2">
                        View
                    </a>
                </td>
            </tr>
        </tbody>
    </table>
</template>
<script>
    export default {
        data() {
            return {
                list: []
            }
        },
        async mounted() {
            const settings = {
                headers: {
                    'Content-Type': 'application/json;charset=utf-8',
                    "Accept": "application/json"
                }
            };
            try {
                const response = await axios.get("/api/project/list", settings);
                this.list = response.data;
            } catch (e) {
                return e;
            } 
        }
    }
</script>

<style scoped>
  
</style>
