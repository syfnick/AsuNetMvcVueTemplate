<template>
  <div id="app">
    <router-view/>
  </div>
</template>

<script>

export default {
  name: 'app',
  components: {
  }
}

document.addEventListener('DOMContentLoaded', () => {
  const html = document.querySelector('html')
  let fontSize = window.innerWidth / 7.2
  html.style.fontSize = fontSize + 'px'
})

</script>

<style lang="scss">
@import "@/assets/styles/global.scss";
</style>
