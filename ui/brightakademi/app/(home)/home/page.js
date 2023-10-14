import React from 'react'

function Home() {
  return (
    <main>
    {/*? slider Area Start*/}
    <section className="slider-area ">
      <div className="slider-active">
        {/* Single Slider */}
        <div className="single-slider slider-height d-flex align-items-center">
          <div className="container">
            <div className="row">
              <div className="col-xl-6 col-lg-7 col-md-12">
                <div className="hero__caption">
                  <h1 data-animation="fadeInLeft" data-delay="0.2s">
                    Online öğrenim
                    <br /> merkezi  
                  </h1>
                  <p data-animation="fadeInLeft" data-delay="0.4s">
                  Birinci sınıf üniversitelerden ve şirketlerden çevrimiçi kurslar, sertifikalar ve dereceler ile becerilerinizi geliştirin
                  </p>
                  <a
                    href="#"
                    className="btn hero-btn"
                    data-animation="fadeInLeft"
                    data-delay="0.7s"
                  >
                    Ücretsi Katıl
                  </a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
    {/* ? services-area */}
    <div className="services-area">
      <div className="container">
        <div className="row justify-content-sm-center">
          <div className="col-lg-4 col-md-6 col-sm-8">
            <div className="single-services mb-30">
              <div className="features-icon">
                <img src="assets/img/icon/icon1.svg" alt="" />
              </div>
              <div className="features-caption">
                <h3>60+ UX courses</h3>
                <p>The automated process all your website tasks.</p>
              </div>
            </div>
          </div>
          <div className="col-lg-4 col-md-6 col-sm-8">
            <div className="single-services mb-30">
              <div className="features-icon">
                <img src="assets/img/icon/icon2.svg" alt="" />
              </div>
              <div className="features-caption">
                <h3>Expert instructors</h3>
                <p>The automated process all your website tasks.</p>
              </div>
            </div>
          </div>
          <div className="col-lg-4 col-md-6 col-sm-8">
            <div className="single-services mb-30">
              <div className="features-icon">
                <img src="assets/img/icon/icon3.svg" alt="" />
              </div>
              <div className="features-caption">
                <h3>Life time access</h3>
                <p>The automated process all your website tasks.</p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    {/* Courses area start */}
    <div className="courses-area section-padding40 fix">
      <div className="container">
        <div className="row justify-content-center">
          <div className="col-xl-7 col-lg-8">
            <div className="section-tittle text-center mb-55">
              <h2>Öne çıkan kurslarımız</h2>
            </div>
          </div>
        </div>
        <div className="courses-actives">
          {/* Single */}
          <div className="properties pb-20">
            <div className="properties__card">
              <div className="properties__img overlay1">
                <a href="#">
                  <img src="assets/img/gallery/featured1.png" alt="" />
                </a>
              </div>
              <div className="properties__caption">
                <p>User Experience</p>
                <h3>
                  <a href="#">Fundamental of UX for Application design</a>
                </h3>
                <p>
                  The automated process all your website tasks. Discover tools
                  and techniques to engage effectively with vulnerable children
                  and young people.
                </p>
                <div className="properties__footer d-flex justify-content-between align-items-center">
                  <div className="restaurant-name">
                    <div className="rating">
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star-half" />
                    </div>
                    <p>
                      <span>(4.5)</span> based on 120
                    </p>
                  </div>
                  <div className="price">
                    <span>$135</span>
                  </div>
                </div>
                <a href="#" className="border-btn border-btn2">
                  Find out more
                </a>
              </div>
            </div>
          </div>
          {/* Single */}
          {/* Single */}
          <div className="properties pb-20">
            <div className="properties__card">
              <div className="properties__img overlay1">
                <a href="#">
                  <img src="assets/img/gallery/featured2.png" alt="" />
                </a>
              </div>
              <div className="properties__caption">
                <p>User Experience</p>
                <h3>
                  <a href="#">Fundamental of UX for Application design</a>
                </h3>
                <p>
                  The automated process all your website tasks. Discover tools
                  and techniques to engage effectively with vulnerable children
                  and young people.
                </p>
                <div className="properties__footer d-flex justify-content-between align-items-center">
                  <div className="restaurant-name">
                    <div className="rating">
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star-half" />
                    </div>
                    <p>
                      <span>(4.5)</span> based on 120
                    </p>
                  </div>
                  <div className="price">
                    <span>$135</span>
                  </div>
                </div>
                <a href="#" className="border-btn border-btn2">
                  Find out more
                </a>
              </div>
            </div>
          </div>
          {/* Single */}
          {/* Single */}
          <div className="properties pb-20">
            <div className="properties__card">
              <div className="properties__img overlay1">
                <a href="#">
                  <img src="assets/img/gallery/featured3.png" alt="" />
                </a>
              </div>
              <div className="properties__caption">
                <p>User Experience</p>
                <h3>
                  <a href="#">Fundamental of UX for Application design</a>
                </h3>
                <p>
                  The automated process all your website tasks. Discover tools
                  and techniques to engage effectively with vulnerable children
                  and young people.
                </p>
                <div className="properties__footer d-flex justify-content-between align-items-center">
                  <div className="restaurant-name">
                    <div className="rating">
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star-half" />
                    </div>
                    <p>
                      <span>(4.5)</span> based on 120
                    </p>
                  </div>
                  <div className="price">
                    <span>$135</span>
                  </div>
                </div>
                <a href="#" className="border-btn border-btn2">
                  Find out more
                </a>
              </div>
            </div>
          </div>
          {/* Single */}
          {/* Single */}
          <div className="properties pb-20">
            <div className="properties__card">
              <div className="properties__img overlay1">
                <a href="#">
                  <img src="assets/img/gallery/featured2.png" alt="" />
                </a>
              </div>
              <div className="properties__caption">
                <p>User Experience</p>
                <h3>
                  <a href="#">Fundamental of UX for Application design</a>
                </h3>
                <p>
                  The automated process all your website tasks. Discover tools
                  and techniques to engage effectively with vulnerable children
                  and young people.
                </p>
                <div className="properties__footer d-flex justify-content-between align-items-center">
                  <div className="restaurant-name">
                    <div className="rating">
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star" />
                      <i className="fas fa-star-half" />
                    </div>
                    <p>
                      <span>(4.5)</span> based on 120
                    </p>
                  </div>
                  <div className="price">
                    <span>$135</span>
                  </div>
                </div>
                <a href="#" className="border-btn border-btn2">
                  Find out more
                </a>
              </div>
            </div>
          </div>
          {/* Single */}
        </div>
      </div>
    </div>
    {/* Courses area End */}
    {/*? About Area-1 Start */}
    <section className="about-area1 fix pt-10">
      <div className="support-wrapper align-items-center">
        <div className="left-content1">
          <div className="about-icon">
            <img src="assets/img/icon/about.svg" alt="" />
          </div>
          {/* section tittle */}
          <div className="section-tittle section-tittle2 mb-55">
            <div className="front-text">
              <h2 className="">Online hocalarla yeni şeyler öğrenin</h2>
              <p>
              Tüm web sitesi görevlerinizi otomatikleştirin. Araçları keşfedin ve
                savunmasız çocuklarla etkili bir şekilde iletişim kurma teknikleri ve
                genç insanlar.
              </p>
            </div>
          </div>
          <div className="single-features">
            <div className="features-icon">
              <img src="assets/img/icon/right-icon.svg" alt="" />
            </div>
            <div className="features-caption">
              <p>
               Savunmasız çocuklarla etkili bir şekilde iletişim kurma teknikleri ve
                genç insanlar.
              </p>
            </div>
          </div>
          <div className="single-features">
            <div className="features-icon">
              <img src="assets/img/icon/right-icon.svg" alt="" />
            </div>
            <div className="features-caption">
              <p>
              Dünyanın dört bir yanından birlikte öğrenen milyonlarca insana katılın.
              </p>
            </div>
          </div>
          <div className="single-features">
            <div className="features-icon">
              <img src="assets/img/icon/right-icon.svg" alt="" />
            </div>
            <div className="features-caption">
              <p>
              Dünyanın dört bir yanından birlikte öğrenen milyonlarca insana katılın.
                Çevrimiçi öğrenme kolay ve doğaldır.
              </p>
            </div>
          </div>
        </div>
        <div className="right-content1">
          {/* img */}
          <div className="right-img">
            <img src="assets/img/gallery/about.png" alt="" />
            <div className="video-icon">
              <a
                className="popup-video btn-icon"
                href="https://www.youtube.com/watch?v=up68UAfH0d0"
              >
                <i className="fas fa-play" />
              </a>
            </div>
          </div>
        </div>
      </div>
    </section>
    {/* About Area End */}
    {/*? top subjects Area Start */}
    <div className="topic-area section-padding40">
      <div className="container">
        <div className="row justify-content-center">
          <div className="col-xl-7 col-lg-8">
            <div className="section-tittle text-center mb-55">
              <h2>En iyi konuları keşfedin</h2>
            </div>
          </div>
        </div>
        <div className="row">
          <div className="col-lg-3 col-md-4 col-sm-6">
            <div className="single-topic text-center mb-30">
              <div className="topic-img">
                <img src="assets/img/gallery/topic1.png" alt="" />
                <div className="topic-content-box">
                  <div className="topic-content">
                    <h3>
                      <a href="#">Programing</a>
                    </h3>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-4 col-sm-6">
            <div className="single-topic text-center mb-30">
              <div className="topic-img">
                <img src="assets/img/gallery/topic2.png" alt="" />
                <div className="topic-content-box">
                  <div className="topic-content">
                    <h3>
                      <a href="#">Programing</a>
                    </h3>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-4 col-sm-6">
            <div className="single-topic text-center mb-30">
              <div className="topic-img">
                <img src="assets/img/gallery/topic3.png" alt="" />
                <div className="topic-content-box">
                  <div className="topic-content">
                    <h3>
                      <a href="#">Programing</a>
                    </h3>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-4 col-sm-6">
            <div className="single-topic text-center mb-30">
              <div className="topic-img">
                <img src="assets/img/gallery/topic4.png" alt="" />
                <div className="topic-content-box">
                  <div className="topic-content">
                    <h3>
                      <a href="#">Programing</a>
                    </h3>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-4 col-sm-6">
            <div className="single-topic text-center mb-30">
              <div className="topic-img">
                <img src="assets/img/gallery/topic5.png" alt="" />
                <div className="topic-content-box">
                  <div className="topic-content">
                    <h3>
                      <a href="#">Programing</a>
                    </h3>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-4 col-sm-6">
            <div className="single-topic text-center mb-30">
              <div className="topic-img">
                <img src="assets/img/gallery/topic6.png" alt="" />
                <div className="topic-content-box">
                  <div className="topic-content">
                    <h3>
                      <a href="#">Programing</a>
                    </h3>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-4 col-sm-6">
            <div className="single-topic text-center mb-30">
              <div className="topic-img">
                <img src="assets/img/gallery/topic7.png" alt="" />
                <div className="topic-content-box">
                  <div className="topic-content">
                    <h3>
                      <a href="#">Programing</a>
                    </h3>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-3 col-md-4 col-sm-6">
            <div className="single-topic text-center mb-30">
              <div className="topic-img">
                <img src="assets/img/gallery/topic8.png" alt="" />
                <div className="topic-content-box">
                  <div className="topic-content">
                    <h3>
                      <a href="#">Programing</a>
                    </h3>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div className="row justify-content-center">
          <div className="col-xl-12">
            <div className="section-tittle text-center mt-20">
              <a href="courses.html" className="border-btn">
                View More Subjects
              </a>
            </div>
          </div>
        </div>
      </div>
    </div>
    {/* top subjects End */}
    {/*? About Area-3 Start */}
    <section className="about-area3 fix">
      <div className="support-wrapper align-items-center">
        <div className="right-content3">
          {/* img */}
          <div className="right-img">
            <img src="assets/img/gallery/about3.png" alt="" />
          </div>
        </div>
        <div className="left-content3">
          {/* section tittle */}
          <div className="section-tittle section-tittle2 mb-20">
            <div className="front-text">
              <h2 className="">Alacağınız kurslardaki öğrenici kazanımlarıe</h2>
            </div>
          </div>
          <div className="single-features">
            <div className="features-icon">
              <img src="assets/img/icon/right-icon.svg" alt="" />
            </div>
            <div className="features-caption">
              <p>
              Savunmasız çocuklarla etkili bir şekilde iletişim kurma teknikleri ve
                genç insanlar.
              </p>
            </div>
          </div>
          <div className="single-features">
            <div className="features-icon">
              <img src="assets/img/icon/right-icon.svg" alt="" />
            </div>
            <div className="features-caption">
              <p>
              Dünyanın dört bir yanından birlikte öğrenen milyonlarca insana katılın.
              </p>
            </div>
          </div>
          <div className="single-features">
            <div className="features-icon">
              <img src="assets/img/icon/right-icon.svg" alt="" />
            </div>
            <div className="features-caption">
              <p>
              Dünyanın dört bir yanından birlikte öğrenen milyonlarca insana katılın.
                Çevrimiçi öğrenme kolay ve doğaldır.
              </p>
            </div>
          </div>
        </div>
      </div>
    </section>
    {/* About Area End */}
    {/*? Team */}
    <section className="team-area section-padding40 fix">
      <div className="container">
        <div className="row justify-content-center">
          <div className="col-xl-7 col-lg-8">
            <div className="section-tittle text-center mb-55">
              <h2>Eğitimciler </h2>
            </div>
          </div>
        </div>
        <div className="team-active">
          <div className="single-cat text-center">
            <div className="cat-icon">
              <img src="assets/img/gallery/team1.png" alt="" />
            </div>
            <div className="cat-cap">
              <h5>
                <a href="services.html">Mr. Urela</a>
              </h5>
              <p>The automated process all your website tasks.</p>
            </div>
          </div>
          <div className="single-cat text-center">
            <div className="cat-icon">
              <img src="assets/img/gallery/team2.png" alt="" />
            </div>
            <div className="cat-cap">
              <h5>
                <a href="services.html">Mr. Uttom</a>
              </h5>
              <p>The automated process all your website tasks.</p>
            </div>
          </div>
          <div className="single-cat text-center">
            <div className="cat-icon">
              <img src="assets/img/gallery/team3.png" alt="" />
            </div>
            <div className="cat-cap">
              <h5>
                <a href="services.html">Mr. Shakil</a>
              </h5>
              <p>The automated process all your website tasks.</p>
            </div>
          </div>
          <div className="single-cat text-center">
            <div className="cat-icon">
              <img src="assets/img/gallery/team4.png" alt="" />
            </div>
            <div className="cat-cap">
              <h5>
                <a href="services.html">Mr. Arafat</a>
              </h5>
              <p>The automated process all your website tasks.</p>
            </div>
          </div>
          <div className="single-cat text-center">
            <div className="cat-icon">
              <img src="assets/img/gallery/team3.png" alt="" />
            </div>
            <div className="cat-cap">
              <h5>
                <a href="services.html">Mr. saiful</a>
              </h5>
              <p>The automated process all your website tasks.</p>
            </div>
          </div>
        </div>
      </div>
    </section>
    {/* Services End */}
    {/*? About Area-2 Start */}
    <section className="about-area2 fix pb-padding">
      <div className="support-wrapper align-items-center">
        <div className="right-content2">
          {/* img */}
          <div className="right-img">
            <img src="assets/img/gallery/about2.png" alt="" />
          </div>
        </div>
        <div className="left-content2">
          {/* section tittle */}
          <div className="section-tittle section-tittle2 mb-20">
            <div className="front-text">
              <h2 className="">
              Kişisel ve profesyonel hedeflerinize doğru bir sonraki adımı bizimle atın.
              </h2>
              <p>
              Tüm web sitesi görevlerinizi otomatikleştirin. Araçları keşfedin ve
                savunmasız çocuklarla etkili bir şekilde iletişim kurma teknikleri ve
                genç insanlar.
              </p>
              <a href="#" className="btn">
                Hemen bize katılın
              </a>
            </div>
          </div>
        </div>
      </div>
    </section>
    {/* About Area End */}
  </main>
  )
}

export default Home