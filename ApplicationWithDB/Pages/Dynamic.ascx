<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Dynamic.ascx.cs" Inherits="ApplicationWithDB.Dynamic" %>

<div class="mt-3 d-flex flex-inline justify-content-center">
    <div class="card" style="width: 18rem;">
  <img src="<%:Image %>"" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title"><%:  Title %></h5>
    <p class="card-text"><%: Description %></p>
    <a href="#" class="btn btn-primary">Go somewhere</a>
  </div>
</div>
</div>