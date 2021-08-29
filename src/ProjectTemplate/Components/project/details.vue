<template>
    <div class="row col-12">
        <div class="col-3">Name</div>
        <div class="col-9">{{project.name}}</div>
        <br /><br />
        <div class="col-3">Details</div>
        <div class="col-9">{{project.details}}</div>
        <br /><br />
        <div class="col-3">Start Date</div>
        <div class="col-9">{{project.startDate}}</div>
        <br /><br />
        <div class="col-3">End Date</div>
        <div class="col-9">{{project.endDate}}</div>
        <br /><br />
        <div class="col-3">Owner</div>
        <div class="col-9">{{project.owner}}</div>
    </div>

</template>
<script>
    export default {
        data() {
            return {
                project: {}
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
                const response = await axios.get("/api/project/details/" + this.$route.params.id, settings);
                this.project = response.data;
            } catch (e) {
                return e;
            }
        }
    }
</script>

<style scoped>
</style>
