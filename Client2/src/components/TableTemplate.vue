<template>
<table class="table-auto text-left border bg-white shadow-md">
    <thead class="bg-slate-800 text-white">
    <tr class="border">
        <!-- Renderiza los encabezados dinámicamente -->
        <th v-for="(header, index) in headers" :key="index" class="px-4 py-2">
        {{ header }}
        </th>
    </tr>
    </thead>
    <tbody>
    <!-- Renderiza las filas de datos dinámicamente -->
    <tr class="border" v-for="(row, rowIndex) in tableData" :key="rowIndex">
        <td
        v-for="(value, colIndex) in row"
        :key="colIndex"
        class="px-4 py-2"
        >
        {{ value }}
        </td>
    </tr>
    </tbody>
</table>
</template>

<script setup lang="ts">
import { defineProps } from 'vue';

// Define las propiedades que recibirá el componente
defineProps({
headers: {
    type: Array as () => string[],
    required: true,
},
tableData: {
    type: Array as () => Array<Record<string, any>>,
    required: true,
},
});
</script>

<style scoped></style>
