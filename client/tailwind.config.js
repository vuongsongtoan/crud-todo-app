/** @type {import('tailwindcss').Config} */
module.exports = {
  darkMode: 'class',
  content: [
    "./src/**/*.{html,ts}",
    "./src/app/**/*.{html,ts}",
    "./src/index.html"
  ],
  theme: {
    extend: {
      colors: {
        background: {
          light: '#f4f6fb',
          dark: '#23272f',
        },
        foreground: {
          light: '#23272f',
          dark: '#f4f6fb',
        },
        accent: {
          light: '#3b82f6', // xanh dương sáng cho light
          dark: '#a78bfa',  // tím nhạt cho dark mode
        },
        accent2: {
          light: '#7e8ba3',
          dark: '#a78bfa', // tím nhạt cho border dark mode
        },
      },
    },
  },
  plugins: [],
}

