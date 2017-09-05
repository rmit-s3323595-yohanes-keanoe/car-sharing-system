﻿<%@ Page Title="Ace Rentals Home Page" Language="C#" MasterPageFile="~/Homepage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="car_sharing_system.FrontPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FrontPageHolder" runat="server">
  
  <!-- Intro Section -->
  <section id="intro" class="intro-section">
    <div class="container-full-width">
      
      <!-- Jumbotron Div -->
      <div class=" float-jumbo">
        <img src="Images/logo2.png" />
        <h2>Rent a car anywhere at a touch of a button</h2>          
        <p>
          <a class="btn btn-warning btn-front-page-sign-register" href="Admin_Theme/pages/register.aspx" role="button">Register</a>
          <a class="btn btn-primary btn-front-page-sign-register" href="Admin_Theme/pages/index.aspx" role="button">Login</a>
        </p>
      </div>

      <!-- Carousel Div -->
      <div id="carCarousel" class="carousel slide" data-ride="carousel" data-interval="20000">
        <div class="carousel-inner">
            <div class="item active">
                <!-- Set the first background image using inline CSS below. -->
                <div class="fill" style="background-image:url('/Views/Images/test1.jpg');"></div>
                <div class="carousel-caption">
                    <h2>Caption 1</h2>
                </div>
            </div>
            <div class="item">
                <!-- Set the second background image using inline CSS below. -->
                <div class="fill" style="background-image:url('/Views/Images/test2.jpg');"></div>
                <div class="carousel-caption">
                    <h2>Caption 2</h2>
                </div>
            </div>
            <div class="item">
                <!-- Set the third background image using inline CSS below. -->
                <div class="fill" style="background-image:url('/Views/Images/test3.jpg');"></div>
                <div class="carousel-caption">
                    <h2>Caption 3</h2>
                </div>
            </div>
        </div>
      </div>
    </div>
  </section>

  <!-- About Section -->
  <section id="cars" class="about-section">
    <div class="container-fluid">
      <div class="panel panel-default">
        <div class="panel-heading">
          <h2 id="aa">
            List of cars near you
          </h2>
        </div>
        <div class="panel-body">
          <div id="map"></div>
          <div class="list" >
            <div class="panel">
              <label>Refine Results</label>
              <div class="dropdown">
                <button class="btn btn-primary dropdown-toggle" id="brand-filter" type="button" data-toggle="dropdown">
                  Brand
                  <span class="caret"></span>
                </button>
                <ul class="dropdown-menu" id="brand-filter-dropdown">
                  <li>Audi<</li>
                  <li>Ford</li>
                  <li>Kia</li>
                  <li>Mazda</li>
                  <li>Mini</li>
                  <li>Tesla</li>
                  <li>Toyota</li>
                  <li>Subaru</li>
                  <li>Suzuki</li>
                </ul>
              </div>
              <button class="btn btn-primary" type="button" data-toggle="collapse" data-target="#collapseExample" aria-expanded="true" aria-controls="collapseExample">drop</button>
            </div>
            <div class="collapse in" id="collapseExample">
              <asp:PlaceHolder ID="carlist"  runat="server"/>
              <!-- Panel default
              <div class="panel-default car-panel">
                <div class="panel-heading">
                    <a data-toggle="collapse" href="#collapse1" class="car-panel-title">
                        Suzuki x
                      <span style="float:right;">10km away</span>
                    </a>
                  </div>
                  <div id="collapse1" class="panel-collapse collapse">
                  <div class="panel-body">
                    asdasd asdasd
                  </div>
                </div>
              </div>-->
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  

  <!-- Services Section -->
  <section id="book" class="services-section">
    <div class="container">
      <div class="row">
        <div class="col-lg-12">
          <h1>Services Section</h1>
          <div runat="server" id="hiddenD">
            <h1 id="hiddentext">This should be hidden</h1>
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- Contact Section -->
  <section id="contact" class="contact-section">
    <div class="container">
      <div class="row">
        <div class="col-lg-12">
          <h1>Contact Section</h1>
        </div>
      </div>
    </div>
  </section>

    <script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCVtkFkAt7qjm3egiu1VL8sHI-IJKtE5x8&libraries=geometry"></script>
    <script src="map-features.js"></script>
    

</asp:Content>
