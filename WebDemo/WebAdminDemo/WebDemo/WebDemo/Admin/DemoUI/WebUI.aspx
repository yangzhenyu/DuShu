<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/DemoUI/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebUI.aspx.cs" Inherits="WebDemo.Admin.DemoUI.WebUI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a href="http://twitter.github.com/bootstrap/base-css.html">详细的css介绍页面</a>

    <a href="http://twitter.github.com/bootstrap/javascript.html">详细的JavaScript介绍页面</a>




    <div class="container navbar-wrapper">
        <div class="navbar navbar-inverse">
            <div class="navbar-inner">
                <!-- Responsive Navbar Part 1: Button for triggering responsive navbar (not covered in tutorial). Include responsive CSS to utilize. -->
                <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </a>
                <a class="brand" href="#">Project name</a>
                <!-- Responsive Navbar Part 2: Place all navbar contents you want collapsed withing .navbar-collapse.collapse. -->
                <div class="nav-collapse collapse">
                    <ul class="nav">
                        <li class="active"><a href="#">Home</a></li>
                        <li><a href="#about">About</a></li>
                        <li><a href="#contact">Contact</a></li>
                        <!-- Read about Bootstrap dropdowns at http://twitter.github.com/bootstrap/javascript.html#dropdowns -->
                        <li class="dropdown open">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Dropdown <b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li class="nav-header">Nav header</li>
                                <li><a href="#">Separated link</a></li>
                                <li><a href="#">One more separated link</a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
                <!--/.nav-collapse -->
            </div>
            <!-- /.navbar-inner -->
        </div>
        <!-- /.navbar -->

    </div>
    <a class="btn" href="#">View details »</a>

    <select>
        <option>1</option>
        <option>2</option>
        <option>3</option>
        <option>4</option>
        <option>5</option>
    </select>

    <select multiple="multiple">
        <option>1</option>
        <option>2</option>
        <option>3</option>
        <option>4</option>
        <option>5</option>
    </select>
    <label class="checkbox">
        <input type="checkbox" value="">
        Option one is this and that—be sure to include why it's great
    </label>

    <label class="radio">
        <input type="radio" name="optionsRadios" id="optionsRadios1" value="option1" checked>
        Option one is this and that—be sure to include why it's great
    </label>
    <label class="radio">
        <input type="radio" name="optionsRadios" id="optionsRadios2" value="option2">
        Option two can be something else and selecting it will deselect option one
    </label>

    <p>
        <button class="btn btn-large btn-primary" type="button">Large button</button>
        <button class="btn btn-large" type="button">Large button</button>
    </p>
    <p>
        <button class="btn btn-primary" type="button">Default button</button>
        <button class="btn" type="button">Default button</button>
    </p>
    <p>
        <button class="btn btn-small btn-primary" type="button">Small button</button>
        <button class="btn btn-small" type="button">Small button</button>
    </p>
    <p>
        <button class="btn btn-mini btn-primary" type="button">Mini button</button>
        <button class="btn btn-mini" type="button">Mini button</button>
    </p>



    <button type="button" class="btn">Default</button>
    <code>btn</code>
    Standard gray button with gradient
        
        
            
        <button type="button" class="btn btn-primary">Primary</button>
    <code>btn btn-primary</code>
    Provides extra visual weight and identifies the primary action in a set of buttons
        
        
            
        <button type="button" class="btn btn-info">Info</button>
    <code>btn btn-info</code>
    Used as an alternative to the default styles
        
        
            
        <button type="button" class="btn btn-success">Success</button>
    <code>btn btn-success</code>
    Indicates a successful or positive action
        
        
            
        <button type="button" class="btn btn-warning">Warning</button>
    <code>btn btn-warning</code>
    Indicates caution should be taken with this action
        
        
            
        <button type="button" class="btn btn-danger">Danger</button>
    <code>btn btn-danger</code>
    Indicates a dangerous or potentially negative action
        
        
            
        <button type="button" class="btn btn-inverse">Inverse</button>
    <code>btn btn-inverse</code>
    Alternate dark gray button, not tied to a semantic action or use
        
        
            
        <button type="button" class="btn btn-link">Link</button>
    <code>btn btn-link</code>
    Deemphasize a button by making it look like a link while maintaining button behavior
    
        <a class="btn" href="">Link</a>
    <button class="btn" type="submit">Button</button>
    <input class="btn" type="button" value="Input">
    <input class="btn" type="submit" value="Submit">
    <div class="control-group">

        <label class="control-label" for="inputIcon">Email address</label>

        <div class="controls">

            <div class="input-prepend">
                <span class="add-on"><i class="icon-envelope"></i></span>

                <input class="span2" id="inputIcon" type="text">
            </div>

        </div>

    </div>
    <div class="btn-toolbar">
        <div class="btn-group">

            <a class="btn" href="#"><i class="icon-align-left"></i></a>
            <a class="btn" href="#"><i class="icon-align-center"></i></a>
            <a class="btn" href="#"><i class="icon-align-right"></i></a>
            <a class="btn" href="#"><i class="icon-align-justify"></i></a>
        </div>
    </div>
    <div class="btn-group">
        <a class="btn btn-primary" href="#"><i class="icon-user icon-white"></i>User</a>
        <a class="btn btn-primary dropdown-toggle" data-toggle="dropdown" href="#"><span class="caret"></span></a>
        <ul class="dropdown-menu">
            <li><a href="#"><i class="icon-pencil"></i>Edit</a></li>
            <li><a href="#"><i class="icon-trash"></i>Delete</a></li>
            <li><a href="#"><i class="icon-ban-circle"></i>Ban</a></li>
            <li class="divider"></li>
            <li><a href="#"><i class="i"></i>Make admin</a></li>
        </ul>
    </div>

    -----------------------javascript------------------------- 
    
    <a class="close" data-dismiss="alert" href="#">9876</a>
    <div class="alert alert-block alert-error fade in">

        <button class="close" type="button" data-dismiss="alert">×</button>
        <h4 class="alert-heading">Oh snap! You got an error!</h4>
        <p>Change this and that and try again. Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Cras mattis consectetur purus sit amet fermentum.</p>
        <p>
            <a class="btn btn-danger" href="#">Take this action</a> <a class="btn" href="#">Or do this</a>
        </p>

    </div>
</asp:Content>

