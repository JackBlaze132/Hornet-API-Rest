// @ts-check
import { defineConfig } from 'astro/config';
import react from '@astrojs/react';
import AutoImport from 'unplugin-auto-import/vite';
import tailwind from '@astrojs/tailwind';

// Configuración de Astro
export default defineConfig({
  integrations: [react(), tailwind()],
  vite: {
    plugins: [
      AutoImport({
        imports: [
          {
            '@nextui-org/react': [
              'Button',  // Agrega los componentes de NextUI que vas a utilizar
              'ButtonGroup',
              'Card',
              'Input',
              'Modal',
              'Avatar',
              'Tooltip',
            ],
          },
        ],
        dts: true,  // Genera un archivo .d.ts si estás usando TypeScript
        eslintrc: {
          enabled: true,  // Genera configuración de ESLint si lo estás usando
        },
      }),
    ],
  },
});
