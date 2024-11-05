/** @type {import('tailwindcss').Config} */
export default {
  content: [
    "./index.html",
    "./src/**/*.{js,ts,jsx,tsx}",
  ],
  theme: {
    extend: {
      fontFamily: {
        'newsreader': ['"Newsreader"', 'serif'],
        'montserrat-alt': ['"Montserrat Alternates"', 'sans-serif'],
      },
      backgroundImage: {
        'hero-pattern': "url('src/assets/Rectangle35.svg')",
      }
    },
  },
  plugins: [],
}