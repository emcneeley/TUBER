<template>
  <!-- //SECTION Cards -->
  <!-- <section class="row justify-content-center">
          <div class="col-12">
            <div class="d-flex justify-content-around my-3 rounded p-3 ">
              <StudentCard />
              <TutorCard />
            </div>
          </div>
        </section> -->

  <!-- //SECTION Fancy -->
  <!-- <div class="bgImg">
    <div class="container-fluid">
      <div class="row justify-content-center align-items-center">
        <div class="col-md-12">
          <h1 class="text-white my-5 mx-3 Logo"><b>TUBER</b></h1>
        </div>

        <div class="col-md-6 col-lg-3 my-3">
          <div class="card tutor">
            <h3 class="text-white text-center text"><b>TUTOR</b></h3>
          </div>
        </div>

        <div class="col-md-6 col-lg-3 my-3">
          <div class="card student">
            <h3 class="text-white text-center text"><b>STUDENT</b></h3>
          </div>
        </div>

      </div>
    </div>
  </div> -->

  <!-- //SECTION  Minimalistic-->

  <div class="bgImg">
    <div class="container-fluid">
      <div class="row justify-content-center align-items-center">
        <div class="col-md-12">
          <h1 class="text-white my-5 mx-3 Logo"><b>TUBER</b></h1>
        </div>
        <h1 class="d-flex justify-content-center text-white">WELCOME, USER</h1>
        <img src="../assets/img/profileImg.png" alt="profile image" class="p-5 profileImg">
        <h5 class="d-flex justify-content-center text-white p-1">TUBER AS</h5>
        <div class="d-flex justify-content-around">
          <p class="button bg-dark rounded text-white p-1"><b>STUDENT</b></p>
          <p class="button bg-dark rounded text-white p-1"><b>TUTOR</b></p>
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
  background-image: url("../assets/img/bg.jpg");
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

.tutor {
  position: relative;
  background-image: url("../assets/img/chalkboard.jpg");
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
  height: 50vh;
  width: 100%;
  display: flex;
  flex-direction: column;
  justify-content: flex-end;
}

.student {
  position: relative;
  background-image: url("../assets/img/books.jpg");
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
  height: 50vh;
  width: 100%;
  display: flex;
  flex-direction: column;
  justify-content: flex-end;
}

.profileImg {
  height: 30vh;
  width: 30vh;
}
</style>
