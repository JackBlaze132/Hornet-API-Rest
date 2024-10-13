<template>
<table class="table-auto text-left border bg-white shadow-md">
    <thead class="bg-slate-800 text-white">
    <tr class="border">
        <th class="px-4 py-2">id</th>
        <th class="px-4 py-2">Name</th>
    </tr>
    </thead>
    <tbody>
        <tr class="border" v-for="row in tableData" :key="row.id">
            <td class="px-4 py-2">{{ row.id }}</td>
            <td class="px-4 py-2">{{ row.name }}</td>
        </tr>
    </tbody>
</table>
</template>

<script setup lang="ts">
interface BodyWork {
    id: number;
    name: string;
}
import { ref} from "vue";
const tableData = ref<BodyWork[]>([]);

const fetchBodyWorks = async () => {
    try {
        const response = await fetch("http://localhost:8090/bodyworks/get");
        if (!response.ok) throw new Error("Error al obtener los datos");
        const data: BodyWork[] = await response.json();
        tableData.value = data;
    } catch (error) {
        console.error("Error al obtener los datos:", error);
    }
};
</script>

<style scoped></style>
