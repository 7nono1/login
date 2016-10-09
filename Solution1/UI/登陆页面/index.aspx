﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="页面_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>山东商务职业学院考勤系统嘎嘎嘎嘎嘎 </title>
	<link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
</head>
<body class="loading-process">
<div class="loading">
	<div class="loading-circle"></div>
	<div class="loading-avatar"><img src="images/avatar@2x.jpg" alt="" width="100" height="100"></div>
	<div class="loading-info">正在努力加载中....</div>
</div>
<div class="section-header">
	<div class="section">
		<nav class="nav" role="navigation">
			<ul>
				<li class="nav-about fade fade1"><a href="#about">关于</a></li>
				<li class="nav-works fade fade4"><a href="#works">登陆</a></li>
				<li class="fade back-home"><a href="#top"></a></li>
				<li class="nav-skill fade fade2"><a href="#skill">学校简介</a></li>
			
			</ul>
		</nav>
	</div>
	<div class="nav-bg"></div>
</div>
<div class="home-bg">
	<img src="images/home-bg.jpg" alt="" width="1000" height="667">
</div>
<div class="section-wrap section-fristpage" data-slide="1"  >
	<div class="section">
		<div class="section-content">
			<p class="fade fade1">Hi，老师好</p>
			<p class="fade fade2">欢迎光临山东商务职业学院考勤系统！</p>
			<p class="fade fade3">请往下滚动，进入下一步 ^_^</p>
		</div>
		<a class="button2 scroll-tip fade fade4" data-slide="3" title="">向下滚动</a>
	</div>
</div>
<div id="about" data-slide="2" data-stellar-background-ratio="0.3" class="section-wrap section-about">
	<div class="section">
		<div class="about-content clearfix section-content">
			<div class="introli">
			  <span class="left_icon"><img class="bio-text bio-icon-1" src="images/bio-icon-1.png" data-stellar-ratio="0.7" ></span>
			  <span class="right_content "><img class="bio-text bio-text-1" src="images/bio-text-1.png" data-stellar-ratio="0.7" ></span>
			</div>
			<div class="introli">
			  <span class="left_icon"><img class="bio-text bio-icon-2" src="images/bio-icon-2.png" data-stellar-ratio="0.7" ></span>
			  <span class="right_content"><img class="bio-text bio-text-2" src="images/bio-text-2.png" data-stellar-ratio="0.7" ></span>
			</div>
			<div class="introli">
			  <span class="left_icon"><img class="bio-text bio-icon-3" src="images/bio-icon-3.png" data-stellar-ratio="0.7" ></span>
			  <span class="right_content"><img class="bio-text bio-text-3" src="images/bio-text-3.png" data-stellar-ratio="0.7" ></span>
			</div>

		</div>

	</div>
	<a class="button2 dark-button2 scroll-tip" style="background-position:0 -60px;" data-slide="3" title=""></a>
</div>
<div id="works" class="section-wrap section-works" data-slide="3" >
	<div class="section">
		<div class="works-content section-content">
        
			<h1>权限登录</h1>
			<div class="works-list clearfix">
				<div class="works-item first fade fade1">
					<a href="#" target="_blank">
						<img src="images/works/yizaojia.jpg" alt="" width="300" height="180">
						<div class="work-info">主页
						  
						</div>
					</a>
				</div>
				<div class="works-item fade fade2">
					<a href="#/" target="_blank">
						<img src="images/works/91zaojia.jpg" alt="" width="300" height="180">
						<div class="work-info">
							<h2>管理员界面</h2>
					
						</div>
					</a>
				</div>
				<div class="works-item fade fade3">
					<a href="#/" target="_blank">
						<img src="images/works/wenku.jpg" alt="" width="300" height="180">
						<div class="work-info">
							<h2>院系领导员界面</h2>
							
						</div>
					</a>
				</div>
				<div class="works-item first fade fade4">
					<a href="#" target="_blank">
						<img src="images/works/shinedeliver.jpg" alt="" width="300" height="180">
						<div class="work-info">
                            <h2>辅导员界面</h2>
							
						</div>
					</a>
				</div>
				<div class="works-item fade fade2">
			    <img src="images/works/wxshop.jpg" alt="" width="300" height="180" runat="server">
						<a href="Default.aspx"><div class="work-info" >
                            <h2>教师界面</h2>
                            </div>
							
						
					</a>
				</div>
			</div>
			
		</div>
		<a class="button2 scroll-tip fade fade4" data-slide="4" title="">向下滚动</a>
	</div>
</div>
<div id="contact" class="section-wrap section-contact" data-slide="4">
	<div class="section">
		<div class="contact-content clearfix section-content">
			<h1>学院简介:</h1>
			<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;山东商务职业学院（Shandong Business Institute）是2006年经山东省人民政府批准设立、国家教育部备案的省属公办全日制普通高校，是“山东特色名校工程”支持建设的技能型人才培养特色高校，在烟台、济南两地办学。学校始于1975年创立的山东省烟台粮食学校，后更名为山东省商务科技学校。</p>
              <a href="http:\\www.sdbi.edu.cn">了解更多信息</a>
		</div>
	</div>
</div>
<div class="overlay"></div>
<div class="state-indicator"></div>

<script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
<script src="js/global.js"></script>
<script src="js/waypoints.min.js"></script>
<script src="js/js.js"></script>
<script src="js/jquery.stellar.min.js"></script>
<div style="text-align:center;">
</div>
</body>
</html>
