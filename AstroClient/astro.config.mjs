// @ts-check
import { defineConfig } from 'astro/config';
import path from 'path';

import react from '@astrojs/react';

import tailwind from '@astrojs/tailwind';

// https://astro.build/config
export default defineConfig({
  integrations: [react(), tailwind()],
  vite:{
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