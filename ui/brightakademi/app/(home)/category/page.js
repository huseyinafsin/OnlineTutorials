import React from 'react'
import Courses from '../courses'

function Course() {
  return (
    <main>
  {/*? slider Area Start*/}
  <section className="slider-area slider-area2">
    <div className="slider-active">
      {/* Single Slider */}
      <div className="single-slider slider-height2">
        <div className="container">
          <div className="row">
            <div className="col-xl-8 col-lg-11 col-md-12">
              <div className="hero__caption hero__caption2">
                <h1 data-animation="bounceIn" data-delay="0.2s">
                  Online Eğitim
                </h1>
                {/* breadcrumb Start*/}
                <nav aria-label="breadcrumb">
                  <ol className="breadcrumb">
                    <li className="breadcrumb-item">
                      <a href="index.html">Anasayfa</a>
                    </li>
                    <li className="breadcrumb-item">
                      <a href="#">Kurslar</a>
                    </li>
                  </ol>
                </nav>
                {/* breadcrumb End */}
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  {/* Courses area start */}
    <Courses/>
  {/* Courses area End */}
  {/*? top subjects Area Start */}
  <div className="topic-area">
    <div className="container">
      <div className="row justify-content-center">
        <div className="col-xl-7 col-lg-8">
          <div className="section-tittle text-center mb-55">
            <h2>Eğitim kategorilerimiz</h2>
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
              Daha fazla konuları gör
            </a>
          </div>
        </div>
      </div>
    </div>
  </div>
  {/* top subjects End */}
  {/* ? services-area */}
  <div className="services-area services-area2 section-padding40">
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
</main>

  )
}

export default Course