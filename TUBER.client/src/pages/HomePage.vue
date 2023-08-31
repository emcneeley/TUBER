<template>
  <div class="bgImg">
    <div class="container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1 class="text-white my-5 mx-3 Logo"><b>TUBER</b></h1>
        </div>
        <div class="d-flex justify-content-around">
          <StudentCard />
          <TutorCard />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  setup() {
    return {}
  }
}
</script>

<style scoped lang="scss">
.bgImg {
  background-image: url("../assets/img/library1.jpg");
  background-repeat: no-repeat;
  background-position: center center;
  background-size: cover;
  height: 100vh;
}

.logo {
  font-family: "Yanone Kaffeesatz";
  font-size: 100px;
  display: flex;
  position: absolute;
  bottom: 20vh;
  left: 50%;
  transform: translateX(-50%);
  user-select: none;
}
</style>
