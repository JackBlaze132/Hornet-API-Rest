// @ts-check
import { defineConfig } from 'astro/config';
import path from 'path'


import svelte from '@astrojs/svelte';

import tailwind from '@astrojs/tailwind';

import icon from 'astro-icon';

import AutoImport from 'unplugin-auto-import/vite';

// https://astro.build/config
export default defineConfig({
  integrations: [svelte(), tailwind(), icon()],
  vite:{
    /*plugins: [
      AutoImport({
        imports: [{
          'astro-icon/components':[
            'Icon'
          ]
        }],
        dts: true,  // Genera un archivo .d.ts si estás usando TypeScript
        eslintrc: {
          enabled: true,  // Genera configuración de ESLint si lo estás usando
        },
      })
    ],*/
    optimizeDeps: {
      include: ['astro-icon']
    },
    define: { 'process.env': {} },
    resolve: {
      alias: {
        '@components': path.resolve('./src/components'),
        '@layouts': path.resolve('./src/layouts'),
        '@pages': path.resolve('./src/pages'),
        '@styles': path.resolve('./src/styles'),
        '@images': path.resolve('./public/assets/images'),
        '@public-img': path.resolve('../assets/images'),
        '@utils': path.resolve('./src/utils')
        // Agrega más alias según sea necesario
      },
    },
    server:{
      proxy:{
        '/api':{
          target:  'http://localhost:8090',
          changeOrigin: true,
          rewrite:(path) => path.replace(/^\/api/, '')   
        },
      }
    },
    }

});