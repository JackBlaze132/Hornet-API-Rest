const { nextui } = require("@nextui-org/react");

/** @type {import('tailwindcss').Config} */
module.exports = {
	content: [
		'./src/**/*.{astro,html,js,jsx,md,mdx,svelte,ts,tsx,vue}',
		"./node_modules/@nextui-org/theme/dist/**/*.{js,ts,jsx,tsx}",
	],
	theme: {
		extend: {
			colors:{
				hornet:{
					500:"#ff004f"
				}
			}
		},
	},
	darkMode: "class",
	plugins: [
		nextui({
			defaultTheme: "dark"
		})
	]
}
