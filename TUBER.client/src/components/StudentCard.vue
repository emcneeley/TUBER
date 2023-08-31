<template>
  <div class="container-fluid">
    <div class="row">
      <div class="col-md-4">
        <div class="card bgImg">
          <h3 class="text-white text-center text"><b>STUDENT</b></h3>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  setup() {
    return {};
  },
};
</script>

<style lang="scss" scoped>
.bgImg {
  position: relative;
  background-image: url("../assets/img/books.jpg");
  background-repeat: no-repeat;
  background-position: center center;
  background-size: cover;
  height: 50vh;
  width: 125%;
  display: flex;
  flex-direction: column;
  justify-content: flex-end;
}

.text {
  position: absolute;
  bottom: 15%;
  width: 100%;
  margin: 0;
}
</style>
